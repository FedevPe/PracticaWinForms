using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace InterfazProyecto
{
    public partial class ModuloPrincipal : Form
    {
        private int incremento = 10;
        private int destino = 60;
        private bool aumentando = true;
        private Thread th;

        private bool x = false;
        private bool y = false;
        private IconButton botonSeleccionadoMenu;
        private Panel bordeLateral;
        private Form currentChildForm;

        public ModuloPrincipal()
        {
            InitializeComponent();

            //Esta instrucción me permite ajustar el modulo principal al area de trabajo cuando
            //el formulario es maximizado
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //
            //Instrucciones para quitar el panel de titulo del formulario 
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //
            //bordeLateralBotonSeleccionado
            //
            bordeLateral = new Panel()
            {
                BackColor = Color.PaleGreen,
                Size = new Size(5, 49),
            };

            //Agrego el borde en el panel que lo contiene
            pnlMenu.Controls.Add(bordeLateral);
        }

        private void ModuloPrincipal_Load(object sender, EventArgs e)
        {
            //Ancho pnlMenu al cargar el formulario
            pnlMenu.Width = destino;

            //Iniciar Timer
            TimerHora.Start();

            //Cuando cargue el formulario abrir frmChildHome y activar boton menu principal
            AbrirFormularioHijo(new frmChildHome());
            ActivarBoton(btnHome);

            //Configuración Botones al cargar formulario
            imgLogo1.Visible = true;
            imgLogo2.Visible = false;
            btnHome.Text = "";
            btnMenuPrincipal.Text = "";
            btnCerrarSesion.Text = "";
            btnSettings.Text = "";
            btnPerfil.Text = "";
            btnColor.Visible = false;

            //Configuración Etiquetas al cargar formulario
            lblOff.Visible = false;
            lblON.Visible = false;

            //Configuración bordeLateralBotones al cargar formulario
            bordeLateral.Visible = false;
        }

        //Metodo para animar el menu de botones

        private void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            imgLogo1.Visible = false;
            imgLogo2.Visible = true;
            destino = 230;
            aumentando = true;
            TimerPnlMenu.Start();
        }
        private void pnlMenu_MouseLeave(object sender, EventArgs e)
        {
            pnlMenu.BringToFront();
            destino = 60;
            aumentando = false;
            TimerPnlMenu.Start();
        }

        private void TimerPnlMenu_Tick(object sender, EventArgs e)
        {
            if (aumentando)
            {
                if (pnlMenu.Width < destino)
                {
                    //Instrucción para aumentar el ancho del panel
                    pnlMenu.Width += incremento;
                }
                else
                {
                    //Configuración de controles al abrir menu

                    imgLogo2.Visible = true;
                    btnColor.Visible = true;
                    lblON.Visible = true;
                    lblOff.Visible = true;
                    btnHome.Text = "Inicio";
                    btnMenuPrincipal.Text = "Menu Principal";
                    btnPerfil.Text = "Usuario";
                    btnSettings.Text = "Configuración";
                    btnCerrarSesion.Text = "Cerrar Sesión";

                    //Parar timer
                    TimerPnlMenu.Stop();
                }
            }
            else
            {
                if (pnlMenu.Width > destino)
                {
                    //Instruccion para disminuir el ancho del panel
                    pnlMenu.Width -= incremento;
                    
                    //Configuración de controles al cerrar el menu
                    imgLogo1.Visible = true;
                    imgLogo2.Visible = false;
                    lblOff.Visible = false;
                    btnColor.Visible = false;
                    lblON.Visible = false;
                    btnHome.Text = "";
                    btnMenuPrincipal.Text = "";
                    btnCerrarSesion.Text = "";
                    btnSettings.Text = "";
                    btnPerfil.Text = "";

                }
                else
                {
                    //Parar timer
                    TimerPnlMenu.Stop();
                }
            }
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(nuevoFormulario);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void nuevoFormulario(object obj)
        {
            Application.Run(new ModuloLogin());
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnColor_CheckedChanged(object sender, EventArgs e)
        {


        }
        public void ActivarBoton(object boton)
        {
            DeshabilitarBotones();

            if (boton != null)
            {
                //Botones

                botonSeleccionadoMenu = (IconButton)boton;

                botonSeleccionadoMenu.BackColor = Color.FromArgb(23, 117, 81);
                botonSeleccionadoMenu.IconColor = Color.PaleGreen;
                botonSeleccionadoMenu.ForeColor = Color.PaleGreen;

                //BordeLateral

                bordeLateral.Location = new Point(0, botonSeleccionadoMenu.Location.Y);
                bordeLateral.Visible = true;
                bordeLateral.BringToFront();

            }

        }
        public void DeshabilitarBotones()
        {
            if (botonSeleccionadoMenu != null)
            {
                //BotonSeleccionado
                botonSeleccionadoMenu.BackColor = Color.FromArgb(29, 66, 51);
                botonSeleccionadoMenu.IconColor = Color.White;
                botonSeleccionadoMenu.ForeColor = Color.White;
                
                //BordeLateral
                bordeLateral.Visible = false;
            }
        }
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            //Llamamos a la funcion para cambiar los colores al hacer click, le da un efecto
            //de boton resaltado.
            ActivarBoton(sender);

            //Instrucciones para abrir formulario hijo al hacer click, como parámetro de la funcion 
            //colocamos el formulario que deseamos abrir.
            AbrirFormularioHijo(new frmChildMainMenu());

        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            //Llamamos a la funcion para cambiar los colores al hacer click, le da un efecto
            //de boton resaltado.
            ActivarBoton(sender);

            //Instrucciones para abrir formulario hijo al hacer click, como parámetro de la funcion 
            //colocamos el formulario que deseamos abrir.
            
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Llamamos a la funcion para cambiar los colores al hacer click, le da un efecto
            //de boton resaltado.
            ActivarBoton(sender);

            //Instrucciones para abrir formulario hijo al hacer click, como parámetro de la funcion 
            //colocamos el formulario que deseamos abrir.
        }     
        private void Reset()
        {
            DeshabilitarBotones();
        }
        private void AbrirFormularioHijo(Form childForm)
        {
            //Comprobar que el formulario hijo actual no sea nulo, y cerrarlo para mantener solo 1 abierto
            if (currentChildForm != null)
            {    
                currentChildForm.Close();       
            }

            //Configuramos algunas propiedades del formulario hijo
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //Asociamos el form hijo al panel que lo contiene
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;

            //Traemos el formulario al frente y mostramos
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            //Llamamos a la funcion para cambiar los colores al hacer click, le da un efecto
            //de boton resaltado.
            ActivarBoton(sender);

            //Instrucciones para abrir formulario hijo al hacer click, como parámetro de la funcion 
            //colocamos el formulario que deseamos abrir.
            AbrirFormularioHijo(new frmChildHome());
        }
        //
        //Instrucciones que me permiten mover el formulario al mantener presionado el click en pnlTop
        //
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}
        //
        //
        //
    }
}
