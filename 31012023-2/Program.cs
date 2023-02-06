Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых,");
Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine();

Console.WriteLine("Для решения задачи введите исходные данные: ");
Console.Write("k1 =");
double k1 =(float) Convert.ToDouble(Console.ReadLine());
Console.Write("b1 =");
double b1= (float) Convert.ToDouble(Console.ReadLine());
Console.Write("k2 =");
double k2= (float) Convert.ToDouble(Console.ReadLine());
Console.Write("b2 =");
double b2= (float) Convert.ToDouble(Console.ReadLine());
if ((k1 == k2) && (b1 == b2))
{
  Console.Write("Заданные прямые совпадают.Они имеют бесконечное множество общих точек.");
}
else if (k1==k2)
{
  Console.Write("Заданные прямые параллельные. Они не имеют точек пересечения");
}
else
{   double x , y;
    x=(b2-b1)/(k1-k2);
    y=(k1*(b2-b1))/(k1-k2)+b1;

    Console.Write($"Точка пересечения прямых имеет координаты X={x.ToString("##.000")}, Y={y.ToString("##.000")}.");
}
