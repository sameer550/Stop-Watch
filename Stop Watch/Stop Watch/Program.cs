using System;

namespace Stop_Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for start");
            int st = Convert.ToInt32(Console.ReadLine());
            int hours = 0;
            int min = 0;
            int sec = 0;
            int mil = 0;
            int micro = 0;
            int nano = 0;
            if (st == 1)
            {
                for (hours = 0; hours < 60; ++hours)
                {
                    for (min = 0; min < 60; ++min)
                    {
                        for ( sec = 0; sec < 60; ++sec)
                        {
                            for ( mil = 0; mil < 1000; ++mil)
                            {
                                for ( micro = 0; micro < 1000; ++micro)
                                {
                                    for ( nano = 0; nano < 300; ++nano)
                                    {
                                        
                                        
                                    }
                                }
                            }
                            Console.Clear();
                            Console.WriteLine(hours + ":" + min + ":"+sec);
                        }
                    }
                }
                
            }
          
            
        }
    }
}
