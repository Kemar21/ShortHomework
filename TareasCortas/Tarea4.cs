using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{ 
    /*
	Tarea Corta 4
	Estudiante: [Your Name]
	
	Enunciado:
	Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
	La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
	Palindromo
*/
    class Tarea4
    {
        public Boolean Palindroma(string word)
        {// inicializo las variables 
            int left = 0;
            int right = 0;
            Boolean error = false;

            while((left<right) && (!error))// se hace la condicion que mientras de la variable de la derec sea menor al de la izqu y error sea verdadera
            {
                if(word.Substring(left) == word.Substring(right))// si el subString de la derecha sea igual el de la izq 
                {// se incrementa la derecha para volverla palabra y se decrementa la izq  
                    left++;
                    right--;
                }
                else
                {
                    error = true;
                }

            }

            return error;
        }
    }
}
