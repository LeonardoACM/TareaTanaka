using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_inv_y_compra_de_armas
{
    class espada : Armas
    {
        public string nombre;
        public int daño;
        public float va; //velocidad de ataque
        public float precio;


        public espada(string nombre, int daño, float va, float precio)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.va = va;
            this.precio = precio;
        }
        public override void data()
        {
            Console.WriteLine("Nombre " + nombre);
            Console.WriteLine("Daño " + daño);
            Console.WriteLine("Velocidad de ataque " + va);
            Console.WriteLine("Precio " + precio);

            int eldaño = Convert.ToInt32(daño / va);      //float a int.   

            Console.WriteLine("Daño x segundo " + eldaño);
        }
    }
}
