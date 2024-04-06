using FontAwesome.Sharp;
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
    public partial class frmPlanilla : Form
    {
        //Resaltar boton semanas
        private IconButton selectBoton;
        //Borde lateral de boton semanas
        private Panel bordeLateralIzquierdo;
        public frmPlanilla()
        {
            InitializeComponent();
        }

        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            //Paneles no visible al cargar el formulario
            pnlContenedor.Visible = false;

            //Permite al usuario solo seleccionar mes y año del DateTimePicker
            selectMes.ShowUpDown = true;

            //Instancion el bordeLateral al cargar el formulario
            bordeLateralIzquierdo = new Panel()
            {
                Size = new Size(4, 57),
                BackColor = Color.PaleGreen
            };

            pnlSemanas.Controls.Add(bordeLateralIzquierdo);
            bordeLateralIzquierdo.Visible = false;

            pnlPrincipal.Height = 0;
            pnlPrincipal.Visible = false;

        }
        private void ActivarBotonSemana(object boton)
        {
            DesactivarBotonSemana();

            timerPlanillaSemanal.Start();

            pnlContenedor.Visible = true;

            if (boton != null)
            {
                selectBoton = (IconButton)boton;

                //Configuracion de propiedades del boton seleccionado
                selectBoton.BackColor = Color.FromArgb(0, 66, 38);


                //Configuracion del borde lateral
                bordeLateralIzquierdo.Location = new Point(0, selectBoton.Location.Y);
                bordeLateralIzquierdo.Visible = true;
                bordeLateralIzquierdo.BringToFront();

            }
        }
        private void DesactivarBotonSemana()
        {
            if (selectBoton != null)
            {
                selectBoton.BackColor = Color.FromArgb(23, 117, 81);

                bordeLateralIzquierdo.Visible = false;
            }
            pnlContenedor.Visible = false;
        }

        private void btnSemana1_Click(object sender, EventArgs e)
        {
            ActivarBotonSemana(sender);
            pnlContenedor.Height = 0;
        }

        private void btnSemana2_Click(object sender, EventArgs e)
        {
            ActivarBotonSemana(sender);
            pnlContenedor.Height = 0;
        }

        private void btnSemana3_Click(object sender, EventArgs e)
        {
            ActivarBotonSemana(sender);
            pnlContenedor.Height = 0;
        }

        private void btnSemana4_Click(object sender, EventArgs e)
        {
            ActivarBotonSemana(sender);
            pnlContenedor.Height = 0;
        }

        private void btnVerPlanilla_Click(object sender, EventArgs e)
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

        private void timerPlanillaSemanal_Tick(object sender, EventArgs e)
        {
            pnlContenedor.Height += 50;

            if (pnlContenedor.Height >= 500)
            {
                timerPlanillaSemanal.Stop();
            }
        }
    }
}
