partial class CliHandler
{
        private void SS()
    {
        OpenBrowser("https://www.moodle.aau.dk/course/view.php?id=55099");
        OpenBrowser("C:\\Users\\peter\\Desktop\\SlessingCLI\\ITTTC.pdf");
        OpenBrowser("C:\\Users\\peter\\Desktop\\SlessingCLI\\TAT.pdf");
        Console.WriteLine("Have fun with Giorgio");
    }

    private void SPO()
    {
        OpenBrowser("https://www.moodle.aau.dk/course/view.php?id=55097");
        OpenBrowser("C:\\Users\\peter\\Desktop\\SlessingCLI\\ITCD.pdf");
        Console.WriteLine("Have fun with Hans");
    }

    private void CAOS()
    {
        OpenBrowser("https://www.moodle.aau.dk/course/view.php?id=55115");
        OpenBrowser("C:\\Users\\peter\\Desktop\\SlessingCLI\\CSAPP_2016.pdf");
        Console.WriteLine("Have fun with Brian");
    }

    private void JAZZ()
    {
        OpenBrowser("tidal://playlist/a0e649f8-c7a5-4879-bbf2-d98110b42d2b");
        SendPlayPauseKey();
        Console.WriteLine("Playing the BEST version of jazz...");
    }

    private void PROJECT4()
    {
        OpenBrowser("https://typst.app/project/wFaYKt9IDjF0SpBBXweJlx");
        OpenBrowser("https://gbdev.io");
        OpenBrowser("https://gbdev.io/rgbds-live/");
    }
}