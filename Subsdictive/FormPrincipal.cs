using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Subsdictive
{
    public partial class FormPrincipal : Form
    {
        private System.Diagnostics.Process proceso = null ;
        private User usuarioActual = null;


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ShowOnly(Control c)
        {
            // Actualizamos los datos
            if (c == panelUsuarios)
            {
                // Leemos los usuarios
                comboUsuarios.Items.Clear();
                List<User> usuarios = DBI.GetDBI().GetUsers();
                foreach (User u in usuarios)
                {
                    if (!u.Admin)
                    {
                        comboUsuarios.Items.Add(u.Nick);
                    }
                }
            }
            else if (c == panelAdmJuegos)
            {
                comboAdmJuegos.Items.Clear();
                List<Juego> juegos = DBI.GetDBI().GetJuegos();
                foreach (Juego j in juegos)
                {
                    comboAdmJuegos.Items.Add(j.Nombre);
                }
            }
            else if (c == panelElegirJuego)
            {
                comboElegirJuego.Items.Clear();
                List<Juego> juegos = DBI.GetDBI().GetJuegos();
                foreach (Juego j in juegos)
                {
                    comboElegirJuego.Items.Add(j.Nombre);
                }
            }
            else if (c == panelAdmRegistro)
            {
                dataGridAdmRegistro.Rows.Clear();
                dataGridAdmRegistro.Columns.Clear();

                dataGridAdmRegistro.Columns.Add("nick", "Nick");
                dataGridAdmRegistro.Columns.Add("inicio", "Fecha");
                dataGridAdmRegistro.Columns.Add("minutos", "Minutos");
                dataGridAdmRegistro.Columns["inicio"].Width += 20;
                dataGridAdmRegistro.Columns["minutos"].Width -= 40;

                // Ahora metemos los rows
                List<Registro> registros = DBI.GetDBI().GetRegistros();
                foreach (Registro r in registros)
                {
                    dataGridAdmRegistro.Rows.Add(r.Nick, r.Inicio, r.Minutos);
                }
            }


            foreach (Control i in Controls)
            {
                if (i == c)
                {
                    i.Left = this.ClientSize.Width / 2 - i.Width / 2;
                    i.Top = this.ClientSize.Height / 2 - i.Height / 2;
                    i.Visible = true;
                }
                else
                {
                    i.Visible = false;
                }
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ShowOnly(panelLogin);
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            List<User> listaUsers = DBI.GetDBI().GetUsers();

            foreach (User u in listaUsers)
            {
                if (u.Nick == textBoxNick.Text)
                {
                    if (u.Password == textBoxPassword.Text)
                    {
                        usuarioActual = u;
                        // Login OK
                        if (u.Admin)
                        {
                            ShowOnly(panelAdmin);
                        }
                        else
                        {
                            ShowOnly(panelElegirJuego);
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("Login incorrecto");
                    }
                    return;
                }
            }

            if (listaUsers.Count == 0)
            {
                // Creamos el super user

                // Lo creamos
                User u = new User();
                u.Nick = textBoxNick.Text;
                u.Password = textBoxPassword.Text;
                u.Admin = true;

                if (u.Password.Length < 6)
                {
                    MessageBox.Show("El password debe tener al menos 6 caracteres");
                    return;
                }

                listaUsers.Add(u);
                DBI.GetDBI().SaveUsers(listaUsers);

                MessageBox.Show("Se ha creado la cuenta de super usuario, \nSi olvida su password será necesario reinstalar Subsdictive");
                usuarioActual = u;

                ShowOnly(panelAdmin);
            }
            else
            {
                // Login incorrecto
                MessageBox.Show("Login incorrecto");
            }
        }

        private void botonAdmJuegos_Click(object sender, EventArgs e)
        {
            ShowOnly(panelAdmJuegos);
        }

        private void btAdmJuegosVolver_Click(object sender, EventArgs e)
        {
            ShowOnly(panelAdmin);
        }

        private void botonElegirJuegoJugar_Click(object sender, EventArgs e)
        {
            List<Juego> juegos = DBI.GetDBI().GetJuegos();

            foreach (Juego j in juegos)
            {
                if (j.Nombre == comboElegirJuego.Text)
                {
                    // Desbloqueamos el juego
                    if (j.Codificado)
                    {
                        DBI.GetDBI().DecodificarJuego(j);
                    }
                    j.Codificado = false;
                    DBI.GetDBI().SaveJuegos(juegos);

                    // Ejecutamos el juego
                    proceso = new System.Diagnostics.Process();
                    proceso.StartInfo.UseShellExecute = true;
                    proceso.StartInfo.CreateNoWindow = false;
                    proceso.EnableRaisingEvents = true;
                    proceso.StartInfo.WorkingDirectory = j.Directorio;
                    proceso.StartInfo.FileName = j.FileName;
                    proceso.Start();

                    // Guardamos la hora de inicio
                    DateTime inicio = DateTime.Now;

                    ShowOnly(null);

                    proceso.WaitForExit();

                    // Ahora esperamos a que se cierre futexe
                    bool activo;
                    do
                    {
                        // Esperamos
                        System.Threading.Thread.Sleep(10000);

                        activo = false;
                        System.Diagnostics.Process[] procesos = System.Diagnostics.Process.GetProcesses();
                        foreach (System.Diagnostics.Process p in procesos)
                        {
                            if (p.ProcessName == "Futexe")
                            {
                                activo = true;
                                break;
                            }
                        }
                    } while (activo);

                    // Calculamos los minutos que se ha jugado
                    DateTime final = DateTime.Now;
                    long ticks = final.Ticks - inicio.Ticks;
                    long segs = ticks / 10000000;
                    int min = (int)(segs / 60);

                    Registro r = new Registro();
                    r.Nick = usuarioActual.Nick;
                    r.Inicio = inicio;
                    r.Minutos = min;
                    List<Registro> registros = DBI.GetDBI().GetRegistros();
                    registros.Add(r);
                    DBI.GetDBI().SaveRegistros(registros);

                    // Codificamos el juego
                    DBI.GetDBI().CodificarJuego(j);
                    j.Codificado = true;
                    DBI.GetDBI().SaveJuegos(juegos);

                    ShowOnly(panelElegirJuego);
                    return;
                }
            }
        }

        private void botonAdmUsuarios_Click(object sender, EventArgs e)
        {
            ShowOnly(panelUsuarios);
        }

        private void botonAdmUsuariosVolver_Click(object sender, EventArgs e)
        {
            ShowOnly(panelAdmin);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxNuevoUsuarioNick.Text.Length < 1)
            {
                MessageBox.Show("Nick no valido");
            }
            
            if (textBoxNuevoUsuarioPass.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres");
                return;
            }

            List<User> usuarios = DBI.GetDBI().GetUsers();

            foreach (User u in usuarios)
            {
                if (u.Nick == textBoxNuevoUsuarioNick.Text)
                {
                    MessageBox.Show("Ya existe un usuario con ese nick");
                    return;
                }
            }

            User nuevo = new User();
            nuevo.Nick = textBoxNuevoUsuarioNick.Text;
            nuevo.Password = textBoxNuevoUsuarioPass.Text;
            nuevo.Admin = false;

            usuarios.Add(nuevo);

            DBI.GetDBI().SaveUsers(usuarios);

            ShowOnly(panelUsuarios);
        }

        private void botonAdmUsuariosQuitar_Click(object sender, EventArgs e)
        {
            List<User> usuarios = DBI.GetDBI().GetUsers();

            foreach (User u in usuarios)
            {
                if (u.Nick == comboUsuarios.Text)
                {
                    usuarios.Remove(u);
                    break;
                }
            }

            DBI.GetDBI().SaveUsers(usuarios);

            ShowOnly(panelUsuarios);
        }

        private void botonAdmJuegosBuscarEjecutable_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxAdmJuegosEjecutable.Text = ofd.FileName;
            }
        }

        private void botonAdmJuegosCrear_Click(object sender, EventArgs e)
        {


            if (textBoxAdmJuegosNombre.Text == "")
            {
                MessageBox.Show("El nombre no es valido");
                return;
            }

            List<Juego> juegos = DBI.GetDBI().GetJuegos();

            MessageBox.Show(juegos.Count.ToString());

            foreach (Juego j in juegos)
            {
                if (j.Nombre == textBoxAdmJuegosNombre.Text)
                {
                    MessageBox.Show("Ya existe un juego con ese nombre");
                    return;
                }
            }

            Juego nuevo = new Juego();
            System.IO.FileInfo fi = new System.IO.FileInfo(textBoxAdmJuegosEjecutable.Text);
            nuevo.Nombre = textBoxAdmJuegosNombre.Text;
            nuevo.Directorio = fi.DirectoryName;
            nuevo.FileName = fi.Name ;
            nuevo.Codificado = true ;

            // Codificamos el juego
            DBI.GetDBI().CodificarJuego(nuevo);

            juegos.Add(nuevo);

            DBI.GetDBI().SaveJuegos(juegos);

            ShowOnly(panelAdmJuegos);
        }

        private void botonAdmJuegosQuitar_Click(object sender, EventArgs e)
        {
            List<Juego> juegos = DBI.GetDBI().GetJuegos();

            foreach (Juego j in juegos)
            {
                if (j.Nombre == comboAdmJuegos.Text)
                {
                    if (j.Codificado)
                    {
                        DBI.GetDBI().DecodificarJuego(j);
                    }
                    juegos.Remove(j);
                    break;
                }
            }

            DBI.GetDBI().SaveJuegos(juegos);

            ShowOnly(panelAdmJuegos);
        }

        private void botonAdmSeguimiento_Click(object sender, EventArgs e)
        {
            ShowOnly(panelAdmRegistro);
        }

        private void botonAdmRegistroVolver_Click(object sender, EventArgs e)
        {
            ShowOnly(panelAdmin);
        }


    }
}