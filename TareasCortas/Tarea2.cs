using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    public class Tarea2
    {

        /*
            Tarea Corta 2
            Estudiante: [Kembly Arias]

            Enunciado:
            Escriba una funcion que le de vuelta a una lista, debe imprimir primero la lista original, y luego imprimir la lista invertida.
            Preferiblemente, darle vuelta a la lista sin crear una lista nueva.
        */
        // inicializacion del metodo
        public string ListaDoble( string lista)// se inicializa con el parametro tipo string incresar la palabra
        {
            string lista2 = "";
            for(int i=0;i<lista.Length; i++)//se hace un ciclo para recorrer toda la palabra
            {
                lista2 = lista[i] + lista2;// para guardar la palabra al reves 

            }
            return lista2;// por ultimo retorno la lista en donde guardo la palabra vuelta. 
        }

    }
}
