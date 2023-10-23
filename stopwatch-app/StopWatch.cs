using System;

namespace stopwatch_app
{
    class StopWatch
    {
        public void start()
        {
            Console.WriteLine("Would you like to start the stopwatch y/n");
            var userInput = Console.ReadLine();
            if (userInput == "y")
            {
                DateTime startTimer = DateTime.Now;
                Console.WriteLine("type stop when you would like to stop the stopwatch");
                var userStop = Console.ReadLine().ToLower();
                if (userStop == "stop")
                {
                    DateTime nowTime = DateTime.Now;
                    TimeSpan timeDiff = nowTime - startTimer;
                    Console.WriteLine(timeDiff.TotalSeconds + " seconds have passed");
                }

            }
            else
            {
                Console.WriteLine("ok goodbye");
            }


        }
    }
}
