List<string> spisok = new List<string>{"Tom","Mike","Irina","Mumtoz"};
var find1 =  spisok.Find(e=> e.Length < 4);
System.Console.WriteLine(find1);
spisok.FindAll(e=> e.Length > 5);
foreach (var it in spisok.FindAll(e=> e.Length > 5))
{
    System.Console.WriteLine(it);
}