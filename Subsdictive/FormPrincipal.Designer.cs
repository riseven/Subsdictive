namespace Subsdictive
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.botonLogin = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.botonAdmJuegos = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.botonAdmSeguimiento = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonAdmUsuarios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAdmJuegos = new System.Windows.Forms.Panel();
            this.btAdmJuegosVolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonAdmJuegosBuscarEjecutable = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAdmJuegosEjecutable = new System.Windows.Forms.TextBox();
            this.botonAdmJuegosCrear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAdmJuegosNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboAdmJuegos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonAdmJuegosQuitar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelElegirJuego = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboElegirJuego = new System.Windows.Forms.ComboBox();
            this.botonElegirJuegoJugar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.botonAdmUsuariosVolver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNuevoUsuarioPass = new System.Windows.Forms.TextBox();
            this.botonUsuariosCrear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNuevoUsuarioNick = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.botonAdmUsuariosQuitar = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelAdmRegistro = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.botonAdmRegistroVolver = new System.Windows.Forms.Button();
            this.dataGridAdmRegistro = new System.Windows.Forms.DataGridView();
            this.panelLogin.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelAdmJuegos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelElegirJuego.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelAdmRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.LightSalmon;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxNick);
            this.panelLogin.Controls.Add(this.botonLogin);
            this.panelLogin.Location = new System.Drawing.Point(23, 23);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(195, 96);
            this.panelLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nick";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(79, 35);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(79, 9);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(100, 20);
            this.textBoxNick.TabIndex = 6;
            // 
            // botonLogin
            // 
            this.botonLogin.Location = new System.Drawing.Point(104, 61);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(75, 23);
            this.botonLogin.TabIndex = 5;
            this.botonLogin.Text = "Login";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.LightSalmon;
            this.panelAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdmin.Controls.Add(this.textBox4);
            this.panelAdmin.Controls.Add(this.botonAdmJuegos);
            this.panelAdmin.Controls.Add(this.textBox3);
            this.panelAdmin.Controls.Add(this.button3);
            this.panelAdmin.Controls.Add(this.textBox2);
            this.panelAdmin.Controls.Add(this.botonAdmSeguimiento);
            this.panelAdmin.Controls.Add(this.textBox1);
            this.panelAdmin.Controls.Add(this.botonAdmUsuarios);
            this.panelAdmin.Controls.Add(this.label3);
            this.panelAdmin.Location = new System.Drawing.Point(23, 115);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(266, 255);
            this.panelAdmin.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 84);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(162, 50);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Añade o elimina juegos.\r\nLos juegos añadidos solo serán juables a traves de Subsd" +
                "ictive.";
            // 
            // botonAdmJuegos
            // 
            this.botonAdmJuegos.Location = new System.Drawing.Point(176, 84);
            this.botonAdmJuegos.Name = "botonAdmJuegos";
            this.botonAdmJuegos.Size = new System.Drawing.Size(85, 50);
            this.botonAdmJuegos.TabIndex = 10;
            this.botonAdmJuegos.Text = "Juegos";
            this.botonAdmJuegos.UseVisualStyleBackColor = true;
            this.botonAdmJuegos.Click += new System.EventHandler(this.botonAdmJuegos_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 196);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(162, 50);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Establece restricciones concretas para cada usuario.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Restricciones";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 140);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 50);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Muestra el registro de juego de los distintos usuarios.";
            // 
            // botonAdmSeguimiento
            // 
            this.botonAdmSeguimiento.Location = new System.Drawing.Point(176, 140);
            this.botonAdmSeguimiento.Name = "botonAdmSeguimiento";
            this.botonAdmSeguimiento.Size = new System.Drawing.Size(85, 50);
            this.botonAdmSeguimiento.TabIndex = 6;
            this.botonAdmSeguimiento.Text = "Seguimiento";
            this.botonAdmSeguimiento.UseVisualStyleBackColor = true;
            this.botonAdmSeguimiento.Click += new System.EventHandler(this.botonAdmSeguimiento_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(162, 50);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Crea y elimina usuarios.\r\nSelecciona que políticas se aplican a cada usuario.";
            // 
            // botonAdmUsuarios
            // 
            this.botonAdmUsuarios.Location = new System.Drawing.Point(176, 28);
            this.botonAdmUsuarios.Name = "botonAdmUsuarios";
            this.botonAdmUsuarios.Size = new System.Drawing.Size(85, 50);
            this.botonAdmUsuarios.TabIndex = 1;
            this.botonAdmUsuarios.Text = "Usuarios";
            this.botonAdmUsuarios.UseVisualStyleBackColor = true;
            this.botonAdmUsuarios.Click += new System.EventHandler(this.botonAdmUsuarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Administración";
            // 
            // panelAdmJuegos
            // 
            this.panelAdmJuegos.BackColor = System.Drawing.Color.LightSalmon;
            this.panelAdmJuegos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelAdmJuegos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdmJuegos.Controls.Add(this.btAdmJuegosVolver);
            this.panelAdmJuegos.Controls.Add(this.groupBox2);
            this.panelAdmJuegos.Controls.Add(this.groupBox1);
            this.panelAdmJuegos.Controls.Add(this.label4);
            this.panelAdmJuegos.Location = new System.Drawing.Point(23, 86);
            this.panelAdmJuegos.Name = "panelAdmJuegos";
            this.panelAdmJuegos.Size = new System.Drawing.Size(266, 244);
            this.panelAdmJuegos.TabIndex = 3;
            // 
            // btAdmJuegosVolver
            // 
            this.btAdmJuegosVolver.Location = new System.Drawing.Point(10, 215);
            this.btAdmJuegosVolver.Name = "btAdmJuegosVolver";
            this.btAdmJuegosVolver.Size = new System.Drawing.Size(75, 23);
            this.btAdmJuegosVolver.TabIndex = 11;
            this.btAdmJuegosVolver.Text = "Volver";
            this.btAdmJuegosVolver.UseVisualStyleBackColor = true;
            this.btAdmJuegosVolver.Click += new System.EventHandler(this.btAdmJuegosVolver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonAdmJuegosBuscarEjecutable);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxAdmJuegosEjecutable);
            this.groupBox2.Controls.Add(this.botonAdmJuegosCrear);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxAdmJuegosNombre);
            this.groupBox2.Location = new System.Drawing.Point(3, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 98);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo juego";
            // 
            // botonAdmJuegosBuscarEjecutable
            // 
            this.botonAdmJuegosBuscarEjecutable.Location = new System.Drawing.Point(227, 39);
            this.botonAdmJuegosBuscarEjecutable.Name = "botonAdmJuegosBuscarEjecutable";
            this.botonAdmJuegosBuscarEjecutable.Size = new System.Drawing.Size(25, 23);
            this.botonAdmJuegosBuscarEjecutable.TabIndex = 12;
            this.botonAdmJuegosBuscarEjecutable.Text = "...";
            this.botonAdmJuegosBuscarEjecutable.UseVisualStyleBackColor = true;
            this.botonAdmJuegosBuscarEjecutable.Click += new System.EventHandler(this.botonAdmJuegosBuscarEjecutable_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ejecutable";
            // 
            // textBoxAdmJuegosEjecutable
            // 
            this.textBoxAdmJuegosEjecutable.Location = new System.Drawing.Point(85, 41);
            this.textBoxAdmJuegosEjecutable.Name = "textBoxAdmJuegosEjecutable";
            this.textBoxAdmJuegosEjecutable.ReadOnly = true;
            this.textBoxAdmJuegosEjecutable.Size = new System.Drawing.Size(139, 20);
            this.textBoxAdmJuegosEjecutable.TabIndex = 10;
            // 
            // botonAdmJuegosCrear
            // 
            this.botonAdmJuegosCrear.Location = new System.Drawing.Point(177, 67);
            this.botonAdmJuegosCrear.Name = "botonAdmJuegosCrear";
            this.botonAdmJuegosCrear.Size = new System.Drawing.Size(75, 23);
            this.botonAdmJuegosCrear.TabIndex = 9;
            this.botonAdmJuegosCrear.Text = "Crear";
            this.botonAdmJuegosCrear.UseVisualStyleBackColor = true;
            this.botonAdmJuegosCrear.Click += new System.EventHandler(this.botonAdmJuegosCrear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre juego";
            // 
            // textBoxAdmJuegosNombre
            // 
            this.textBoxAdmJuegosNombre.Location = new System.Drawing.Point(85, 13);
            this.textBoxAdmJuegosNombre.Name = "textBoxAdmJuegosNombre";
            this.textBoxAdmJuegosNombre.Size = new System.Drawing.Size(167, 20);
            this.textBoxAdmJuegosNombre.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboAdmJuegos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.botonAdmJuegosQuitar);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 77);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Juegos existentes";
            // 
            // comboAdmJuegos
            // 
            this.comboAdmJuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAdmJuegos.FormattingEnabled = true;
            this.comboAdmJuegos.Location = new System.Drawing.Point(104, 19);
            this.comboAdmJuegos.Name = "comboAdmJuegos";
            this.comboAdmJuegos.Size = new System.Drawing.Size(148, 21);
            this.comboAdmJuegos.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccionar juego";
            // 
            // botonAdmJuegosQuitar
            // 
            this.botonAdmJuegosQuitar.Location = new System.Drawing.Point(177, 46);
            this.botonAdmJuegosQuitar.Name = "botonAdmJuegosQuitar";
            this.botonAdmJuegosQuitar.Size = new System.Drawing.Size(75, 23);
            this.botonAdmJuegosQuitar.TabIndex = 8;
            this.botonAdmJuegosQuitar.Text = "Quitar";
            this.botonAdmJuegosQuitar.UseVisualStyleBackColor = true;
            this.botonAdmJuegosQuitar.Click += new System.EventHandler(this.botonAdmJuegosQuitar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Juegos";
            // 
            // panelElegirJuego
            // 
            this.panelElegirJuego.BackColor = System.Drawing.Color.LightSalmon;
            this.panelElegirJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelElegirJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelElegirJuego.Controls.Add(this.button1);
            this.panelElegirJuego.Controls.Add(this.comboElegirJuego);
            this.panelElegirJuego.Controls.Add(this.botonElegirJuegoJugar);
            this.panelElegirJuego.Controls.Add(this.label7);
            this.panelElegirJuego.Location = new System.Drawing.Point(23, 56);
            this.panelElegirJuego.Name = "panelElegirJuego";
            this.panelElegirJuego.Size = new System.Drawing.Size(203, 97);
            this.panelElegirJuego.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboElegirJuego
            // 
            this.comboElegirJuego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboElegirJuego.FormattingEnabled = true;
            this.comboElegirJuego.Location = new System.Drawing.Point(8, 39);
            this.comboElegirJuego.Name = "comboElegirJuego";
            this.comboElegirJuego.Size = new System.Drawing.Size(187, 21);
            this.comboElegirJuego.TabIndex = 3;
            // 
            // botonElegirJuegoJugar
            // 
            this.botonElegirJuegoJugar.Location = new System.Drawing.Point(110, 66);
            this.botonElegirJuegoJugar.Name = "botonElegirJuegoJugar";
            this.botonElegirJuegoJugar.Size = new System.Drawing.Size(85, 23);
            this.botonElegirJuegoJugar.TabIndex = 2;
            this.botonElegirJuegoJugar.Text = "Jugar";
            this.botonElegirJuegoJugar.UseVisualStyleBackColor = true;
            this.botonElegirJuegoJugar.Click += new System.EventHandler(this.botonElegirJuegoJugar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Elegir Juego";
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.LightSalmon;
            this.panelUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuarios.Controls.Add(this.botonAdmUsuariosVolver);
            this.panelUsuarios.Controls.Add(this.groupBox3);
            this.panelUsuarios.Controls.Add(this.groupBox4);
            this.panelUsuarios.Controls.Add(this.label10);
            this.panelUsuarios.Location = new System.Drawing.Point(23, 140);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(266, 238);
            this.panelUsuarios.TabIndex = 5;
            // 
            // botonAdmUsuariosVolver
            // 
            this.botonAdmUsuariosVolver.Location = new System.Drawing.Point(8, 210);
            this.botonAdmUsuariosVolver.Name = "botonAdmUsuariosVolver";
            this.botonAdmUsuariosVolver.Size = new System.Drawing.Size(75, 23);
            this.botonAdmUsuariosVolver.TabIndex = 11;
            this.botonAdmUsuariosVolver.Text = "Volver";
            this.botonAdmUsuariosVolver.UseVisualStyleBackColor = true;
            this.botonAdmUsuariosVolver.Click += new System.EventHandler(this.botonAdmUsuariosVolver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxNuevoUsuarioPass);
            this.groupBox3.Controls.Add(this.botonUsuariosCrear);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxNuevoUsuarioNick);
            this.groupBox3.Location = new System.Drawing.Point(3, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 93);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Password";
            // 
            // textBoxNuevoUsuarioPass
            // 
            this.textBoxNuevoUsuarioPass.Location = new System.Drawing.Point(78, 37);
            this.textBoxNuevoUsuarioPass.Name = "textBoxNuevoUsuarioPass";
            this.textBoxNuevoUsuarioPass.Size = new System.Drawing.Size(174, 20);
            this.textBoxNuevoUsuarioPass.TabIndex = 10;
            // 
            // botonUsuariosCrear
            // 
            this.botonUsuariosCrear.Location = new System.Drawing.Point(177, 63);
            this.botonUsuariosCrear.Name = "botonUsuariosCrear";
            this.botonUsuariosCrear.Size = new System.Drawing.Size(75, 23);
            this.botonUsuariosCrear.TabIndex = 9;
            this.botonUsuariosCrear.Text = "Crear";
            this.botonUsuariosCrear.UseVisualStyleBackColor = true;
            this.botonUsuariosCrear.Click += new System.EventHandler(this.button8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nick";
            // 
            // textBoxNuevoUsuarioNick
            // 
            this.textBoxNuevoUsuarioNick.Location = new System.Drawing.Point(78, 13);
            this.textBoxNuevoUsuarioNick.Name = "textBoxNuevoUsuarioNick";
            this.textBoxNuevoUsuarioNick.Size = new System.Drawing.Size(174, 20);
            this.textBoxNuevoUsuarioNick.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboUsuarios);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.botonAdmUsuariosQuitar);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Location = new System.Drawing.Point(3, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 77);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuarios existentes";
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(112, 19);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(140, 21);
            this.comboUsuarios.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Seleccionar usuario";
            // 
            // botonAdmUsuariosQuitar
            // 
            this.botonAdmUsuariosQuitar.Location = new System.Drawing.Point(177, 46);
            this.botonAdmUsuariosQuitar.Name = "botonAdmUsuariosQuitar";
            this.botonAdmUsuariosQuitar.Size = new System.Drawing.Size(75, 23);
            this.botonAdmUsuariosQuitar.TabIndex = 8;
            this.botonAdmUsuariosQuitar.Text = "Quitar";
            this.botonAdmUsuariosQuitar.UseVisualStyleBackColor = true;
            this.botonAdmUsuariosQuitar.Click += new System.EventHandler(this.botonAdmUsuariosQuitar_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(96, 46);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "Modificar";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Usuarios";
            // 
            // panelAdmRegistro
            // 
            this.panelAdmRegistro.BackColor = System.Drawing.Color.LightSalmon;
            this.panelAdmRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelAdmRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdmRegistro.Controls.Add(this.dataGridAdmRegistro);
            this.panelAdmRegistro.Controls.Add(this.botonAdmRegistroVolver);
            this.panelAdmRegistro.Controls.Add(this.label13);
            this.panelAdmRegistro.Location = new System.Drawing.Point(232, 12);
            this.panelAdmRegistro.Name = "panelAdmRegistro";
            this.panelAdmRegistro.Size = new System.Drawing.Size(339, 372);
            this.panelAdmRegistro.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Registro";
            // 
            // botonAdmRegistroVolver
            // 
            this.botonAdmRegistroVolver.Location = new System.Drawing.Point(3, 344);
            this.botonAdmRegistroVolver.Name = "botonAdmRegistroVolver";
            this.botonAdmRegistroVolver.Size = new System.Drawing.Size(85, 23);
            this.botonAdmRegistroVolver.TabIndex = 5;
            this.botonAdmRegistroVolver.Text = "Volver";
            this.botonAdmRegistroVolver.UseVisualStyleBackColor = true;
            this.botonAdmRegistroVolver.Click += new System.EventHandler(this.botonAdmRegistroVolver_Click);
            // 
            // dataGridAdmRegistro
            // 
            this.dataGridAdmRegistro.AllowUserToAddRows = false;
            this.dataGridAdmRegistro.AllowUserToDeleteRows = false;
            this.dataGridAdmRegistro.AllowUserToResizeColumns = false;
            this.dataGridAdmRegistro.AllowUserToResizeRows = false;
            this.dataGridAdmRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmRegistro.Location = new System.Drawing.Point(3, 28);
            this.dataGridAdmRegistro.Name = "dataGridAdmRegistro";
            this.dataGridAdmRegistro.ReadOnly = true;
            this.dataGridAdmRegistro.Size = new System.Drawing.Size(331, 310);
            this.dataGridAdmRegistro.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Subsdictive.Properties.Resources.last_tree_0640a;
            this.ClientSize = new System.Drawing.Size(613, 409);
            this.Controls.Add(this.panelAdmRegistro);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelAdmJuegos);
            this.Controls.Add(this.panelElegirJuego);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormPrincipal";
            this.Text = "Subsdictive";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelAdmJuegos.ResumeLayout(false);
            this.panelAdmJuegos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelElegirJuego.ResumeLayout(false);
            this.panelElegirJuego.PerformLayout();
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelAdmRegistro.ResumeLayout(false);
            this.panelAdmRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button botonAdmUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button botonAdmSeguimiento;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button botonAdmJuegos;
        private System.Windows.Forms.Panel panelAdmJuegos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonAdmJuegosQuitar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAdmJuegos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonAdmJuegosCrear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAdmJuegosNombre;
        private System.Windows.Forms.Button btAdmJuegosVolver;
        private System.Windows.Forms.Panel panelElegirJuego;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botonElegirJuegoJugar;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Button botonAdmUsuariosVolver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNuevoUsuarioPass;
        private System.Windows.Forms.Button botonUsuariosCrear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNuevoUsuarioNick;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button botonAdmUsuariosQuitar;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonAdmJuegosBuscarEjecutable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAdmJuegosEjecutable;
        private System.Windows.Forms.ComboBox comboElegirJuego;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAdmRegistro;
        private System.Windows.Forms.DataGridView dataGridAdmRegistro;
        private System.Windows.Forms.Button botonAdmRegistroVolver;
        private System.Windows.Forms.Label label13;
    }
}

