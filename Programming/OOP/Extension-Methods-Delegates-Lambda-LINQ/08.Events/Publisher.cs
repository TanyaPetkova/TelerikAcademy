namespace _08.Events
{
    using System;
    using System.Threading;

    public class Publisher : EventArgs
    {
        public event EventHandler RaiseEvent;

        public void Timer(uint interval)
        {
            while (true)
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(interval);
                Thread.Sleep(timeSpan);
                OnRaiseEvent();
            }
        }

        protected virtual void OnRaiseEvent()
        {
            EventHandler handler = this.RaiseEvent;

            if (handler != null)
            {
                handler(this, null);
            }
        }
    }
}
