Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int counter = Convert.ToString(n).Length;
int i = 0;
int sum = 0;

while (i < counter)
{
sum = sum + n % 10;
n = n / 10;
i++;
}

	Console.WriteLine($"Сумма цифр в числе N = {sum}");

