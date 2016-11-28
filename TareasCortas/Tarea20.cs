using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea20
    {
        /*
	Tarea Corta 1
	Estudiante: [Your Name]
	
	Enunciado:
	Identificador de numeros primos, escriba una funcion que indique si un numero recibido es primo o no, tome en cuenta que el numero recibido estará en un rago de 
	1 a 5000.
*/

        public void esPrimo(int n)
        {
            int a = 0;

            for (int i = 1; i < (n + 1); i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("No es Primo");
            }
            else
            {
                Console.WriteLine("Si es Primo");
            }
            Console.ReadLine();
        }
    }
}
    }
}
