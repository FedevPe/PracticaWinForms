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
    public partial class frmChildHome : Form
    {
        public frmChildHome()
        {
            InitializeComponent();
        }
        private void frmChildHome_Load(object sender, EventArgs e)
        {
            TimerHoraFechaCurrentForm.Start();
        }

        private void TimerHoraFecha_Tick(object sender, EventArgs e)
        {
            int dia = DateTime.Now.Day;
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("ddd" + dia + " " + "MMMM" + " " + "yyyy").Replace(" ", " de ");
        }
    }
}
