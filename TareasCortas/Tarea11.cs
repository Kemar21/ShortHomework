using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class Tarea11
    {
        public int[] subArreglo(int[] listOfNumbers, int number)
        {
            int numbersInOrder = 0;//variable that helps us to store the numbers in order
            int suma = 0;//variable that helps us store the result of the suma
            Console.WriteLine("Entered array: ");//message on the screen
            for (int l = 0; l < listOfNumbers.Length; l++)//recorre el arreglo ingresado 
            {
                Console.Write(listOfNumbers[l] + " ");//runs the arrangement from the position 0 to the length of the array.
            }
            Console.WriteLine("\n");//space
            Console.WriteLine("Entered number: " + number);//sample number entered
            Console.WriteLine("\n");//space
            for (int i = 0; i < listOfNumbers.Length; i++)//runs the arrangement from the position 0 to the length of the array.
            {
                for (int j = i + 1; j < listOfNumbers.Length; j++)//runs through the settlement taking into account the previous position 
                {
                    if (listOfNumbers[i] < listOfNumbers[j])//if the number is less than previous
                    {//The accommodates high to low
                        numbersInOrder = listOfNumbers[i];
                        listOfNumbers[i] = listOfNumbers[j];
                        listOfNumbers[j] = numbersInOrder;
                    }


                }

            }

            //sample message
            Console.WriteLine("Smaller Array:");
            //runs the new arrangement and it adds up to become greater than or equal to the number entered

            for (int k = 0; k < listOfNumbers.Length; k++)
            {
                Console.Write(listOfNumbers[k] + " ");//smaller sample arrangement
                suma = suma + listOfNumbers[k];//suma of the numbers of the array smaller
                if (suma >= number)//if the suma is greater than or equal to the number entered
                {//if satisfied sale
                    break;
                }
            }


            Console.ReadKey();// Stop the program until a key is pressed
            return listOfNumbers;//returns the smallest settlement
        }
    }
}
