using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Events
{

    public class Clock
    {
        private Timer timer;

        
        public event EventHandler OnTick;

        public Clock()
        {
            timer = new Timer(1000); 
            timer.Elapsed += TimerElapsed; 
            timer.AutoReset = true; 
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            OnTick?.Invoke(this, EventArgs.Empty);
        }
    }

    
    public class Display
    {
        public void Subscribe(Clock clock)
        {
            clock.OnTick += ShowTime;
        }

        private void ShowTime(object sender, EventArgs e)
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Display display = new Display();

            display.Subscribe(clock);

            
            clock.Start();

            Console.WriteLine("Press Enter to stop the clock...");
            Console.ReadLine();  
            clock.Stop();
        }
    }
}
