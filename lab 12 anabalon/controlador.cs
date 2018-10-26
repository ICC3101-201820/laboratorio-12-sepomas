using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace lab_12_anabalon
{
    public class Controlador
    {
        public Form1 form1;
        private Listacomida comidas;

        public Controlador()
        {
            comidas = new Listacomida();
        }

        public void OnAgregarComida(object sender, OnAgregarComidaArgs args)
        {
            Comida comida = new Comida(args.nombre, args.carbohidratos,args.proteinas,args.grasas);
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        } 
    }
}
