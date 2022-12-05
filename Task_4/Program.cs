Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
Console.Write("Введите элемент массива: ");
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число K");
int k = Convert.ToInt32(Console.ReadLine());

if (k < 0)
{
	k = - k;
	k = k % n;
}
else
{
	k = k % n;
	k = n - k;
}
for (int i = k; i < n; i++)
Console.Write($"[{array[i]}] ");
for (int i = 0; i < k; i++)
Console.Write($"[{array[i]}] ");