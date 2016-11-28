using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea14
    {

        /*
            Tarea Corta 1
            Estudiante: [Your Name]

            Enunciado:
            Substring con la mayor cantidad de 2 caracteres unicos:
            Dado un string s, debe retornar el substring mas largo que contenga unicamente 2 caracteres distintos
            Ejemplo: 
            "abcbbbbcccbdddadacb" -> "bcbbbbcccb"
        */

        public void caracters(string word)
        {
            int i = 0;
            

            Console.WriteLine(word.Length);

            for (i = 0; i < word.Length - 1; i++)
            {
                if(word.Substring(i,i+1).Equals(word.Substring(i+1,i+2)))
                {
                  Console.WriteLine( word.Substring(i + 1, i + 2));
                }
               
            }
        }
    }
}
