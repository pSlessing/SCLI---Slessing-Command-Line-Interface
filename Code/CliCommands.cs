using System.Runtime.InteropServices;
using System.Text;

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

    private void PROJECTS()
    {
        Console.WriteLine(@"Select which project you would like to View:
        1
        2
        3
        4
        ");

        bool validatedInput = false;

        while (!validatedInput)
        {

            try
            {
                String? inputString = Console.ReadLine();
                if (inputString is null) { continue; }
                int projectChosen = int.Parse(inputString);
                validatedInput = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Your input was not valid, please try again");
            }
        }
    }

    private void POMODORO()
    {
        Console.WriteLine();
        Console.WriteLine();

        var nextTimeFlag = (DateTime.Now).AddMinutes(25);
        var bottomConsoleRow = Console.GetCursorPosition().Top;
        var currentTimeLeft = nextTimeFlag - DateTime.Now;
        char[] animationString = ("Aaaaaaaa").ToArray();
        int currentAnimationIndex = 0;
        Console.CursorVisible = false;


        while (DateTime.Compare(nextTimeFlag, DateTime.Now) > 0)
        {
            currentTimeLeft = nextTimeFlag - DateTime.Now;

            //Fun animation
            Console.SetCursorPosition(0, bottomConsoleRow - 2);
            Console.Write(animationString);
            //Dislay time
            Console.SetCursorPosition(0, bottomConsoleRow - 1);
            Console.Write($"{currentTimeLeft.Minutes}:{currentTimeLeft.Seconds}");
            //Fun animation
            Console.SetCursorPosition(0, bottomConsoleRow);
            Console.Write(animationString);


            animationString[currentAnimationIndex] = 'a';
            if (currentAnimationIndex == 7) { currentAnimationIndex = 0; }
            else { currentAnimationIndex++; }
            animationString[currentAnimationIndex] = 'A';
            Thread.Sleep(1000);
        }

        //While loop that waits and either gives a notification, or plays a sound when the timer is done

        //Repeat loop for break
        nextTimeFlag = (DateTime.Now).AddMinutes(5);
        bottomConsoleRow = Console.GetCursorPosition().Top;
        while (DateTime.Compare(nextTimeFlag, DateTime.Now) < 1)
        {
            currentTimeLeft = nextTimeFlag - DateTime.Now;

            //Fun animation
            Console.SetCursorPosition(0, bottomConsoleRow - 2);
            Console.Write(animationString);
            //Dislay time
            Console.SetCursorPosition(0, bottomConsoleRow - 1);
            Console.Write($"{currentTimeLeft.Minutes}:{currentTimeLeft.Seconds}");
            //Fun animation
            Console.SetCursorPosition(0, bottomConsoleRow);
            Console.Write(animationString);


            animationString[currentAnimationIndex] = 'a';
            if (currentAnimationIndex == 7) { currentAnimationIndex = 0; }
            else { currentAnimationIndex++; }
            animationString[currentAnimationIndex] = 'A';

            Thread.Sleep(1000);
        }

        //Should potentially display a small funny thing 

        Console.CursorVisible = true;
    }

    private void LAUNCH()
    {
        OpenBrowser("https://mail.one.com/mail/INBOX/1");
        OpenBrowser("https://www.dr.dk/");
        OpenBrowser("https://www.zetland.dk/");

    }








}