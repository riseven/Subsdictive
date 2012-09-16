using System;
using System.Collections.Generic;
using System.Text;

namespace Subsdictive
{
    class Juego
    {
        private string nombre = "";
        private string directorio = "";
        private string filename = "";
        private bool codificado = false;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Directorio
        {
            get
            {
                return directorio;
            }
            set
            {
                directorio = value;
            }
        }

        public string FileName
        {
            get
            {
                return filename;
            }
            set
            {
                filename = value;
            }
        }

        public bool Codificado
        {
            get
            {
                return codificado;
            }
            set
            {
                codificado = value;
            }
        }

        public Juego()
        {
            codificado = false;
        }
    }
}
