using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTryAgain
{
    internal class LibrosTerror : Libreria
    {
        protected string direccion, numero;
        protected static int contR6 = 0, contV6=0;
        public LibrosTerror(double preciobase) : base(preciobase)
        {
            RentaoCompra();
        }
        public void RentaoCompra()
        {
            if (this.bandera == true)
            {
                contR6++;
                Console.WriteLine("Deberas introducir su direccion del hogar por rentar este Libro");
                direccion = Console.ReadLine();
                Console.WriteLine("Ahora introdusca su numero telefonico");
                numero = Console.ReadLine();
                precio = (60 * precio) / 100;
                Console.WriteLine("Precio del libro por renta es: $"+precio);
            }
            else
            {
                contV6++;
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
        public int ContR6
        {
            get
            {
                return contR6;
            }
            set
            {
                contR6 = value;
            }
        }
        public int ContV6
        {
            get
            {
                return contV6;
            }
            set
            {
                contV6 = value;
            }
        }
    }
}
