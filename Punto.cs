using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyPuntos
{
    class Punto
    {
        private double x, y;

        public Punto(double x, double y) {
            this.x = x;
            this.y = y;
        }

           public double pX
        {
            set { x = value; }
        }

        public double pY
        {
            set { y = value; }
        }

        public string mostrarPunto() {
            return "(" + x + ";" + y + ")";
        }

        public double distanciaOrigen() {
            return Math.Sqrt(((x * x) + (y * y)));
        }
      }
    }
