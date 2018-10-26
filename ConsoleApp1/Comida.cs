using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comida
    {
        string nombre, carbohidratos, proteinas, grasas;

        public Comida(string n, string c,string p,string g)
        {
            nombre = n;
            carbohidratos = c;
            proteinas = p;
            grasas = g;
        }

        public override string ToString()
        {
            return $"{nombre} <{carbohidratos}> {carbohidratos} <{proteinas}> {proteinas}  <{grasas}> {grasas}";
        }
    }
}
