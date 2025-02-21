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
}