using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    public class Program
    {
        /*
	Tarea Corta 1
	Estudiante: [Kembly Arias ]
	
	Enunciado:
	Escriba una funcion que retorne el elemento mas grande de una lista no ordenada	
*/
        public void Mayor(int [] arreglo)// se inicializa el metodo con un parametro 
        {
            int numeroMayor = arreglo[0];// se iguala la variable a al arregloo en cero
            for (int i= 0; i< arreglo.Length; i++)// se recorre el arreglo con un for 
            {
                if(arreglo[i] > numeroMayor) // dentro del arreglo[i] el numero que sea menor
                {
                    numeroMayor = arreglo[i];// se le iguala la variable al numero mayor que fue encontrado dentro de arreglo
                }
            }
            Console.WriteLine("El numero mayor es:" +numeroMayor);
        }
        static void Main(string[] args)
        {

        }
    }
}
