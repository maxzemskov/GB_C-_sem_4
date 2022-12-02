Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int n = 2;
int l = a; //кладем изначальное значение в доп переменную

if (b == 0)
Console.WriteLine(1);
else
{
    while ( n <= b )
    {
        a = a * l;
        n++;
    }
Console.WriteLine(a);
}
