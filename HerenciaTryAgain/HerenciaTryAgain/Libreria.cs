using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTryAgain
{
    internal class Libreria
    {
        Libreria x;
        public bool bandera = false;
        protected string nombre, nombrel;
        protected double precio;
        protected static int contR = 0, contV=0; 

        public Libreria(double preciobase)
        {
            precio = preciobase;
            Console.WriteLine("Nombre del libro a desear?");
            nombrel = Console.ReadLine();
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            CompraOrenta();
        }
        public int CompraOrenta()
        {
            Console.WriteLine("Que quiere hacer con el Libro \n1.Rentar\n2.Comprar");
            int opc;
            do
            {
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        this.bandera = true;
                        break;
                    case 2:
                        this.bandera = false;
                        break;
                    default:
                        Console.WriteLine("Seleccione Renta o Comprar!!");
                        break;
                }

            } while (opc > 2);
            return opc;
        }
    }
}
