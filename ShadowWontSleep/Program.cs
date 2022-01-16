using System;
using System.Threading;

namespace ShadowWontSleep
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool wasPreviousMoveLeft = true;

            Console.WriteLine("No Shadow, you won't sleep while im awake");

            while (true)
            {
                int moveXY = wasPreviousMoveLeft ? 10 : -10;
                Imports.mouse_event(Imports.MouseEventFlags.MOVE, moveXY, moveXY, 0, 0);
                wasPreviousMoveLeft = !wasPreviousMoveLeft;
                Console.WriteLine("Wake Up!");
                Thread.Sleep(1000);
            }

        }
    }
}
