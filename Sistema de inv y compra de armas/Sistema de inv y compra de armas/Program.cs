using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_inv_y_compra_de_armas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuidad = true;
            List<Armas> inv = new List<Armas>();

            while (continuidad)
            {
                string seleccionar;
                Console.WriteLine("1: Comprar arma");
                Console.WriteLine("2: Inventario");
                Console.WriteLine("3: Salida");

                seleccionar = Console.ReadLine();
                Console.Clear();

                switch(seleccionar)
                {
                    case "1":

                        Console.WriteLine("Tiendita");
                        Console.WriteLine("---------");
                        Console.WriteLine("Armas");
                        Console.WriteLine("=====");
                        Console.WriteLine("1) Pistola");
                        Console.WriteLine("2) Arco");
                        Console.WriteLine("3) Espada");
                        Console.WriteLine("=====");
                        Console.WriteLine("Municiones");
                        Console.WriteLine("=====");
                        Console.WriteLine("4) Balas");
                        Console.WriteLine("5) Flechas");

                        seleccionar = Console.ReadLine();
                        Console.Clear();

                        bala bala = new bala("bala ", 5, 50);
                        flecha flech = new flecha("flecha ", 10, 20);

                        switch(seleccionar)
                        {
                            case "1":
                                pistola pistol = new pistola("Pistola ", 5, 1f, 300, bala.daño);
                                pistol.data();
                                inv.Add(pistol);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "2":

                                arco arc = new arco("Arco ", 10, 1.5f, 80, flech.daño);
                                arc.data();
                                inv.Add(arc);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":

                                espada spada = new espada("Espada ", 2, 0.5f, 100);
                                spada.data();
                                inv.Add(spada);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "4":

                                bala.data();
                                inv.Add(bala);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "5":

                                flech.data();
                                inv.Add(flech);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine(" No hay nada ");
                                Console.ReadLine();
                                Console.Clear();

                                break;

                        }

                        break;

                     case "2": //inventario 

                        if (inv.Count > 0)
                        {
                            for (int i = 0; i < inv.Count; i++)
                            {
                                Console.WriteLine(inv[i].GetType().Name);
                            }


                            Console.WriteLine("1) Eliminar objeto ");
                            Console.WriteLine("2) back ");
                            seleccionar = Console.ReadLine();
                            Console.Clear();

                            switch (seleccionar)
                            {
                                case "1":

                                    for (int i = 0; i < inv.Count; i++)
                                    {

                                        Console.WriteLine(i + "" + inv[i].GetType().Name);
                                    }

                                    int a = int.Parse(Console.ReadLine()); //convierte de texto a entero

                                    inv.Remove(inv[a]);

                                    Console.Clear();

                                    break;

                                case "2":

                                    

                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine(" no hay nada ");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;

                    case "3":
                        continuidad = false;
                        break;
                }
            }
        }
    }
}
