List<int> numbers = new List<int>();
Random rndNumbers = new Random();

for (int i = 0; i < 10; i++)
{
    numbers.Add(rndNumbers.Next(1,21));
}

foreach (var it in numbers)
{
    System.Console.Write(it+ " ");
}
