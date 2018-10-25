using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace MVC
{
    class Controlador
    {
        public Form1 form1;
        private ListaComida comidas;

        public Controlador()
        {
            comidas = new ListaComida();
        }

        public void OnAgregarComida(string nombre, int proteina, int grasa, int carbohidrato)
        {
            comida comida = new comida(nombre, proteina, grasa, carbohidrato);
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }
    }
}
