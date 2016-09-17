using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiringPi;
using System.Threading;
namespace MonoWiringPi
{
    class Program
    {
        //this example using pin 29 in raspberry pi 2/3 type B header
        const int LedPin = 29;
       
        static void Main(string[] args)
        {
            if (Init.WiringPiSetup() != -1)
            {
                Console.WriteLine("Init Mode to Output");
                GPIO.pinMode(LedPin, (int)GPIO.GPIOpinmode.Output);
                while (true)
                {
                    Console.WriteLine("Write to 1");
                    GPIO.digitalWrite(LedPin, 1);
                    Thread.Sleep(500);
                    GPIO.digitalWrite(LedPin, 0);
                    Console.WriteLine("Write to 0");
                    Thread.Sleep(500);
                }
            }
            else
            {
                Console.WriteLine("Init failed");
            }
        }

    }
}
