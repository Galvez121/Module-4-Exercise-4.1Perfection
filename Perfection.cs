using System;

class Perfection{

    static void Main(){

        Console.WriteLine("Please enter a number to check if it is perfect: ");

        // Chech if it is an interger

        if(int.TryParse(Console.ReadLine(), out int perfectNumber)){

            int sumOfDivisors = 0;

            for(int i = 1; i <= perfectNumber /2; i++){
                
                // Use the module operator to check if it is a devisor
                if(perfectNumber % i == 0){
                    sumOfDivisors += i;

                }

            }

            if (sumOfDivisors == perfectNumber){
                Console.WriteLine("Perfect Number");
            }
            else{
                Console.WriteLine("Not A Perfect Number");
            }

        }
        else{
            Console.WriteLine("Enter a valid number");
        }


    }

}