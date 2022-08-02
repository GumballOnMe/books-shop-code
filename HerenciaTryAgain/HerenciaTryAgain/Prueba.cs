using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTryAgain
{
    internal class Prueba
    {
        Libreria x;
        Prueba l;
        LibrosTerror T;
        LibrosComedia C;
        LibrosInfantiles I;
        LibrosTecnicos Te;
        int opc, opc2;
        double pagar;
        static int contT=0, pr=0, pv=0, pr1=0, pv1=0, pr2 = 0, pv2 = 0, pr3 = 0, pv3 = 0, pvt=0, prt=0;
        static double pl = 0, pl1 = 0, pl2 = 0, pl3 = 0;
        public Prueba()
        {
            Console.WriteLine("1.Libros de Terror $270.00" +
                              "\n2.Libros de Comedia $250.00"+
                              "\n3.Libros Infantiles $200.00"+
                              "\n4.Libros Tecnicos $350.00");
            Console.WriteLine("Selecciona la catergoria del libro con los Numeros");
            Menu();
            Again();
        }
        public int Menu()
        {
            do
            {
                opc = int.Parse(Console.ReadLine());
                contT++;
                switch (opc)
                {
                    case 1:
                        T = new LibrosTerror(270);
                        pl = T.Precio;
                        pr = T.ContR6;
                        pv = T.ContV6;
                        Console.WriteLine("Cantidad a pagar por el libro: $" + pl);
                        pagar = double.Parse(Console.ReadLine());
                        if (pagar < pl)
                        {
                            contT--;
                            Console.WriteLine("No tienes suficiente dinero para pagar el libro");
                        }
                        else
                        {
                            pagar = pagar - pl;
                            Console.WriteLine("-------------TICKET-------------");
                            Console.WriteLine("Tu cambio por el libro: " + pagar);
                        }
                        break;
                    case 2:
                        C = new LibrosComedia(250);
                        pl1 = C.Precio;
                        pr1 = C.ContR1;
                        pv1 = C.ContV1;
                        Console.WriteLine("Cantidad a pagar por el libro: $" + pl1);
                        pagar = double.Parse(Console.ReadLine());
                        if (pagar < pl1)
                        {
                            contT--;
                            Console.WriteLine("No tienes suficiente dinero para pagar el libro");
                        }
                        else
                        {
                            pagar = pagar - pl1;
                            Console.WriteLine("-------------TICKET-------------");
                            Console.WriteLine("Tu cambio por el libro: " + pagar);
                        }
                        break;
                    case 3:
                        I = new LibrosInfantiles(200);
                        pl2 = I.Precio;
                        pr2 = I.ContR2;
                        pv2 = I.ContV2;
                        Console.WriteLine("Cantidad a pagar por el libro: $" + pl2);
                        pagar = double.Parse(Console.ReadLine());
                        if (pagar < pl2)
                        {
                            contT--;
                            Console.WriteLine("No tienes suficiente dinero para pagar el libro");
                        }
                        else
                        {
                            pagar = pagar - pl2;
                            Console.WriteLine("-------------TICKET-------------");
                            Console.WriteLine("Tu cambio por el libro: " + pagar);
                        }
                        break;
                    case 4:
                        Te = new LibrosTecnicos(350);
                        pl3 = Te.Precio;
                        pr3 = Te.ContR3;
                        pv3 = Te.ContV3;
                        Console.WriteLine("Cantidad a pagar por el libro: $" + pl3);
                        pagar = double.Parse(Console.ReadLine());
                        if (pagar < pl3)
                        {
                            contT--;
                            Console.WriteLine("No tienes suficiente dinero para pagar el libro");
                        }
                        else
                        {
                            pagar = pagar - pl3;
                            Console.WriteLine("-------------TICKET-------------");
                            Console.WriteLine("Tu cambio por el libro: " + pagar);
                        }
                        break;
                    default:
                        contT--;
                        Console.WriteLine("Seleccione del 1 al 4");
                        break;
                }
            } while (opc > 4);
            return opc;
        }
        public void Again()
        {
            Console.WriteLine("Deseas agregar otro libro? \n1.Si\n2.No");
            opc2 = int.Parse(Console.ReadLine());
            if (opc2 == 1)
            {
                Console.WriteLine("1.Libros de Terror $270.00" +
                  "\n2.Libros de Comedia $250.00" +
                  "\n3.Libros Infantiles $200.00" +
                  "\n4.Libros Tecnicos $350.00");
                Console.WriteLine("Selecciona la catergoria del libro con los Numeros");
                Menu();
                Console.Clear();
            }
        }
        public void Imprimir_Total()
        {
            pvt=pv + pv1 + pv2 + pv3;
            prt=pr + pr1 + pr2 + pr3;
            Console.WriteLine("Libros en total: "+contT);
            Console.WriteLine("Libros vendidos: "+pvt);
            Console.WriteLine("Libros rentados: "+prt);
        }
    }
}
