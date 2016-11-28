using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea12
    {
        /*
	Tarea Corta 1
	Estudiante: [Your Name]
	
	Enunciado:
	Encontrar el K-esimo elemento las grande en un arreglo desordenado, notese que es el k-esimo elemento en el arreglo ordenado, no el k-esimo elemento distinto.
	ejemplo:
	[3,2,1,5,6,4], k=2 -> retorna 5
*/

        public string kEsimo(string cad, int n)
        {
            // se inicializa las variables necesarias para guardar la nueva cadena, el contador y la palabra 
            cad += "";
            string nuevaCad = "";
            int m = 0;
            string palabra = "";
            for(int i=0; i < cad.Length; i++)// se utiliza un for para recorrer la palabra 
            {
                palabra += cad.Substring(i);
                if (palabra.Substring(i) == "")// si la palabra subString (i) es igual a nula se aumenta la variable m
                {
                    m++;
                    if(m != n) //si el contador m es diferente a el elemento 
                    {
                        nuevaCad = palabra; // se iguala la cadena nueva que esta vacia y se le agrega la palabra
                    }

                    palabra = "";
                }
            }

            return nuevaCad.Trim();
        }
    }
}
