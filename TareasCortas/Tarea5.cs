using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    public class Tarea5
    {
        public int versions(string number1, string number2)
        {
            // se convierte a el primer y segundo nombre 
            double firstNumber = Convert.ToDouble(number1);
            double secondNumber = Convert.ToDouble(number2);
            int anwers = 0; 

            //Se imprime el numero uno
            Console.WriteLine("Number one:");
            Console.WriteLine(number1);

            Console.Write(number2);
            
            //condicion para saber si el primer numero es mayor que el segundo 
            if (firstNumber > secondNumber)
            {// si la condicion  se verdadera 
                anwers = -1;// retorna -1
                Console.WriteLine("Return: " + anwers + ", the first number is more");
            }
            //pragunta si el segundo numerp es mayor 
            if (firstNumber < secondNumber)
            {// si se cumple la cndicion retorna 1
                anwers = 1;
                Console.WriteLine("Return: " + anwers + ", the second number is more");
            }
            //Pregunta si el numero 1 es igual al segundo 
            if (firstNumber == secondNumber)
            {// Si esto se cumple retorna 0
                anwers = 0;
                Console.WriteLine("Return: " + anwers + ", the numbers are equals");
            }

            return anwers;//returns 1, -1 or 0
        }
    }
    }

