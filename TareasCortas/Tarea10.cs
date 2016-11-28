using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea10
    {
        /*
	Tarea Corta 10
	Estudiante: [Your Name]
	
	Enunciado:
	Inversion de un string: Al recibir un string S, retornar un string cuyas palabras estan invertidas, sin invertir el orden de las palabras.
	"The Sky is Blue" -> "ehT ykS si eulB"
*/
        public string palabrasInvertdas(string palabra)
        {

            string newStringReversed = "";//variable que guarda las palabra reversada 
            char[] delimiterChars = { ' ' };//delimita los espacios
            string[] palabras = palabra.Split(delimiterChars);//define los espacios entre cada palabra 
            Console.WriteLine("Phrase entered: " + palabra);//muentra un mensaje
            Console.WriteLine("\n");//deja un espacio
            Console.WriteLine("Inverted sentence: ");//muentra otro mensaje de la palabra invertida
            foreach (var word in palabras)//se hace un for para recorrer la palabra
            {
                string newString = "";//variable para guardar la nueva palabra 
                foreach (var pieceOfWord in word.ToCharArray())
                {
                    // recorre el arreglo y extrae cada palabra de la vairable y designa en la nuev variable

                    newString = pieceOfWord + newString;
                }
                // variable que guarda la nueva palabra invertida 
                newStringReversed = newStringReversed + newString + " ";

            }
            Console.Write(newStringReversed);//imprime la nueva vaible reversible 

            
            return newStringReversed;//retorna la nueva palabra reversible 

        }


    }
}
}
