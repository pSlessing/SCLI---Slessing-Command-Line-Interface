using System.Runtime.InteropServices;
using System.Text;

partial class CliHandler
{
    private void ConwayGame()
    {

        //Lock game window, measure and lock window
        int windowWidth = Console.WindowWidth;
        int windowHeight = Console.WindowHeight;

        int[,] currentState = new int[windowWidth, windowHeight];
        int[,] tempState = new int[windowWidth, windowHeight]; ;


        Console.Clear();

        Console.SetCursorPosition(0, 0);
        Console.BackgroundColor = ConsoleColor.White;

        //Setup variables needed
        int cursorX = 0;
        int cursorY = 0;
        bool preparingBoard = true;

        //DrawBoard
        for (int x = 0; x < windowWidth; x++)
        {
            for (int y = 0; y < windowHeight; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
            }
        }

        Console.SetCursorPosition(0, 0);
        //Allow user to mark certain squares with arrow keys, as white, use m to mark

        // Main game loop
        while (preparingBoard)
        {
            // Check for key press
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); // true means don't display the key


                // Handle key press
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (cursorY > 0) cursorY--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (cursorY < windowHeight - 1) cursorY++;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (cursorX > 0) cursorX--;
                        break;

                    case ConsoleKey.RightArrow:
                        if (cursorX < windowWidth - 1) cursorX++;
                        break;

                    case ConsoleKey.M:
                        HighlightPosition(cursorX, cursorY);
                        currentState[cursorX, cursorY] = 1;
                        tempState[cursorX, cursorY] = 1;
                        break;

                    case ConsoleKey.Enter:
                        preparingBoard = false;
                        break;
                }
            }
            Thread.Sleep(50);
        }

        bool runningConway = true;
        while (runningConway)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:

                        for (int x = 1; x < windowWidth - 1; x++)
                        {
                            for (int y = 1; y < windowHeight - 1; y++)
                            {
                                int currentLiveNeighbours =
                                    tempState[x + 1, y] + tempState[x - 1, y] +
                                    tempState[x, y + 1] + tempState[x, y - 1] +
                                    tempState[x + 1, y + 1] + tempState[x - 1, y - 1] +
                                    tempState[x + 1, y - 1] + tempState[x - 1, y + 1];

                                switch (tempState[x, y])
                                {
                                    case 1:
                                        if (currentLiveNeighbours < 2)
                                        { currentState[x, y] = 0; break;}
                                        else if (currentLiveNeighbours > 3)
                                        { currentState[x, y] = 0; break;}
                                        else 
                                        { currentState[x, y] = 1; break;}
                                        

                                    case 0:
                                        if (currentLiveNeighbours == 3) currentState[x, y] = 1;
                                        break;
                                }
                            }
                        }

                        for (int x = 0; x < windowWidth; x++)
                        {
                            for (int y = 0; y < windowHeight; y++)
                            {
                                tempState[x, y] = currentState[x, y];
                                if (currentState[x,y] == 1) HighlightPosition(x, y);
                                else DelightPosition(x, y);
                            }
                        }



                        continue;


                    case ConsoleKey.Escape:
                        runningConway = false;
                        break;
                }
            }
        }


    }

    void HighlightPosition(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(" ");
        Console.ResetColor();
    }

    void DelightPosition(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write(" ");
        Console.ResetColor();
    }
}