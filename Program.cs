// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.Write("Ввведите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter > 4 || quarter < 1) Console.WriteLine("Неверный номер четверти");

else if (quarter == 1) Console.WriteLine("Диапазон координат: Х(0;∞),Y(0;∞) ");

else if (quarter == 2) Console.WriteLine("Диапазон координат: Х(0;∞),Y(0;-∞) ");

else if (quarter == 3) Console.WriteLine("Диапазон координат: Х(0;-∞),Y(0;-∞) ");

else if (quarter == 4) Console.WriteLine("Диапазон координат: Х(0;-∞),Y(0;∞) ");

// Символ бесконечности отображается в консоли как `?`