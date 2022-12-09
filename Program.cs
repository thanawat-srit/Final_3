class Program
{
    static Queue<string> queue = new Queue<string>();
    static void Main(string[] args)
    {
        Input();
        ShowFile();
    }
    static void Input()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Exit")
            {
                break;
            }
            else
            {
                if (queue.GetLength() < 3)
                {
                    queue.Push(input);
                }
                else
                {
                    queue.Pop();
                    queue.Push(input);
                }
            }
        }
    }
    static void ShowFile()
    {
        for (int i = 0; i < queue.GetLength(); i++)
        {
            Console.WriteLine(queue.Get(i));
        }
    }
}
