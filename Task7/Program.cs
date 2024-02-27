List<string> list = new List<string>{"Hello","World","!"};

System.Console.WriteLine("List befor deleting element:");
foreach (var it in list)
{
    System.Console.Write(it +" ");
}
System.Console.WriteLine();
System.Console.WriteLine("List after deleting element:");

list.Remove("Hello");
list.RemoveAll(e=> e.Length <= 2);
foreach (var it in list)
{
    System.Console.WriteLine(it);
}