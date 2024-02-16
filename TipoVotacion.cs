using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacion
{
    /// <summary>
    /// is this class will be defined the type of vote of 
    /// salvadorean population. 
    /// </summary>
    public class TipoVotacion
    {
        private int id;
        private string name;
        private int valor;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Valor { get => valor; set => valor = value; }

        public void Votos()
        {
            Console.WriteLine("***** precione la opcion de su preferencia *****");
            Console.WriteLine("1, votacion de presidente y vicepresidente de la Republica");
            Console.WriteLine("2, votacion para diputaciones para la Asamblea Legislativa de la Republica ");
            Console.WriteLine("3, votacion para consejos municipales de la Republica");
            Console.WriteLine("4, votacion para diputacion para el parlamento de la Republica");

            //definition of variable
            valor = 0;
            valor = int.Parse(Console.ReadLine());

            
            switch (valor)
            {
                case 1:
                    Console.WriteLine("votacion de presidente y vicepresidente de la Republica");
                    break;
                case 2:
                    Console.WriteLine("votacion para diputaciones para la Asamblea Legislativa de la Republica");
                    break;
                case 3:
                    Console.WriteLine("votacion para consejos municipales de la Republica");
                    break;
                case 4:
                    Console.WriteLine("votacion para diputacion para el parlamento de la Republica");
                    break;
                default:
                    Console.WriteLine("seleccione una opcion, por favor");
                    break;
            }
        } 
    }
}
