using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacion
{
    public class Departamento
    {
        private int id;
        private string name;
        private string description;
        private int poblation;
        private decimal stadistic;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Poblation { get => poblation; set => poblation = value; }
        public decimal Stadistic { get => stadistic; set => stadistic = value; }


        public void departamento()
        {
            
                Console.WriteLine("***** precione la opcion de su preferencia *****");
                Console.WriteLine("1, Ahuachapán");
                Console.WriteLine("2, Cabañas ");
                Console.WriteLine("3, Chalatenango");
                Console.WriteLine("4, Cuscatlán");
                Console.WriteLine("5, La Libertad");
                Console.WriteLine("6, La Paz");
                Console.WriteLine("7, La Unión");
                Console.WriteLine("8, Morazán");
                Console.WriteLine("9, San Miguel");
                Console.WriteLine("10, San Salvador");
                Console.WriteLine("11, San Vicente");
                Console.WriteLine("12, Santa Ana");
                Console.WriteLine("13, Sonsonate");
                Console.WriteLine("14, Usulután");


            //definition of variable
            int valor = 0;
            valor = int.Parse(Console.ReadLine());


                switch (valor)
                {
                    case 1:
                        Console.WriteLine("Ahuachapán");
                        break;
                    case 2:
                        Console.WriteLine("Cabañas");
                        break;
                    case 3:
                        Console.WriteLine("Chalatenango");
                        break;
                    case 4:
                        Console.WriteLine("Cuscatlán");
                        break;
                    case 5:
                    Console.WriteLine("La Libertad");
                        break;
                    case 6:
                    Console.WriteLine("La Paz");
                        break;
                    case 7:
                    Console.WriteLine("La Unión");
                        break;
                    case 8:
                    Console.WriteLine("Morazán");
                        break;
                    case 9:
                    Console.WriteLine("San Miguel");
                        break;
                    case 10:
                    Console.WriteLine("San Salvador");
                        break;
                    case 11:
                    Console.WriteLine("San Vicente");
                        break;
                    case 12:
                    Console.WriteLine("Santa Ana");
                        break;
                    case 13:
                    Console.WriteLine("Sonsonate");
                        break;
                    case 14:
                    Console.WriteLine("Usulután");
                        break;

                default:
                        Console.WriteLine("seleccione una opcion, por favor");
                        break;
                }
            
            
        }
    }
}
