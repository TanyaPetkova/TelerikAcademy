namespace _08.Events
{
    public class Test
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber(publisher);
            publisher.Timer(2);            
        }
    }
}
