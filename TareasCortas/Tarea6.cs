using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea6
    /*
Tarea Corta 6
Estudiante: [Your Name]

Enunciado:
El palindromo mas corto, 
Dado un string S, usted debe formar un palindromo al agregarle caracteres al final, forme el palindromo mas corto posible en base al string S recibido
"aace" -> aacecaa
"abcd" -> "abcdcba"
*/

    {
        public string palindrome(string word)
        {
            string chainOfLetters = "";//variable para acumular las letras de la palabra
            string palindrome = "";//variable que guarda la palabra reversa

            int i = word.Length;//mantiene el tamano del string

            for (int j = i - 2; j >= 0; j--)//se necesita un for pero se le resta para reversar la palabra
            {
                chainOfLetters = chainOfLetters + word[j];//se reversa cada palabra en la posicion contrario
            }
            palindrome = word + chainOfLetters;//se encrtra la palabra mas las nuevas palabras
          
            return palindrome; //returna la palabra con la nueva 
        }
    }
}
}
