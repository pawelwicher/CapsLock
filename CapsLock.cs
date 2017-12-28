using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace CapsLock
{
    static class Program
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        static void Main()
        {
            while (true)
            {
                keybd_event(0x14, 0, 0, 0);
                keybd_event(0x14, 0, 2, 0);
                Thread.Sleep(30000);
            }        
        }
    }
}
