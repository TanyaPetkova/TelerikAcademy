namespace _07.Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    class Timer
    {
        public Timer(uint interval, TimerDelegate callBackMethod)
        {
            while (true)
            {
                callBackMethod();
                TimeSpan timeSpan = TimeSpan.FromSeconds(interval);
                Thread.Sleep(timeSpan);  
            }
        }
    }
}
