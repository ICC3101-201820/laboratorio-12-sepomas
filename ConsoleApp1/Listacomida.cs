using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Modelo
{
    public class Listacomida
    {
        List<Comida> comidas;

        public Listacomida()
        {
            comidas = new List<Comida>();
        }

        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
    }
}
