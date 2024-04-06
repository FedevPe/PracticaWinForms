using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InterfazProyecto
{
    public partial class ModuloLogin : Form
    {
        //Abrir ModuloPrincipal y cerrar el inicio de sesion
        private Thread th;
        //private Point lastMousePosition;

        //animacion panel logo
        private bool aumentar;

        public ModuloLogin()
        {
            InitializeComponent();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        //{
        //    lastMousePosition = new Point(e.X, e.Y);
        //}

        //private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        int deltaX = e.X - lastMousePosition.X;
        //        int deltaY = e.Y - lastMousePosition.Y;

        //        this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
        //    }
        //}
        private void ModuloLogin_Load(object sender, EventArgs e)
        {
            pnlLogo.BringToFront();
            pnlLogo.Width = 800;
            aumentar = false;
            pnlPrincipal.Visible = false;
            pnlTop.Visible = false;
            timerAnimacionPnlLogo.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Abrir el Modulo Principal cuando presiono el boton uniciar sesion y cuando se cumpla
            //la condicíón y se cierra el ModuloLogin.
            
            aumentar = true;
            timerAnimacionPnlLogo.Start();
            
        }

        private void nuevoFormulario(object obj)
        {
            Application.Run(new ModuloPrincipal());
        }

        private void timerAnimacionPnlLogo_Tick(object sender, EventArgs e)
        {
            if (aumentar)
            {
                pnlLogo.Width += 10;
                if (pnlLogo.Width >= 799)
                {
                   
                    timerAnimacionPnlLogo.Stop();
                    this.Close();
                    th = new Thread(nuevoFormulario);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    
                }
            }
            else
            {
                pnlLogo.Width -= 10;
                

                if (pnlLogo.Width <= 320)
                {
                    pnlPrincipal.Visible = true;
                    pnlTop.Visible = true;
                    timerAnimacionPnlLogo.Stop();
                }
            }
        }

    }
}
