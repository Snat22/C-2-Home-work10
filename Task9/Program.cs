List<string> spisok = new List<string>{"Tom","Mike","Irina","Mumtoz"};
foreach (var item in spisok)
{
    System.Console.Write(item+ " ");
}
System.Console.WriteLine();
System.Console.WriteLine("-------------------------------------------------------");
spisok.Add("Mario");

foreach (var item in spisok)
{
    System.Console.Write(item+ " ");
}
System.Console.WriteLine();
System.Console.WriteLine("-------------------------------------------------------");

spisok.AddRange(new List<string>(){"Sam","Baloteli"});

foreach (var item in spisok)
{
    System.Console.Write(item+ " ");
}
System.Console.WriteLine();
System.Console.WriteLine("-------------------------------------------------------");

spisok.Insert(0,"NolumIndex");

foreach (var item in spisok)
{
    System.Console.Write(item+ " ");
}
System.Console.WriteLine();
System.Console.WriteLine("-------------------------------------------------------");

spisok.InsertRange(1, new List<string>(){"Abos","Garmi"});

foreach (var item in spisok)
{
    System.Console.Write(item+ " ");
}
System.Console.WriteLine();
System.Console.WriteLine("-------------------------------------------------------");
