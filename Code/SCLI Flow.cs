partial class CliHandler
{
    private void HandleCommand(string input)
    {
        RunPreCommands();

        bool validatedInput = false;

        while (!validatedInput)
        {
            try
            {
                Console.Write("Input your desired command:");
                var inputString = Console.ReadLine();
                if (inputString is null) { continue; }
                validatedInput = true;
                input = inputString;
            }
            catch (Exception) { Console.WriteLine("Your input was not valid, please try again"); }
        }

        ProcessCommand(input);
        RunPostCommands();

    }

    private void RunPreCommands()
    {

        PrintLogo();
        var currentDate = DateTime.Now;
        Console.WriteLine($"The day is {currentDate.DayOfWeek} the {currentDate.Day}. of {getFullMonthName(currentDate.Month)}");

        if (currentDate.DayOfWeek == DayOfWeek.Monday)
        {   
            Console.WriteLine();
            Console.WriteLine("Eow, husk at du har fodbold i aften!");
        }

        TODAY();

    }


    private void RunPostCommands()
    {
        
    }
}