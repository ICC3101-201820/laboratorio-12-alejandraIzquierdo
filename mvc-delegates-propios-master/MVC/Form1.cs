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

namespace MVC
{
    public delegate void AgregarContactoDelegate(string nombre, int proteina, int grasa, int carbohidrato);

    public partial class Form1 : Form
    {
        public event form1.AgregarComidaDelegate OnAgregarComida;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs nombre)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hay suscritos?
            if (OnAgregarComida != null)
            {
                // Notificar a los suscritos
                OnAgregarComida.Invoke(nombreTextBox.Text, proteinaTextBox.Text, grasaTextBox.Text, carbohidratoTextBox.Text);
            }
        }

        public void AgregarComida(comida comida)
        {
            comidas.Add(comida);
        }

        private void proteina_Click(object sender, EventArgs proteina)
        {

        }
        private void grasa_Click(object sender, EventArgs grasa)
        {

        }
        private void carbohidrato_Click(object sender, EventArgs carbohidrato)
        {

        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
