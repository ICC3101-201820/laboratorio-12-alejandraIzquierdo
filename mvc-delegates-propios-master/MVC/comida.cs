using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MVC
{
    public class comida
    {
        string nombre;
        int proteina;
        int grasa;
        int carbohidrato;

        public comida(string nombre, int proteina, int grasa, int carbohidrato)
            {
            this.nombre = nombre;
            this.proteina = proteina;
            this.grasa = grasa;
            this.carbohidrato = carbohidrato;
            }


    
        public override string ToString()
        {
            return $"{nombre}{proteina}{grasa}{carbohidrato}";
        }
    }
}
