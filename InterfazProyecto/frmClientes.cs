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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            timerDesplegar.Start();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            pnlPrincipal.Height = 0;
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
