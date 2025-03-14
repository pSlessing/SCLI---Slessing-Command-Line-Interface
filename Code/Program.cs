using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
class Program
{
    static int Main(string[] args)
    {
        var cli = new CliHandler();
        return cli.Run(args);
    }
}


partial class CliHandler
{
    private readonly RootCommand _rootCommand;

    public CliHandler()
    {
        _rootCommand = ConfigureCommand();
    }

    public int Run(string[] args)
    {
        return _rootCommand.Invoke(args);
    }

    private RootCommand ConfigureCommand()
    {
        var rootCommand = new RootCommand
        {
        };

        rootCommand.Handler = CommandHandler.Create<string>(HandleCommand);
        return rootCommand;
    }

}