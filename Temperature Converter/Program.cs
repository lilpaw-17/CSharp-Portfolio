string? userInput;
string input = "";
bool correctInput = false;
decimal numericInput = 0.00m;
string menuSelect = "";


do
{    
    Console.WriteLine("\nThis application will help you convert from Celcius to Fahrenheit and vice versa.");
    Console.WriteLine("(このアプリケーションは温度の変換器になっております)");
    Console.WriteLine("=================================================================================");
    Console.WriteLine("1. Celcius → Fahrenheit");
    Console.WriteLine("2. Fahrenheit → Celcius");
    Console.WriteLine("3. Quit program");
    Console.WriteLine("=================================================================================");
    Console.Write("Enter the number from the options above to proceed: ");
    userInput = Console.ReadLine();

    if (userInput != null)
    {
        menuSelect = userInput.ToLower();
    }
    

     switch (menuSelect)
    {

        case "1":   
            Console.Clear();
            Console.WriteLine("Convert Celcius to Fahrenheit\n=========================\n");
            Console.Write("Enter Celcius: ");
            do
            { 

            userInput = Console.ReadLine();

            if (userInput != null)
            {
                input = userInput.ToLower();
            }
            
            correctInput = decimal.TryParse(input, out numericInput);
            
            if(correctInput == true)
            {
                CelciusToFahrenheit(numericInput);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.Write("Enter Celcius: ");
            }
        
            } while (correctInput == false);
        Console.WriteLine("Press Enter to go back to main menu.");
        userInput = Console.ReadLine();
        break;
        

        case "2":
        Console.Clear();
            Console.WriteLine("Convert Fahrenheit to Celcius\n=========================\n");
            Console.Write("Enter Fahrenheit: ");
            do
            { 

            userInput = Console.ReadLine();

            if (userInput != null)
            {
                input = userInput.ToLower();
            }
            
            correctInput = decimal.TryParse(input, out numericInput);
            
            if(correctInput == true)
            {
                FahrenheitToCelcius(numericInput);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.Write("Enter Fahrenheit: ");
            }
        
            } while (correctInput == false);
        Console.WriteLine("Press Enter to go back to main menu.");
        userInput = Console.ReadLine();
        break;
        


    }


}while (menuSelect != "3");


void CelciusToFahrenheit(decimal inputCelcius)
{
    decimal result = (inputCelcius * 9/5m) + 32m;
    
    Console.WriteLine($"{inputCelcius} Celcius is {result.ToString("F2")} Fahrenheit.");

}

void FahrenheitToCelcius(decimal inputFahrenheit)
{
    decimal result = (inputFahrenheit - 32m) * 5/9m;
    
    Console.WriteLine($"{inputFahrenheit} Fahrenheit is {result.ToString("F2")} Celcius.");

}
