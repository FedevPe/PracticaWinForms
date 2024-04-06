using FontAwesome.Sharp;
using Guna.UI2.WinForms;
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
    public partial class frmRutinas : Form
    {
        //animacion resaltar panel
        private int contadorDias;
        //Resaltar boton
        private IconButton selectBoton;
        private Panel bordeLateralDerecho;
        public frmRutinas()
        {
            InitializeComponent();

            bordeLateralDerecho = new Panel()
            {
                BackColor = Color.PaleGreen,
                Size = new Size(4 ,57)
            };

            pnlSemanas.Controls.Add(bordeLateralDerecho);
            bordeLateralDerecho.Visible = false;
        
        }
        private void frmPlanillas_Load(object sender, EventArgs e)
        {
            timerMes.Start();

            lblDias.Text = "0";

            contadorDias = int.Parse(lblDias.Text);
            MostarPanelDias();

            pnlPrincipal.Height = 0;
            timerDesplegar.Start();

        }
        private void btnSemana1_Click(object sender, EventArgs e)
        {
            ActivarBotonSemana(sender);
            contadorDias = 0;
            lblDias.Text = contadorDias.ToString();
            MostarPanelDias();
        }
        private void btnSemana2_Click(object sender, EventArgs e)
        {
            ActivarBotonSemana(sender);
            contadorDias = 0;
            lblDias.Text = contadorDias.ToString();
            MostarPanelDias();
        }
        private void btnSemana3_Click(object sender, EventArgs e)
        {
            ActivarBotonSemana(sender);
            contadorDias = 0;
            lblDias.Text = contadorDias.ToString();
            MostarPanelDias();
        }
        private void btnSemana4_Click(object sender, EventArgs e)
        {
            ActivarBotonSemana(sender);
            contadorDias = 0;
            lblDias.Text = contadorDias.ToString();
            MostarPanelDias();
        }
        private void ActivarBotonSemana(object boton) 
        {
            DesactivarBotonSemana();

            if (boton != null)
            {
                selectBoton = (IconButton)boton;

                //Configuracion de propiedades del boton seleccionado
                selectBoton.BackColor = Color.FromArgb(0, 66, 38);
                

                //Configuracion del borde lateral
                bordeLateralDerecho.Location = new Point(191 , selectBoton.Location.Y);
                bordeLateralDerecho.Visible = true;
                bordeLateralDerecho.BringToFront();
                
            }
        }
        private void DesactivarBotonSemana()
        {
            if(selectBoton != null)
            {
                selectBoton.BackColor = Color.FromArgb(23, 117, 81);

                bordeLateralDerecho.Visible = false;
            }
        }
        private void MostarPanelDias()
        {
            if (contadorDias == 0)
            {
                pnlDia1.Visible = false;
                pnlDia2.Visible = false;
                pnlDia3.Visible = false;
                pnlDia4.Visible = false;
                pnlDia5.Visible = false;
            }
            else if (contadorDias == 1)
            {
                pnlDia1.Visible = true;
                pnlDia2.Visible = false;
                pnlDia3.Visible = false;
                pnlDia4.Visible = false;
                pnlDia5.Visible = false;
            }
            else if (contadorDias == 2)
            {
                pnlDia1.Visible = true;
                pnlDia2.Visible = true;
                pnlDia3.Visible = false;
                pnlDia4.Visible = false;
                pnlDia5.Visible = false;
            }
            else if (contadorDias == 3)
            {
                pnlDia1.Visible = true;
                pnlDia2.Visible = true;
                pnlDia3.Visible = true;
                pnlDia4.Visible = false;
                pnlDia5.Visible = false;
            }
            else if (contadorDias == 4)
            {
                pnlDia1.Visible = true;
                pnlDia2.Visible = true;
                pnlDia3.Visible = true;
                pnlDia4.Visible = true;
                pnlDia5.Visible = false;
            }
            else
            {
                pnlDia1.Visible = true;
                pnlDia2.Visible = true;
                pnlDia3.Visible = true;
                pnlDia4.Visible = true;
                pnlDia5.Visible = true;
            }
        
        }
        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            contadorDias--;

            if (contadorDias < 0)
            {
                contadorDias = 0;
            }

            lblDias.Text = contadorDias.ToString();

            MostarPanelDias();
        }
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            contadorDias++;

            if (contadorDias > 5)
            {
                contadorDias = 5;
            }

            lblDias.Text = contadorDias.ToString();

            MostarPanelDias();
        }

        private void timerMes_Tick(object sender, EventArgs e)
        {
            btnMes.Text = DateTime.Now.ToString("MMMM yyyy");
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
