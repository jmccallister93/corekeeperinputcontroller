using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // For DLL import


namespace InputController
{
   

    internal static class Program
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // Constants and helper methods go here
        // Example: Key codes and mouse event constants
        const byte VK_LWIN = 0x5B;
        const byte VK_RETURN = 0x0D;
        const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        const uint MOUSEEVENTF_LEFTUP = 0x04;

        static void PressKey(byte keyCode, bool up)
        {
            const uint KEYEVENTF_EXTENDEDKEY = 0x1;
            const uint KEYEVENTF_KEYUP = 0x2;
            uint flags = KEYEVENTF_EXTENDEDKEY;
            if (up)
                flags |= KEYEVENTF_KEYUP;
            keybd_event(keyCode, 0, flags, UIntPtr.Zero);
        }

        static void ClickMouse()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        static void OpenGoogleChrome()
        {
            // Simulate pressing the Windows key
            PressKey(VK_LWIN, false);
            PressKey(VK_LWIN, true);

            // Wait a bit for the start menu to open
            System.Threading.Thread.Sleep(500);

            // Simulate typing 'Google Chrome' and pressing Enter
            SendKeys.SendWait("Google Chrome");
            System.Threading.Thread.Sleep(500);
            PressKey(VK_RETURN, false);
            PressKey(VK_RETURN, true);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
