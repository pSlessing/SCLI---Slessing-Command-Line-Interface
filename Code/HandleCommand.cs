partial class CliHandler
{
    private void HandleCommand(string input)
    {
        RunPreCommands();

        if (input.Length == 0)
        {
            bool validatedInput = false;

            while (!validatedInput)
            {

                try
                {
                    var inputString = Console.ReadLine();
                    if (inputString is null) { continue;}
                    validatedInput = true;
                    input = inputString;
                }
                catch (Exception) { Console.WriteLine("Your input was not valid, please try again"); }
            }
        }

        ProcessCommand(input);
        RunPostCommands();

    }

    private void RunPreCommands()
    {

        PrintLogo();
        var currentDate = DateTime.Now;
        if (currentDate.DayOfWeek == DayOfWeek.Monday)
        {
            Console.WriteLine("Eow, husk at du har fodbold i aften!");
        }

        TODAY();

    }


    private void RunPostCommands()
    {

    }
}