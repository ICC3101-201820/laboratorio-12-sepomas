using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12_anabalon
{
    public class OnAgregarComidaArgs:EventArgs
    {
        public string nombre;
        public string carbohidratos;
        public string proteinas;
        public string grasas;
    }
}
