using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTryAgain
{
    internal class LibrosInfantiles : Libreria
    {
        protected string direccion, numero;
        protected static int contR2 = 0, contV2 = 0;
        public LibrosInfantiles(double preciobase) : base(preciobase)
        {
            RentaoCompra();
        }
        public void RentaoCompra()
        {
            if (this.bandera == true)
            {
                contR2++;
                Console.WriteLine("Deberas introducir su direccion del hogar por rentar este Libro");
                direccion = Console.ReadLine();
                Console.WriteLine("Ahora introdusca su numero telefonico");
                numero = Console.ReadLine();
                precio = (60 * precio) / 100;
                Console.WriteLine("Precio del libro por venderlo es: $" + precio);
            }
            else
            {
                contV2++;
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
        public int ContR2
        {
            get
            {
                return contR2;
            }
            set
            {
                contR2 = value;
            }
        }
        public int ContV2
        {
            get
            {
                return contV2;
            }
            set
            {
                contV2 = value;
            }
        }
    }
}
