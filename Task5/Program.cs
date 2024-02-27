List<int> numbers = new List<int>{1,2,3,4,5};

List<int> evenNumbers = numbers.FindAll(e=> e % 2==0);
Console.Write("The filtered numbers are: ");
foreach (var number in evenNumbers)
{
    System.Console.Write(number +" ");
}