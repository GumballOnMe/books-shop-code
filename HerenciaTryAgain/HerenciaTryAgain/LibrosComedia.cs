using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTryAgain
{
    internal class LibrosComedia : Libreria
    {
        protected string direccion, numero;
        protected static int contR1 = 0, contV1 = 0;
        public LibrosComedia(double preciobase) : base(preciobase)
        {
            RentaoCompra();
        }
        public void RentaoCompra()
        {
            if (this.bandera == true)
            {
                contR1++;
                Console.WriteLine("Deberas introducir su direccion del hogar por rentar este Libro");
                direccion = Console.ReadLine();
                Console.WriteLine("Ahora introdusca su numero telefonico");
                numero = Console.ReadLine();
                precio = (60 * precio) / 100;
                Console.WriteLine("Precio del libro por venderlo es: $" + precio);
            }
            else
            {
                contV1++;
                Console.WriteLine("Precio del libro por comprarlo es: $" + precio);
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public int ContR1
        {
            get
            {
                return contR1;
            }
            set
            {
                contR1 = value;
            }
        }
        public int ContV1
        {
            get
            {
                return contV1;
            }
            set
            {
                contV1 = value;
            }
        }
    }
}
