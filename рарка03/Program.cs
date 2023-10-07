/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/
int number,r,sum=0,t;
Console.Write("Введите пятизначное число: ");
number = Convert.ToInt32(Console.ReadLine());
if(number >= 10000 && number <= 99999)
{
for(t=number;number!=0;number=number/10)
{
r=number % 10;
sum=sum*10+r;
}
if(t==sum)
{
    Console.Write($"{t} true");
}
else
{
Console.Write($"{t} false");
}
} else
Console.Write("Введите пятизначное число! ");