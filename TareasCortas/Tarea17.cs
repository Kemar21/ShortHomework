using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea17
    {

        /*
            Tarea Corta 1
            Estudiante: [Your Name]

            Enunciado:
            Dado un string S, encuentre todos los caracteres repetidos en el string, imprima una linea con cada caracter repetido y cuantas veces aparece
            Ejemplo:
            "abcdabeacd"
            >a,3
            >b,2
            >c,2
            >d,2
        */
        public void caracters(string word)
        {
            int i = 0;
            int count = 1;

            Console.WriteLine(word.Length);

            for (i = 0; i < word.Length - 1; i++)
            {
                if (word.Substring(i, i + 1).Equals(word.Substring(i + 1, i + 2)))
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            Console.WriteLine(word.Substring(i + 1, i + 2)+count);

        }
    }
}
