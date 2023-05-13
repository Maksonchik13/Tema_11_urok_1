int sum = 0;
int count1 = 0;
int count2= 0;
int max=Int32.MinValue;
int min=Int32.MaxValue;
try
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("Введите число ");
        int n =int .Parse(Console.ReadLine());
        if (n < min) min = n;
        if (n > max) max = n;
        sum += n;
        if (n > 10) { count1++; }
        else count2++;
    }
}
catch 
{
    Console.WriteLine("ОШИБКА");
}
Console.WriteLine($"сумма всех чисел = {sum}");
Console.WriteLine($"колисество чисел больше 10 = {count1}");
Console.WriteLine($"колисество чисел меньше 10 = {count2}");
Console.WriteLine($"среднее арифметическое всех чисел = {((double)sum/10):f2}");
Console.WriteLine($"Максимальное число = {max} , минимальное число = {min}");