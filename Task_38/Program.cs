double[] arr = new double[10]; // создаем массив из 10 элементов
Random rand = new Random(); // создаем объект класса Random

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round(rand.NextDouble() * 10, 2); // заполняем элементы массива случайными числами от нуля до десятки и округляем значения
}

// преобразуем массив в строку в виде массива и выводим его на консоль
string arrStr = "[" + string.Join(", ", arr) + "]";

// Выводим на экран массив
Console.WriteLine(arrStr); 

int z = 0;
// находим максимум
double max = arr[z];
for (int x = 1; x < arr.Length; x++)
    {
        if (max < arr[x])
        {
            max = arr[x];
        }
        
    }
// находим минимум
double min = arr[z];
for (int x = 1; x < arr.Length; x++)
    {
        if (min > arr[x])
        {
            min = arr[x];
        }
        
    }
// выводим оба числа
Console.WriteLine(max + "," + min);
// находим разность и округляем значение
double result  = Math.Round(max - min, 2);
// выводим результат
Console.WriteLine(result);