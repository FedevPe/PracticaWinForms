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
    public partial class frmEjercicios : Form
    {
        public frmEjercicios()
        {
            InitializeComponent();
        }
        private void frmEjercicios_Load(object sender, EventArgs e)
        {
            pnlPrincipal.Height = 0;
            pnlPrincipal.Visible = false;
            timerDesplegar.Start();
        }
        private void timerDesplegar_Tick(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = true;

            pnlPrincipal.Height += 20;

            if (pnlPrincipal.Height >= 566)
            {
                timerDesplegar.Stop();
            }
        }
    }
}
