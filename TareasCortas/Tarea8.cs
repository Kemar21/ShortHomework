using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    public class Tarea8
    {
        /*
	Tarea Corta 1
	Estudiante: [Kembly Arias]
	
	Enunciado:
	Validez de parentesis:
	Se va a recibir un string S que contienen unicamente los caracteres '(' y ')', ustedes deben escribir una funcion que valida si la secuencia de parentesis es valida,
	esto quiere decir que cada parentesis abierto tenga un parentesis que lo cierre.
	Por ejemplo:
	"()" -> True
	"((" -> False
	"(()(()))" -> True
	"(()(())))" -> False
*/
        public Boolean validezParentesis(string cad)
        {
            bool invert = false;//se inicializa una variable booleana 
            for(int i = 0; i < cad.Length; i++)// el ciclo recorre el string
            {
             
                if(cad.StartsWith("(") && (cad.EndsWith(")")))// si la cadena empieza con '(' y termina con ')' 
                {
                    invert = true;// se retorna la variable en verdadera
                   
                }else
                {
                    invert = false;// sino se retorna en false porque no cumple con la condicion
                    
                }
            }
            return invert;
        }
    }
}
