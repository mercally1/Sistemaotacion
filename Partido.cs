using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacion
{
     class Partido
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public void partido() 
        {
            var dato = new Datos();
            dato.Dato();

            int  valor = 0;
            while ( valor <= 2)
            {
                Console.WriteLine("ingresa tu numero de DUI");
                Console.ReadLine();

                Console.WriteLine("escribe tu nombre");
                Console.ReadLine();

                Console.WriteLine("escribe el partido politico");
                Console.ReadLine();

                Console.WriteLine(" ");

                valor++;
            }
           
        }
    }
}
