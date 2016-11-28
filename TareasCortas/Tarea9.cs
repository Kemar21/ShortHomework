using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea9
    {
        /*
	Tarea Corta 1
	Estudiante: [Your Name]
	
	Enunciado:
	Rotacion de palabras en un string: Al recibir un string, se debe retornar un nuevo string en el que se roten sus palabras.
	Ejemplo:
	"the sky is blue" -> "blue is sky the"
	
	
*/

        public void invertString(string cad)
        {
            string invertCad = "";// se inicializa un nuevo string para que guarde la frase invertida
            for (int i = cad.Length - 1; i>=0; i--)// se recorre con un for que se le resta -1 para que lo haga de atras para delante
            {
                
                invertCad = invertCad + cad.Substring(i);// se guarda la cadena invertida 
            }

            Console.WriteLine("La cadena invertida es:"+invertCad);
        }

    }
}
