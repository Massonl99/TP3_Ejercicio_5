using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Texto
    {
        private string cadena;
        private int Longuitud = 20;
        public string Cadena
        {
            get { return cadena; }
            set { cadena = value; }
        }
        public Texto()
        {
            int yoquese=0;
            DoNothim(yoquese);
        }

        public void DoNothim(int nose)
        {
        }
    }
}
