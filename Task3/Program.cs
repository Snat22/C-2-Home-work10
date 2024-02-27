List<DateTime> dates = new List<DateTime>{
    new DateTime(2020,10,1),
     new DateTime(2022,8,15),
      new DateTime(2021,4,28),
};
Console.WriteLine("The sorted dates are:");
dates.Sort();
foreach (var date in dates)
{
    System.Console.WriteLine(date.ToShortDateString());
}