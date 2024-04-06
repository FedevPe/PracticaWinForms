using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace InterfazProyecto
{
    public partial class frmChildMainMenu : Form
    {
        //Borde inferior de botones
        private Panel bordeInferior;
        //Resaltar boton
        private IconButton botonSeleccionado;
        //OpenChildForms
        private Form currentChildForm;
        
        public frmChildMainMenu()
        {
            InitializeComponent();
            //Instanciar panel y configuracion de propiedades para crear borde inferior
            bordeInferior = new Panel()
            {
                BackColor = Color.PaleGreen,
                Size = new Size(88, 5)
            };
            //Agrego el bordeInferior a los controles del panel que lo contiene
            pnlMainMenu.Controls.Add(bordeInferior);
            
        }
        private void frmChildMainMenu_Load(object sender, EventArgs e)
        {
            TimerFechaHora.Start();
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //Cerrar formulario
                currentChildForm.Close();
            }

            //Configuración de formulario hijo
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //Asigno valores del formulario hijo al panel que lo contiene
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;

            //Muestro el formulario hijo
            childForm.BringToFront();
            childForm.Show();

        }

        private void ActivarBoton(object boton)
        {
            
            DesactivarBoton();
            if (boton != null)
            {
                //Asigno el parametro recibido en una variable
                botonSeleccionado = (IconButton)boton;
                
                //Configuracion de propiedades para resaltar el boton al ahcer click
                botonSeleccionado.BackColor = Color.FromArgb(29, 66, 51);
                botonSeleccionado.IconColor = Color.PaleGreen;
                botonSeleccionado.ForeColor = Color.PaleGreen;

                //Hacer visible el borde inferior y configuracion de Location
                bordeInferior.Location = new Point(botonSeleccionado.Location.X, 113);
                bordeInferior.Visible = true;
                bordeInferior.BringToFront();
            }
            
        }

        private void DesactivarBoton()
        {
            if(botonSeleccionado != null)
            {
                //Configuración por defecto del boton, al hacer click en otro boton se ejecutan estas instrucciones
                botonSeleccionado.BackColor = Color.FromArgb(23, 117, 81);
                botonSeleccionado.IconColor = Color.White;
                botonSeleccionado.ForeColor = Color.White;

                //Ocultar bordeInferior
                bordeInferior.Visible = false;

            }
        }
        private void bntPlanillas_Click(object sender, EventArgs e)
        {
            //Llamo a la función ActivarBoton para poder resaltar al hacer click, como parámetro sender
            //para hacer referencia al boton que tiene configurado este evento.
            ActivarBoton(sender);

            //Llamo la funcion para abrir el formulario al hacer click en el boton
            OpenChildForm(new frmPlanilla());

        }
        private void bntRutinas_Click(object sender, EventArgs e)
        {
            //Llamo a la función ActivarBoton para poder resaltar al hacer click, como parámetro sender
            //para hacer referencia al boton que tiene configurado este evento.
            ActivarBoton(sender);

            //Llamo la funcion para abrir el formulario al hacer click en el boton
            OpenChildForm(new frmRutinas());
        }

        private void bntProgreso_Click(object sender, EventArgs e)
        {
            //Llamo a la función ActivarBoton para poder resaltar al hacer click, como parámetro sender
            //para hacer referencia al boton que tiene configurado este evento.
            ActivarBoton(sender);

            //Llamo la funcion para abrir el formulario al hacer click en el boton
            OpenChildForm(new frmProgreso());
        }
        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            //Llamo a la función ActivarBoton para poder resaltar al hacer click, como parámetro sender
            //para hacer referencia al boton que tiene configurado este evento.
            ActivarBoton(sender);

            //Llamo la funcion para abrir el formulario al hacer click en el boton
            OpenChildForm(new frmEjercicios());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Llamo a la función ActivarBoton para poder resaltar al hacer click, como parámetro sender
            //para hacer referencia al boton que tiene configurado este evento.
            ActivarBoton(sender);

            //Llamo la funcion para abrir el formulario al hacer click en el boton
            OpenChildForm(new frmClientes());
        }
        private void TimerFechaHora_Tick(object sender, EventArgs e)
        {
            int dia = DateTime.Now.Day;
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("ddd" + dia + " " + "MMMM" + " " + "yyyy").Replace(" ", " de ");
        }
    }
}
