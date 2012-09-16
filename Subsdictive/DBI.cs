using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Subsdictive
{
    class DBI
    {
        private static DBI singleton = null;

        public static DBI GetDBI()
        {
            if (singleton == null)
            {
                singleton = new DBI();
            }
            return singleton;
        }

        private void WriteInteger(FileStream f, int valor)
        {
            byte[] buffer = new byte[4];
            buffer[0] = (byte)(valor&0xFF);
            buffer[1] = (byte)((valor&0xFF00)>>8);
            buffer[2] = (byte)((valor&0xFF0000)>>16);
            buffer[3] = (byte)((valor&0xFF000000)>>24);
            f.Write(buffer, 0, 4);
        }

        private void WriteString(FileStream f, string valor)
        {
            char [] chars = valor.ToCharArray();

            WriteInteger(f, chars.Length);

            foreach (char c in chars)
            {
                byte [] bytes = BitConverter.GetBytes(c);

                for (int i = 0; i < bytes.Length; i++)
                {
                    // Codificamos la cadena (dumb)
                    bytes[i] = (byte)((~((int)bytes[i]))&0xFF);
                }

                WriteInteger(f, bytes.Length);
                f.Write(bytes, 0, bytes.Length);
            }
        }

        private string ReadString(FileStream f)
        {
            int nchars = ReadInteger(f);

            char [] chars = new char[nchars];

            for (int i = 0; i < nchars; i++)
            {
                int nbytes = ReadInteger(f);
                byte [] bytes = new byte[nbytes] ;
                f.Read(bytes, 0, nbytes);

                for (int j = 0; j < bytes.Length; j++)
                {
                    // Decodificamos (dumb)
                    bytes[j] = (byte)((~((int)bytes[j]))&0xFF);
                }

                chars[i] = BitConverter.ToChar(bytes, 0);
            }

            String s = new String(chars);
            return s;
        }

        private int ReadInteger(FileStream f)
        {
            byte[] buffer = new byte[4];
            f.Read(buffer, 0, 4);

            int valor = 0 ;
            valor |= (int)buffer[0] ;
            valor |= ((int)buffer[1])<<8;
            valor |= ((int)buffer[2])<<16;
            valor |= ((int)buffer[3])<<24;

            return valor;
        }

        private void WriteBool(FileStream f, bool valor)
        {
            WriteInteger(f, valor ? 1 : 0);
        }

        private bool ReadBool(FileStream f)
        {
            int valor = ReadInteger(f);
            return valor == 1;
        }

        private void WriteLong(FileStream f, long valor)
        {
            WriteInteger(f, (int)valor);
            WriteInteger(f, (int)(valor>>32));
        }

        private long ReadLong(FileStream f)
        {
            long serial = 0 ;
            int v1 = ReadInteger(f);
            int v2 = ReadInteger(f);
            serial = ((long)v2)<<32;
            serial += v1;
            return serial ;
        }

        private void WriteDateTime(FileStream f, DateTime valor)
        {
            WriteLong(f, valor.ToBinary());
        }

        private DateTime ReadDateTime(FileStream f)
        {
            DateTime valor = DateTime.FromBinary(ReadLong(f));
            return valor;
        }

        private void WriteUser(FileStream f, User u)
        {
            WriteString(f, u.Nick);
            WriteString(f, u.Password);
            WriteBool(f, u.Admin);
        }

        private User ReadUser(FileStream f)
        {
            User u = new User();
            u.Nick = ReadString(f);
            u.Password = ReadString(f);
            u.Admin = ReadBool(f);
            return u;
        }

        private void WriteJuego(FileStream f, Juego j)
        {
            WriteString(f, j.Nombre);
            WriteString(f, j.Directorio);
            WriteString(f, j.FileName);
            WriteBool(f, j.Codificado);
        }

        private Juego ReadJuego(FileStream f)
        {
            Juego j = new Juego();
            j.Nombre = ReadString(f);
            j.Directorio = ReadString(f);
            j.FileName = ReadString(f);
            j.Codificado = ReadBool(f);
            return j;
        }

        private void WriteRegistro(FileStream f, Registro r)
        {
            WriteString(f, r.Nick);
            WriteDateTime(f, r.Inicio);
            WriteInteger(f, r.Minutos);
        }

        private Registro ReadRegistro(FileStream f)
        {
            Registro r = new Registro();
            r.Nick = ReadString(f);
            r.Inicio = ReadDateTime(f);
            r.Minutos = ReadInteger(f);
            return r;
        }

        public void SaveUsers(List<User> lista)
        {
            FileStream write = File.Create(@"C:\Archivos de programa\Subsdictive\users.dat");

            WriteInteger(write, lista.Count);
            foreach (User u in lista)
            {
                WriteUser(write, u);
            }

            write.Close();
        }

        public List<User> GetUsers()
        {
            List<User> lista = new List<User>();

            // Comprobamos si el fichero existe
            try
            {
                File.GetAttributes(@"C:\Archivos de programa\Subsdictive\users.dat");
            }
            catch (System.IO.FileNotFoundException)
            {
                // Lo creamos
                SaveUsers(new List<User>());
            }

            FileStream read = File.OpenRead(@"C:\Archivos de programa\Subsdictive\users.dat");

            int cantidad = ReadInteger(read);

            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(ReadUser(read));
            }

            read.Close();

            return lista;
        }

        public void SaveJuegos(List<Juego> lista)
        {
            FileStream write = File.Create(@"C:\Archivos de programa\Subsdictive\games.dat");

            WriteInteger(write, lista.Count);

            foreach (Juego j in lista)
            {
                WriteJuego(write, j);
            }

            write.Close();
        }

        public List<Juego> GetJuegos()
        {
            List<Juego> lista = new List<Juego>();

            // Comprobamos si el fichero existe
            try
            {
                File.GetAttributes(@"C:\Archivos de programa\Subsdictive\games.dat");
            }
            catch (System.IO.FileNotFoundException)
            {
                // Lo creamos
                SaveJuegos(new List<Juego>());
            }

            FileStream read = File.OpenRead(@"C:\Archivos de programa\Subsdictive\games.dat");

            int cantidad = ReadInteger(read);

            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(ReadJuego(read));
            }

            read.Close();

            return lista;
        }

        public void SaveRegistros(List<Registro> lista)
        {
            FileStream write = File.Create(@"C:\Archivos de programa\Subsdictive\registro.dat");

            WriteInteger(write, lista.Count);

            foreach (Registro r in lista)
            {
                WriteRegistro(write, r);
            }

            write.Close();
        }

        public List<Registro> GetRegistros()
        {
            List<Registro> lista = new List<Registro>();

            // Comprobamos si el fichero existe
            try
            {
                File.GetAttributes(@"C:\Archivos de programa\Subsdictive\registro.dat");
            }
            catch (System.IO.FileNotFoundException)
            {
                // Lo creamos
                SaveRegistros(new List<Registro>());
            }

            FileStream read = File.OpenRead(@"C:\Archivos de programa\Subsdictive\registro.dat");

            int cantidad = ReadInteger(read);

            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(ReadRegistro(read));
            }

            read.Close();

            return lista;
        }

        public void CodificarJuego(Juego j)
        {
            FileStream read = File.OpenRead(j.Directorio + @"\" + j.FileName);

            byte[] bytes = new byte[read.Length];

            if (read.Length > int.MaxValue)
            {
                throw new Exception("Fichero demasiado largo");
            }

            read.Read(bytes, 0, (int)read.Length);

            read.Close();

            // Ahora lo codificamos
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)((~((int)bytes[i]))&0xFF);
            }

            // Abrimos el fichero para escritura
            FileStream write = File.Create(j.Directorio + @"\" + j.FileName);

            // Ahora lo guardamos con el magic
            WriteInteger(write, 92374076);
            WriteInteger(write, bytes.Length);
            write.Write(bytes, 0, bytes.Length);
        }

        public void DecodificarJuego(Juego j)
        {
            FileStream read = File.OpenRead(j.Directorio + @"\" + j.FileName);

            int magic = ReadInteger(read);
            if (magic != 92374076)
            {
                throw new Exception("El juego no estaba bloqueado");
            }

            int cantidad = ReadInteger(read);
            byte[] bytes = new byte[cantidad];

            read.Read(bytes, 0, cantidad);

            read.Close();

            // Decodificamos el juego
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)((~((int)bytes[i]))&0xFF);
            }


            // Ahora escribimos el juego sin codificar
            FileStream write = File.Create(j.Directorio + @"\" + j.FileName);

            write.Write(bytes, 0, bytes.Length);
            write.Close();
        }

    }
}
