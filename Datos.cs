using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacion
{
    public class Datos
    {
        private int _id;
        private string _name;
        

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        
        
       
        public void Dato()
        {
            //valor inicializado para la variable valor 
            int valor = 1;

            Console.WriteLine("***** here introduce the data in the order  *****");
            Console.WriteLine("1, introduce the personal data of the vigilants, here!");
            Console.WriteLine("2, introduce the personal data of the votation table, here! ");

            valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.WriteLine("***** INGRESE LOS DATOS DE LOS VIGILANTE DE LOS PARTIDOS POLITICOS\" + \r\n" +
                        "\" EN CONTIENDA ******");
                    break;
                case 2:
                    Console.WriteLine("***** INGRESE LOS DATOS DE LOS INTEGRANTES DE LA MESA DE VOTACION ******");
                    break;
                default:
                    Console.WriteLine("select a option here!" +
                    "in the moment! please");
                    break;
            }
        }
    }
}
