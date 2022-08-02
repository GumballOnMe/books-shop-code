using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTryAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Prueba l;
            do
            {
                l= new Prueba();
                Console.WriteLine("Deseas introducir otro cliente? \n1.Si \n2.No");
                opc=int.Parse(Console.ReadLine());
            }while(opc==1);
            l.Imprimir_Total();
            Console.ReadKey();
        }
    }
}
