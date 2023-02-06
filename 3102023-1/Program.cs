Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine();

Console.Write("Введите числовой ряд (через пробел): ");
int[] positivAttay = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // строка с консоли Console.ReadLine(), метод Split() получаем из этой строки массив, в качестве разделителей-пробельные символы.
//метод Array.ConvertAll применяет ко всем элементам входного массива функцию, переданную вторым параметром (int.Parse),получается массив int
int count = 0; 

for (int i = 0; i < positivAttay.Length; i++)
{
    if (positivAttay[i] > 0)
    { 
        count++;
    } 
}
Console.WriteLine($"Из {positivAttay.Length} введенных пользователем чисел {count} положительные.");
