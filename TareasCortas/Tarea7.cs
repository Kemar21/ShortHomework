using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea7
    {
        /*
	Tarea Corta 7
	Estudiante: [Kembly Arias]
	
	Enunciado:
	Dado un arreglo de longitud N, retornar un arreglo que contenga los K caracteres mas frecuentes.
	Ejemplo:
	[1,2,3,4,3,2,5], 2 -> Queremos los dos caracteres mas frecuentes del arrelgo
	Resultado -> [2,3] 
*/

        public void searchNumber(string numbers, int elemt)
        {
            
            for(int i = 0; i < numbers.Length; i++)//recorremos el arreglo para buscar los numeros
            {
                // se inicializa dos variables que una es para cuando se encuentra el numoer y el otro para acumular las veces que 
                // se encuentra repetido
                bool find = false;
                int count = 0;

                while ((!find) && (count < numbers.Length))//mientras que sea diferente a encontrado y dentro de las lista numeros sea mayor que el contador
                {
                    if (numbers[elemt] == numbers[i])// si el elemento buscado esta dentro del arreglo y este se acumula y la variable find cambia a verdadera
                    {
                        find = true;
                        count++;
                    }

                }

                if (find)// por ultimo se pregunta por la variable find para ver si se ha encontrado el numero
                {
                    Console.WriteLine("El numero repetido" + numbers[i] + " y la cantidad de veces que se repite " + count);
                }
            }
        }
    }
}
