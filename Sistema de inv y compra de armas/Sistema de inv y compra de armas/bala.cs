using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_inv_y_compra_de_armas
{
    class bala:Armas
    {
        public string nombre;
        public int daño;
        public float precio;

        public bala(string nombre, int daño, float precio)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.precio = precio;
        }
        public override void data()
        {
            Console.WriteLine("Nombre " + nombre);
            Console.WriteLine("Daño " + daño);
            Console.WriteLine("Precio " + precio);
        }
    }
}
