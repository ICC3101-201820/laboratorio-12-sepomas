using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace lab_12_anabalon
{
    public delegate void AgregarComidaDelegate(string nombre, string carbohidratos,string proteinas,string grasas);
    public partial class Form1 : Form
    {
        public event EventHandler<OnAgregarComidaArgs> OnAgregarComida;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            {
                OnAgregarComidaArgs comidaArgs = new OnAgregarComidaArgs();
                comidaArgs.carbohidratos =carbohidrato.Text;
                comidaArgs.nombre = nombre.Text;
                comidaArgs.proteinas = proteinaBox.Text;
                comidaArgs.grasas = grasa.Text;
                OnAgregarComida.Invoke(sender, comidaArgs);
            }
        }
        public void AgregarComida(Comida comida)
        {
            alimentos.Items.Add(comida);
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void grasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void carbohidrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void proteinaBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
