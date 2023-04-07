 /*
 int numberA = new Random().Next(1, 10);
 Console.WriteLine(numberA);
 int  numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/
Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}