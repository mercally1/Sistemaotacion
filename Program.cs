using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL SITEMA DE VOTACION");
            
            //objet that select the type of votation
            var tipo =new TipoVotacion();
            tipo.Votos();
           
            //select the departament
            var depar = new Departamento();
            depar.departamento();


            int valor = 0;
            while ( valor <=0)
            {
                var partido = new Partido();
                partido.partido();
            }

            Console.ReadLine();
        }
    }
}
