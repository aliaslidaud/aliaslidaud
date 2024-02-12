namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> vagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());

            string comand = Console.ReadLine();
            while (comand != "end")
            {
                string[] nextAction = comand.Split();
                if (nextAction.Length == 1)
                {
                    int passengers = int.Parse(nextAction[0]);
                    for (int i = 0; i < vagons.Count; i++)
                    {
                        if ((capacity - vagons[i]) < passengers)
                        {
                            continue;
                        }
                        else
                        {
                            vagons[i] += passengers;
                            break;
                        }
                    }
                }
                else
                {
                    int vagonsAdding = int.Parse(nextAction[1]);
                    vagons.Add(vagonsAdding);
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", vagons));
        }
    }
}
