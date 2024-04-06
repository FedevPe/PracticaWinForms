namespace InterfazProyecto
{
    partial class frmProgreso
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSeguimiento = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlImagenEjercicio = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.imgEjercicio = new System.Windows.Forms.PictureBox();
            this.pnlSemanas = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnEjercicio4 = new FontAwesome.Sharp.IconButton();
            this.btnEjercicio3 = new FontAwesome.Sharp.IconButton();
            this.btnEjercicio2 = new FontAwesome.Sharp.IconButton();
            this.btnEjercicio1 = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlGrafico = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAnio = new CustomControls.RJControls.BotonPersonalizado();
            this.btnMeses = new CustomControls.RJControls.BotonPersonalizado();
            this.btnSemanas = new CustomControls.RJControls.BotonPersonalizado();
            this.imgGrafico = new System.Windows.Forms.PictureBox();
            this.timerDesplegar = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlImagenEjercicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEjercicio)).BeginInit();
            this.pnlSemanas.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTop.Controls.Add(this.btnSeguimiento);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1032, 55);
            this.pnlTop.TabIndex = 1;
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeguimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnSeguimiento.FlatAppearance.BorderSize = 0;
            this.btnSeguimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimiento.ForeColor = System.Drawing.Color.White;
            this.btnSeguimiento.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSeguimiento.IconColor = System.Drawing.Color.White;
            this.btnSeguimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeguimiento.IconSize = 25;
            this.btnSeguimiento.Location = new System.Drawing.Point(905, 12);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.Size = new System.Drawing.Size(115, 30);
            this.btnSeguimiento.TabIndex = 2;
            this.btnSeguimiento.Text = "Estadísticas";
            this.btnSeguimiento.UseVisualStyleBackColor = false;
            this.btnSeguimiento.Click += new System.EventHandler(this.btnSeguimiento_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(406, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.CustomizableEdges.TopLeft = false;
            this.txtSearch.CustomizableEdges.TopRight = false;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(6, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Nombre del cliente";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txtSearch.Size = new System.Drawing.Size(393, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(0, 55);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1032, 3);
            this.pnlShadow.TabIndex = 3;
            // 
            // elipse1
            // 
            this.elipse1.TargetControl = this.btnSeguimiento;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnSearch;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.Controls.Add(this.pnlImagenEjercicio);
            this.pnlPrincipal.Controls.Add(this.pnlSemanas);
            this.pnlPrincipal.Controls.Add(this.pnlContenedor);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 58);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1032, 508);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // pnlImagenEjercicio
            // 
            this.pnlImagenEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.pnlImagenEjercicio.Controls.Add(this.imgEjercicio);
            this.pnlImagenEjercicio.FillColor = System.Drawing.Color.White;
            this.pnlImagenEjercicio.Location = new System.Drawing.Point(6, 316);
            this.pnlImagenEjercicio.Name = "pnlImagenEjercicio";
            this.pnlImagenEjercicio.Radius = 6;
            this.pnlImagenEjercicio.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.pnlImagenEjercicio.ShadowDepth = 255;
            this.pnlImagenEjercicio.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlImagenEjercicio.Size = new System.Drawing.Size(284, 189);
            this.pnlImagenEjercicio.TabIndex = 29;
            // 
            // imgEjercicio
            // 
            this.imgEjercicio.InitialImage = null;
            this.imgEjercicio.Location = new System.Drawing.Point(9, 7);
            this.imgEjercicio.Name = "imgEjercicio";
            this.imgEjercicio.Size = new System.Drawing.Size(262, 172);
            this.imgEjercicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEjercicio.TabIndex = 0;
            this.imgEjercicio.TabStop = false;
            // 
            // pnlSemanas
            // 
            this.pnlSemanas.BackColor = System.Drawing.Color.Transparent;
            this.pnlSemanas.Controls.Add(this.btnEjercicio4);
            this.pnlSemanas.Controls.Add(this.btnEjercicio3);
            this.pnlSemanas.Controls.Add(this.btnEjercicio2);
            this.pnlSemanas.Controls.Add(this.btnEjercicio1);
            this.pnlSemanas.Controls.Add(this.label16);
            this.pnlSemanas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(38)))));
            this.pnlSemanas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSemanas.Location = new System.Drawing.Point(6, 5);
            this.pnlSemanas.Name = "pnlSemanas";
            this.pnlSemanas.Radius = 6;
            this.pnlSemanas.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.pnlSemanas.ShadowDepth = 255;
            this.pnlSemanas.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlSemanas.Size = new System.Drawing.Size(284, 299);
            this.pnlSemanas.TabIndex = 28;
            // 
            // btnEjercicio4
            // 
            this.btnEjercicio4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnEjercicio4.FlatAppearance.BorderSize = 0;
            this.btnEjercicio4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicio4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio4.ForeColor = System.Drawing.Color.White;
            this.btnEjercicio4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEjercicio4.IconColor = System.Drawing.Color.Black;
            this.btnEjercicio4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEjercicio4.Location = new System.Drawing.Point(0, 228);
            this.btnEjercicio4.Name = "btnEjercicio4";
            this.btnEjercicio4.Size = new System.Drawing.Size(278, 54);
            this.btnEjercicio4.TabIndex = 9;
            this.btnEjercicio4.Text = "Press Militar";
            this.btnEjercicio4.UseVisualStyleBackColor = false;
            this.btnEjercicio4.Click += new System.EventHandler(this.btnEjercicio4_Click);
            // 
            // btnEjercicio3
            // 
            this.btnEjercicio3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnEjercicio3.FlatAppearance.BorderSize = 0;
            this.btnEjercicio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicio3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio3.ForeColor = System.Drawing.Color.White;
            this.btnEjercicio3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEjercicio3.IconColor = System.Drawing.Color.Black;
            this.btnEjercicio3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEjercicio3.Location = new System.Drawing.Point(0, 171);
            this.btnEjercicio3.Name = "btnEjercicio3";
            this.btnEjercicio3.Size = new System.Drawing.Size(278, 57);
            this.btnEjercicio3.TabIndex = 8;
            this.btnEjercicio3.Text = "Peso Muerto";
            this.btnEjercicio3.UseVisualStyleBackColor = false;
            this.btnEjercicio3.Click += new System.EventHandler(this.btnEjercicio3_Click);
            // 
            // btnEjercicio2
            // 
            this.btnEjercicio2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnEjercicio2.FlatAppearance.BorderSize = 0;
            this.btnEjercicio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicio2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio2.ForeColor = System.Drawing.Color.White;
            this.btnEjercicio2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEjercicio2.IconColor = System.Drawing.Color.Black;
            this.btnEjercicio2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEjercicio2.Location = new System.Drawing.Point(0, 114);
            this.btnEjercicio2.Name = "btnEjercicio2";
            this.btnEjercicio2.Size = new System.Drawing.Size(278, 57);
            this.btnEjercicio2.TabIndex = 7;
            this.btnEjercicio2.Text = "Sentadilla";
            this.btnEjercicio2.UseVisualStyleBackColor = false;
            this.btnEjercicio2.Click += new System.EventHandler(this.btnEjercicio2_Click);
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnEjercicio1.FlatAppearance.BorderSize = 0;
            this.btnEjercicio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicio1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio1.ForeColor = System.Drawing.Color.White;
            this.btnEjercicio1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEjercicio1.IconColor = System.Drawing.Color.Black;
            this.btnEjercicio1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEjercicio1.Location = new System.Drawing.Point(0, 57);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(278, 57);
            this.btnEjercicio1.TabIndex = 6;
            this.btnEjercicio1.Text = "Banco Plano";
            this.btnEjercicio1.UseVisualStyleBackColor = false;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(18, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(247, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Seguimiento de Ejercicios";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.Controls.Add(this.pnlGrafico);
            this.pnlContenedor.Location = new System.Drawing.Point(296, 5);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(730, 499);
            this.pnlContenedor.TabIndex = 27;
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrafico.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrafico.Controls.Add(this.btnAnio);
            this.pnlGrafico.Controls.Add(this.btnMeses);
            this.pnlGrafico.Controls.Add(this.btnSemanas);
            this.pnlGrafico.Controls.Add(this.imgGrafico);
            this.pnlGrafico.FillColor = System.Drawing.Color.White;
            this.pnlGrafico.Location = new System.Drawing.Point(0, 0);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Radius = 6;
            this.pnlGrafico.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.pnlGrafico.ShadowDepth = 255;
            this.pnlGrafico.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlGrafico.Size = new System.Drawing.Size(727, 496);
            this.pnlGrafico.TabIndex = 7;
            // 
            // btnAnio
            // 
            this.btnAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnAnio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnAnio.BorderColor = System.Drawing.Color.Black;
            this.btnAnio.BorderRadius = 6;
            this.btnAnio.BorderSize = 0;
            this.btnAnio.FlatAppearance.BorderSize = 0;
            this.btnAnio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnAnio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnio.ForeColor = System.Drawing.Color.White;
            this.btnAnio.Location = new System.Drawing.Point(537, 428);
            this.btnAnio.Name = "btnAnio";
            this.btnAnio.Size = new System.Drawing.Size(83, 40);
            this.btnAnio.TabIndex = 12;
            this.btnAnio.Text = "Años";
            this.btnAnio.TextColor = System.Drawing.Color.White;
            this.btnAnio.UseVisualStyleBackColor = false;
            // 
            // btnMeses
            // 
            this.btnMeses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMeses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnMeses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnMeses.BorderColor = System.Drawing.Color.Black;
            this.btnMeses.BorderRadius = 6;
            this.btnMeses.BorderSize = 0;
            this.btnMeses.FlatAppearance.BorderSize = 0;
            this.btnMeses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnMeses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeses.ForeColor = System.Drawing.Color.White;
            this.btnMeses.Location = new System.Drawing.Point(313, 428);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(83, 40);
            this.btnMeses.TabIndex = 11;
            this.btnMeses.Text = "Meses";
            this.btnMeses.TextColor = System.Drawing.Color.White;
            this.btnMeses.UseVisualStyleBackColor = false;
            // 
            // btnSemanas
            // 
            this.btnSemanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnSemanas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnSemanas.BorderColor = System.Drawing.Color.Black;
            this.btnSemanas.BorderRadius = 6;
            this.btnSemanas.BorderSize = 0;
            this.btnSemanas.FlatAppearance.BorderSize = 0;
            this.btnSemanas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnSemanas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnSemanas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemanas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemanas.ForeColor = System.Drawing.Color.White;
            this.btnSemanas.Location = new System.Drawing.Point(85, 428);
            this.btnSemanas.Name = "btnSemanas";
            this.btnSemanas.Size = new System.Drawing.Size(95, 40);
            this.btnSemanas.TabIndex = 10;
            this.btnSemanas.Text = "Semanas";
            this.btnSemanas.TextColor = System.Drawing.Color.White;
            this.btnSemanas.UseVisualStyleBackColor = false;
            // 
            // imgGrafico
            // 
            this.imgGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgGrafico.Image = global::InterfazProyecto.Properties.Resources.graficoProgreso;
            this.imgGrafico.InitialImage = null;
            this.imgGrafico.Location = new System.Drawing.Point(17, 6);
            this.imgGrafico.Name = "imgGrafico";
            this.imgGrafico.Size = new System.Drawing.Size(695, 392);
            this.imgGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGrafico.TabIndex = 1;
            this.imgGrafico.TabStop = false;
            // 
            // timerDesplegar
            // 
            this.timerDesplegar.Interval = 1;
            this.timerDesplegar.Tick += new System.EventHandler(this.timerDesplegar_Tick);
            // 
            // frmProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 566);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgreso";
            this.Text = "frmProgreso";
            this.Load += new System.EventHandler(this.frmProgreso_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlImagenEjercicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEjercicio)).EndInit();
            this.pnlSemanas.ResumeLayout(false);
            this.pnlSemanas.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlShadow;
        private Guna.UI2.WinForms.Guna2Elipse elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FontAwesome.Sharp.IconButton btnSeguimiento;
        private System.Windows.Forms.Panel pnlPrincipal;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlSemanas;
        private FontAwesome.Sharp.IconButton btnEjercicio4;
        private FontAwesome.Sharp.IconButton btnEjercicio3;
        private FontAwesome.Sharp.IconButton btnEjercicio2;
        private FontAwesome.Sharp.IconButton btnEjercicio1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlContenedor;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlGrafico;
        private CustomControls.RJControls.BotonPersonalizado btnAnio;
        private CustomControls.RJControls.BotonPersonalizado btnMeses;
        private CustomControls.RJControls.BotonPersonalizado btnSemanas;
        private System.Windows.Forms.PictureBox imgGrafico;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlImagenEjercicio;
        private System.Windows.Forms.PictureBox imgEjercicio;
        private System.Windows.Forms.Timer timerDesplegar;
    }
}