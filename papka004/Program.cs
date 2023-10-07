принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
for (int i = 1; i <= number; i++)
{
    Console.WriteLine( Math.Pow(i, 3)+ "");
}

