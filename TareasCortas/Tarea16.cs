using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea16
    {
        //Haga una funcion que imprima los primeros 100 elementos de la secuencia de fibonacci

        public int fibonacci( int i)
        {
            if ((i == 0) && (i == 1))
            {
                return 1;
            }else
            {
                return fibonacci(i - 1) + fibonacci(i = 2);
            }
        }
    }
}
