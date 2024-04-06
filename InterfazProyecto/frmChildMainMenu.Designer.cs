namespace InterfazProyecto
{
    partial class frmChildMainMenu
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
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.bntProgreso = new FontAwesome.Sharp.IconButton();
            this.btnEjercicios = new FontAwesome.Sharp.IconButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.bntRutinas = new FontAwesome.Sharp.IconButton();
            this.bntPlanillas = new FontAwesome.Sharp.IconButton();
            this.TimerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.pnlShadow = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.pnlMainMenu.Controls.Add(this.btnClientes);
            this.pnlMainMenu.Controls.Add(this.bntProgreso);
            this.pnlMainMenu.Controls.Add(this.btnEjercicios);
            this.pnlMainMenu.Controls.Add(this.lblFecha);
            this.pnlMainMenu.Controls.Add(this.lblHora);
            this.pnlMainMenu.Controls.Add(this.bntRutinas);
            this.pnlMainMenu.Controls.Add(this.bntPlanillas);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(998, 118);
            this.pnlMainMenu.TabIndex = 4;
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 70;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(352, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnClientes.Size = new System.Drawing.Size(88, 118);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // bntProgreso
            // 
            this.bntProgreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.bntProgreso.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.bntProgreso.FlatAppearance.BorderSize = 0;
            this.bntProgreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.bntProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntProgreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntProgreso.ForeColor = System.Drawing.Color.White;
            this.bntProgreso.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.bntProgreso.IconColor = System.Drawing.Color.White;
            this.bntProgreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntProgreso.IconSize = 70;
            this.bntProgreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntProgreso.Location = new System.Drawing.Point(176, 0);
            this.bntProgreso.Name = "bntProgreso";
            this.bntProgreso.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bntProgreso.Size = new System.Drawing.Size(88, 118);
            this.bntProgreso.TabIndex = 5;
            this.bntProgreso.Text = "Progreso";
            this.bntProgreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntProgreso.UseVisualStyleBackColor = false;
            this.bntProgreso.Click += new System.EventHandler(this.bntProgreso_Click);
            // 
            // btnEjercicios
            // 
            this.btnEjercicios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEjercicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.btnEjercicios.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnEjercicios.FlatAppearance.BorderSize = 0;
            this.btnEjercicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnEjercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicios.ForeColor = System.Drawing.Color.White;
            this.btnEjercicios.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
            this.btnEjercicios.IconColor = System.Drawing.Color.White;
            this.btnEjercicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEjercicios.IconSize = 70;
            this.btnEjercicios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEjercicios.Location = new System.Drawing.Point(264, 0);
            this.btnEjercicios.Name = "btnEjercicios";
            this.btnEjercicios.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnEjercicios.Size = new System.Drawing.Size(88, 118);
            this.btnEjercicios.TabIndex = 4;
            this.btnEjercicios.Text = "Ejercicios";
            this.btnEjercicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEjercicios.UseVisualStyleBackColor = false;
            this.btnEjercicios.Click += new System.EventHandler(this.btnEjercicios_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblFecha.Location = new System.Drawing.Point(720, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(266, 25);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "lun. 3 de febrero de 2024";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(725, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(285, 77);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "10:30:20";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bntRutinas
            // 
            this.bntRutinas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntRutinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.bntRutinas.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.bntRutinas.FlatAppearance.BorderSize = 0;
            this.bntRutinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.bntRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRutinas.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.bntRutinas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRutinas.ForeColor = System.Drawing.Color.White;
            this.bntRutinas.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.bntRutinas.IconColor = System.Drawing.Color.White;
            this.bntRutinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntRutinas.IconSize = 70;
            this.bntRutinas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntRutinas.Location = new System.Drawing.Point(0, 0);
            this.bntRutinas.Name = "bntRutinas";
            this.bntRutinas.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bntRutinas.Size = new System.Drawing.Size(88, 118);
            this.bntRutinas.TabIndex = 1;
            this.bntRutinas.Text = "Rutinas";
            this.bntRutinas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntRutinas.UseVisualStyleBackColor = false;
            this.bntRutinas.Click += new System.EventHandler(this.bntRutinas_Click);
            // 
            // bntPlanillas
            // 
            this.bntPlanillas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntPlanillas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(81)))));
            this.bntPlanillas.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.bntPlanillas.FlatAppearance.BorderSize = 0;
            this.bntPlanillas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.bntPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPlanillas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPlanillas.ForeColor = System.Drawing.Color.White;
            this.bntPlanillas.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.bntPlanillas.IconColor = System.Drawing.Color.White;
            this.bntPlanillas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntPlanillas.IconSize = 70;
            this.bntPlanillas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntPlanillas.Location = new System.Drawing.Point(88, 0);
            this.bntPlanillas.Name = "bntPlanillas";
            this.bntPlanillas.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.bntPlanillas.Size = new System.Drawing.Size(88, 118);
            this.bntPlanillas.TabIndex = 0;
            this.bntPlanillas.Text = "Planillas";
            this.bntPlanillas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntPlanillas.UseVisualStyleBackColor = false;
            this.bntPlanillas.Click += new System.EventHandler(this.bntPlanillas_Click);
            // 
            // TimerFechaHora
            // 
            this.TimerFechaHora.Tick += new System.EventHandler(this.TimerFechaHora_Tick);
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(0, 118);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(998, 5);
            this.pnlShadow.TabIndex = 5;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 123);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(998, 431);
            this.pnlContenedor.TabIndex = 6;
            // 
            // frmChildMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 554);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChildMainMenu";
            this.Text = "frmChildMainMenu";
            this.Load += new System.EventHandler(this.frmChildMainMenu_Load);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton bntRutinas;
        private FontAwesome.Sharp.IconButton bntPlanillas;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer TimerFechaHora;
        private Guna.UI2.WinForms.Guna2Panel pnlShadow;
        private FontAwesome.Sharp.IconButton btnEjercicios;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedor;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton bntProgreso;
        private System.Windows.Forms.Label lblHora;
    }
}