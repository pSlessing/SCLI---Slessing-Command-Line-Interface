partial class CliHandler
{
        private void HandleCommand(string input)
    {
        RunPreCommands();
        ProcessCommand(input);
        RunPostCommands();

    }

    private void RunPreCommands()
    {

        var currentDate = DateTime.Now;
        if (currentDate.DayOfWeek == DayOfWeek.Monday)
        {
            Console.WriteLine("Eow, husk at du har fodbold i aften!");
        }

        //Evt. tilføj andre checks n balances

    }


    private void RunPostCommands()
    {
        Console.WriteLine(@"  _________.__                       .__                 
 /   _____/|  |   ____   ______ _____|__| ____    ____   
 \_____  \ |  | _/ __ \ /  ___//  ___/  |/    \  / ___\  
 /        \|  |_\  ___/ \___ \ \___ \|  |   |  \/ /_/  > 
/_______  /|____/\___  >____  >____  >__|___|  /\___  /  
        \/           \/     \/     \/        \//_____/   
_________                                           .___ 
\_   ___ \  ____   _____   _____ _____    ____    __| _/ 
/    \  \/ /  _ \ /     \ /     \\__  \  /    \  / __ |  
\     \___(  <_> )  Y Y  \  Y Y  \/ __ \|   |  \/ /_/ |  
 \______  /\____/|__|_|  /__|_|  (____  /___|  /\____ |  
        \/             \/      \/     \/     \/      \/  
.____    .__                                             
|    |   |__| ____   ____                                
|    |   |  |/    \_/ __ \                               
|    |___|  |   |  \  ___/                               
|_______ \__|___|  /\___  >                              
        \/       \/     \/                               
.___        __                 _____                     
|   | _____/  |_  ____________/ ____\____    ____  ____  
|   |/    \   __\/ __ \_  __ \   __\\__  \ _/ ___\/ __ \ 
|   |   |  \  | \  ___/|  | \/|  |   / __ \\  \__\  ___/ 
|___|___|  /__|  \___  >__|   |__|  (____  /\___  >___  >
         \/          \/                  \/     \/    \/ ");
    }
}