namespace StackAndQueueProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(70);
            queue.Enqueue(30);
            queue.Display();
            queue.Dequeue();
            queue.Display();
        }
    }
}
