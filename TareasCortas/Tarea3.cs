using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    public class Tarea3
    {
        /*
	Tarea Corta 3
	Estudiante: [Your Name]
	
	Enunciado:
	Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
*/
        public string identify(string[] list, string element)
        {
            int count = 0;// se inicializa un contador
            int position=0; // y una variable para poder encontrar la posicion
            
            for(int i=0; i < list.Length; i++)// un for para recorre la lista 
            {
               if (list[i] == element)// el elemento esta dentro de la lista
                {
                    count++;// aumento el contrador 

                    for(int j = 0; j < list.Length; j++)// se hace otro for para que recorra de nuevo la lista 
                    {
                        if(list[j] == element)// un if para identificar el elemento dentro de la lista
                        {
                            position = Convert.ToString( position + "" + [j + 1]);
                        }
                    }

                }
               else
                {
                    return Convert.ToString(0);
                }
                
            }

            return element;
        
        }

    }
}
