Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());


if (n >= 100)
    Console.WriteLine($" {n%10}");
else
    Console.Write($" Третьей цифры нет");
 

