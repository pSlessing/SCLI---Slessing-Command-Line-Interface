partial class CliHandler
{
        private void ProcessCommand(string input)
    {
        switch (input.ToLower())
        {
            case "ss":
                SS();
                break;

            case "spo":
                SPO();
                break;

            case "caos":
                CAOS();
                break;

            case "jazz":
                JAZZ();
                break;

            case "project4":
                PROJECT4();
                break;

        }

    }
}