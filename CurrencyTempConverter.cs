using System;

namespace CurrencyTempConverter
{
    class Program
    {
        static void Main(String[] args)
        {
            System.Console.WriteLine("Welcome!!! Please enter'c' to use the currency converter or anything else to use temperature converter.");
            string answer = Console.ReadLine();

            if(answer == "c"){
                System.Console.WriteLine("You have selected the currency converter.");
                System.Console.WriteLine("Please enter 'a' to convert from pounds or anything else to convert from euros. ");
                string choice = Console.ReadLine();

                if(choice == "a"){
                    System.Console.WriteLine("Please enter your amount in British pound");
                    float pounds =float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    System.Console.WriteLine("The amound in your euros is " + euros.ToString("0.00"));
                } else{
                    System.Console.WriteLine("Please enter your amount in euros.");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    System.Console.WriteLine("the amount in British pound is " + pounds.ToString("0.00"));
                }
            }else{
                System.Console.WriteLine("Welcome to the temperature converter!");
                System.Console.WriteLine("Please enter 'a' to convert celcius or anything else to convert from farenheit");
                string choice = Console.ReadLine();

                if(choice=="a"){
                    System.Console.WriteLine("Enter a temperature in celcius");
                    float celcius = float.Parse(Console.ReadLine());
                    float farenheit = celcius * 1.18f + 32f;
                    System.Console.WriteLine("The temperature in farenheit is "+ farenheit);
                }
                else{
                    System.Console.WriteLine("Please enter a temperature in farenheit.");
                    float farenheit = float.Parse(Console.ReadLine());
                    float celcius =(farenheit - 32f) / 1.8f;
                    System.Console.WriteLine("The temperature in celcius is: "+ celcius);
                }
            }
        }
    }
            
          
}
