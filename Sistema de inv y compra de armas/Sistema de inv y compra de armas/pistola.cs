using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_inv_y_compra_de_armas
{
    class pistola:Armas
    {
        //Si el arma es de distancia, debe sumarse el daño que causa el proyectil

        public string nombre;
        public int daño;
        public float va; //velocidad de ataque
        public float precio;
        public int dañobala; //proyectil


        public pistola(string nombre, int daño, float va, float precio, int dañobala)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.va = va;
            this.precio = precio;
            this.dañobala = dañobala;
        }
        public override void data()
        {
            Console.WriteLine("Nombre " + nombre);
            Console.WriteLine("Daño" + daño);
            Console.WriteLine("Velocidad de ataque" + va);
            Console.WriteLine("Precio" + precio);

            int a = Convert.ToInt32((daño + dañobala) / va);      //float a int.   

            Console.WriteLine("Daño x segundo" + a);
            Console.WriteLine("Municion necesaria: flechas");
        }
    }
}

