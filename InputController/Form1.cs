using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputController
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenCoreKeeper()
        {
            SendKeys.SendWait("^{ESC}"); // Ctrl+Esc is an alternative to the Windows key
            System.Threading.Thread.Sleep(500);

            // Simulate typing 'Google Chrome' and pressing Enter
            SendKeys.SendWait("Core Keeper");
            System.Threading.Thread.Sleep(500);
            SendKeys.SendWait("{ENTER}");

            System.Threading.Thread.Sleep(60000);
            SendKeys.SendWait("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            SendKeys.SendWait(" ");
            System.Threading.Thread.Sleep(2000);
            SendKeys.SendWait(" ");
            System.Threading.Thread.Sleep(2000);
            SendKeys.SendWait(" ");
            System.Threading.Thread.Sleep(2000);
            SendKeys.SendWait(" ");

        }
        private async void GameMoveLoop()
        {
            bool gameOpen = true;
            Random rnd = new Random(); // Create a single Random instance

            while (gameOpen)
            {
                await SendRandomKeyStrokes("W", rnd);
                await SendRandomKeyStrokes("A", rnd);
                await SendRandomKeyStrokes("S", rnd);
                await SendRandomKeyStrokes("D", rnd);

                // Check for a condition to stop the loop, or implement a way to set gameOpen to false
            }
        }

        private void PerformLeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); // Mouse left button down
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);   // Mouse left button up
        }

        private async Task SendRandomKeyStrokes(string key, Random rnd)
        {
            int randomNumber = rnd.Next(1, 11);
            for (int i = 0; i < randomNumber; i++)
            {
                SendKeys.SendWait(key);
                PerformLeftClick();
                await Task.Delay(500); // Use Task.Delay for asynchronous wait
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenCoreKeeper();
            System.Threading.Thread.Sleep(10000);
            GameMoveLoop();
        }
    }
}
