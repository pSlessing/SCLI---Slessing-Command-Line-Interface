using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

partial class CliHandler
{
    // P/Invoke method to send a media key press
    [DllImport("user32.dll", SetLastError = true)]
    private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

    private void SendPlayPauseKey()
    {
        const byte VK_MEDIA_PLAY_PAUSE = 0xB3; // Virtual-Key code for Play/Pause
        keybd_event(VK_MEDIA_PLAY_PAUSE, 0, 0, 0);
        keybd_event(VK_MEDIA_PLAY_PAUSE, 0, 2, 0); // Key up
    }

    private void OpenBrowser(string url)
    {
        try
        {
            if (OperatingSystem.IsWindows())
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            else if (OperatingSystem.IsMacOS())
            {
                Process.Start("open", url);
            }
            else if (OperatingSystem.IsLinux())
            {
                Process.Start("xdg-open", url);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open browser: {ex.Message}");
        }
    }

    private void PrintLogo()
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