using FontAwesome.Sharp;
using InterfazProyecto.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazProyecto
{
    public partial class frmProgreso : Form
    {
        private IconButton selectBoton;
        private Panel bordeLateralDerecho;

        public frmProgreso()
        {
            InitializeComponent();

            pnlPrincipal.Visible = false;

            bordeLateralDerecho = new Panel()
            {
                BackColor = Color.PaleGreen,
                Size = new Size(4, 57)
            };

            pnlSemanas.Controls.Add(bordeLateralDerecho);
            bordeLateralDerecho.Visible = false;

            pnlContenedor.Visible = false;
            imgEjercicio.Visible = false;
        }
        private void frmProgreso_Load(object sender, EventArgs e)
        {
            pnlPrincipal.Height = 0;
        }

        private void ActivarBotonEjercicio(object boton)
        {
            DesactivarBotonEjercicio();
            pnlContenedor.Visible = true;
            imgEjercicio.Visible = true;

            if (boton != null)
            {
                selectBoton = (IconButton)boton;

                //Configuracion de propiedades del boton seleccionado
                selectBoton.BackColor = Color.FromArgb(0, 66, 38);


                //Configuracion del borde lateral
                bordeLateralDerecho.Location = new Point(275, selectBoton.Location.Y);
                bordeLateralDerecho.Visible = true;
                bordeLateralDerecho.BringToFront();

            }
        }
        private void DesactivarBotonEjercicio()
        {
            if (selectBoton != null)
            {
                selectBoton.BackColor = Color.FromArgb(23, 117, 81);

                bordeLateralDerecho.Visible = false;
                pnlContenedor.Visible = false;
                imgEjercicio.Visible = false;
            }
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            ActivarBotonEjercicio(sender);
            imgEjercicio.Image =Properties.Resources.image;
            imgEjercicio.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            ActivarBotonEjercicio(sender);
            imgEjercicio.Image = Properties.Resources.sentadilla;
            imgEjercicio.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            ActivarBotonEjercicio(sender);
            imgEjercicio.Image = Properties.Resources.deadLift;
            imgEjercicio.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            ActivarBotonEjercicio(sender);
            imgEjercicio.Image = Properties.Resources.pressMilitar;
            imgEjercicio.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = true;
            timerDesplegar.Start();
        }
        private void timerDesplegar_Tick(object sender, EventArgs e)
        {
            pnlPrincipal.Height += 20;

            if (pnlPrincipal.Height >= 508)
            {
                timerDesplegar.Stop();
            }
        }

        
    }
}
