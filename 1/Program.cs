//Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//пример:      0, 7, 8, -2, -2 -> 2      1, -7, 567, 89, 223-> 3

void FillArray(int arg)
{
    double[] array = new double[arg];
    int count = 0;
	for (int i = 0; i < arg; i++)
	{
		Console.Write("Введите число: ");	
        array[i] = Convert.ToDouble(Console.ReadLine());
		if (array[i] > 0) count++;
    }   
	Console.WriteLine();
	Console.WriteLine($"Количество чисел больше 0: {count}");
}
Console.WriteLine("Введите количество чисел: ");
int value = Convert.ToInt32(Console.ReadLine());
FillArray(value);


