namespace InterfazProyecto
{
    partial class ModuloLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloLogin));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTop2 = new Guna.UI2.WinForms.Guna2Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerAnimacionPnlLogo = new System.Windows.Forms.Timer(this.components);
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.imgMinimize = new System.Windows.Forms.PictureBox();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ElipseModulo = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse_btnLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxSesion = new System.Windows.Forms.CheckBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.LinkLabel();
            this.lblNewUser = new System.Windows.Forms.LinkLabel();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimize)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.pnlLogo.Controls.Add(this.pnlTop2);
            this.pnlLogo.Controls.Add(this.imgLogo);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Location = new System.Drawing.Point(-2, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(319, 410);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlTop2
            // 
            this.pnlTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop2.Location = new System.Drawing.Point(0, 0);
            this.pnlTop2.MaximumSize = new System.Drawing.Size(320, 29);
            this.pnlTop2.MinimumSize = new System.Drawing.Size(320, 29);
            this.pnlTop2.Name = "pnlTop2";
            this.pnlTop2.Size = new System.Drawing.Size(320, 29);
            this.pnlTop2.TabIndex = 3;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.ErrorImage = null;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(30, 94);
            this.imgLogo.MaximumSize = new System.Drawing.Size(240, 240);
            this.imgLogo.MinimumSize = new System.Drawing.Size(240, 240);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(240, 240);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            // 
            // timerAnimacionPnlLogo
            // 
            this.timerAnimacionPnlLogo.Enabled = true;
            this.timerAnimacionPnlLogo.Interval = 1;
            this.timerAnimacionPnlLogo.Tick += new System.EventHandler(this.timerAnimacionPnlLogo_Tick);
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.BackColor = System.Drawing.Color.Transparent;
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(773, 7);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(19, 17);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 0;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // imgMinimize
            // 
            this.imgMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimize.BackColor = System.Drawing.Color.Transparent;
            this.imgMinimize.Image = ((System.Drawing.Image)(resources.GetObject("imgMinimize.Image")));
            this.imgMinimize.Location = new System.Drawing.Point(751, 7);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.Size = new System.Drawing.Size(18, 17);
            this.imgMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMinimize.TabIndex = 1;
            this.imgMinimize.TabStop = false;
            this.imgMinimize.Click += new System.EventHandler(this.imgMinimize_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.imgClose);
            this.pnlTop.Controls.Add(this.imgMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(799, 29);
            this.pnlTop.TabIndex = 8;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlTop;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // ElipseModulo
            // 
            this.ElipseModulo.TargetControl = this;
            // 
            // Elipse_btnLogin
            // 
            this.Elipse_btnLogin.TargetControl = this.btnLogin;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(187, 311);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 27);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.pnlTop2;
            this.guna2DragControl2.TransparentWhileDrag = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlPassword);
            this.pnlPrincipal.Controls.Add(this.pnlUser);
            this.pnlPrincipal.Controls.Add(this.cbxSesion);
            this.pnlPrincipal.Controls.Add(this.lblText);
            this.pnlPrincipal.Controls.Add(this.lblNewPassword);
            this.pnlPrincipal.Controls.Add(this.lblNewUser);
            this.pnlPrincipal.Controls.Add(this.btnLogin);
            this.pnlPrincipal.Location = new System.Drawing.Point(317, 29);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(482, 381);
            this.pnlPrincipal.TabIndex = 9;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(-2, 150);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(486, 40);
            this.pnlPassword.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderRadius = 6;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.PaleGreen;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(4, 4);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceholderText = "Contraseña";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(479, 33);
            this.txtPassword.TabIndex = 1;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlUser.Controls.Add(this.txtUser);
            this.pnlUser.Location = new System.Drawing.Point(-2, 75);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(486, 40);
            this.pnlUser.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderRadius = 6;
            this.txtUser.BorderThickness = 0;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.Color.PaleGreen;
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Location = new System.Drawing.Point(4, 4);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUser.PlaceholderText = "Nombre de usuario o correo electrónico";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(479, 33);
            this.txtUser.TabIndex = 0;
            // 
            // cbxSesion
            // 
            this.cbxSesion.AutoSize = true;
            this.cbxSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSesion.Location = new System.Drawing.Point(16, 203);
            this.cbxSesion.Name = "cbxSesion";
            this.cbxSesion.Size = new System.Drawing.Size(187, 20);
            this.cbxSesion.TabIndex = 14;
            this.cbxSesion.Text = "Mantener sesión iniciada";
            this.cbxSesion.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Honeydew;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Teal;
            this.lblText.Location = new System.Drawing.Point(4, 43);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(219, 19);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "Inicia sesión con tu cuenta";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.ActiveLinkColor = System.Drawing.Color.Teal;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.lblNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.lblNewPassword.Location = new System.Drawing.Point(154, 277);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(202, 16);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.TabStop = true;
            this.lblNewPassword.Text = "¿Has olvidado tu contraseña?";
            // 
            // lblNewUser
            // 
            this.lblNewUser.ActiveLinkColor = System.Drawing.Color.Teal;
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.lblNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.lblNewUser.Location = new System.Drawing.Point(171, 252);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(157, 16);
            this.lblNewUser.TabIndex = 12;
            this.lblNewUser.TabStop = true;
            this.lblNewUser.Text = "Crear un nuevo usuario";
            // 
            // ModuloLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(799, 409);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModuloLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModuloLogin_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimize)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Timer timerAnimacionPnlLogo;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.PictureBox imgMinimize;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseModulo;
        private Guna.UI2.WinForms.Guna2Elipse Elipse_btnLogin;
        private Guna.UI2.WinForms.Guna2Panel pnlTop2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Panel pnlUser;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private System.Windows.Forms.CheckBox cbxSesion;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.LinkLabel lblNewPassword;
        private System.Windows.Forms.LinkLabel lblNewUser;
        private System.Windows.Forms.Button btnLogin;
    }
}

