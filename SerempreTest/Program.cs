// See https://aka.ms/new-console-template for more information


using SerempreTest.Utils;

var response = await NetUtils.GetUserListFromSourceAsync();
var orderedArray = response.OrderBy(user => user.kpi.speed);

Console.WriteLine("Array ordenado por speed: ");
foreach (var item in orderedArray)
{
    Console.WriteLine("Id: "+item.id);
    Console.WriteLine("Nombre: " + item.name);
    Console.WriteLine("KPI - speed: " + item.kpi.speed);
    Console.WriteLine("KPI - level: " + item.kpi.level);
}
