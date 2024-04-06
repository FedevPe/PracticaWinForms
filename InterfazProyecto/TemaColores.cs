using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazProyecto
{
    public static class TemaColores
    {
        public static Color pnlPrincipal;
        public static Color pnlBotones;
        public static Color pnlTop;
        public static Color fuenteTexto = Color.White;
        public static Color colorBotones = Color.Transparent;

        public static void CambiarTema(bool x)
        {
            if (x==false)
            {
                 //  Colores Tema Claro
                 pnlPrincipal = Color.White;
                 pnlBotones = Color.MediumSeaGreen;
                 pnlTop = Color.FromArgb(60, 102, 75);

            }
            if (x==true)
            {
                //  Colores Tema Oscuro
                pnlPrincipal = Color.FromArgb(23, 117, 81);
                pnlBotones = Color.FromArgb(29, 66, 51);
                pnlTop = Color.FromArgb(0, 66, 38);
            }
        } 
    }
}

        



    

        
            
        
    

