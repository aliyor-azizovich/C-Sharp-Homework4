int[] arr = new int[10]; // создаем массив из 10 элементов
Random rand = new Random(); // создаем объект класса Random

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 10); // заполняем элементы массива случайными числами
}

// преобразуем массив в строку в виде массива и выводим его на консоль
string arrStr = "[" + string.Join(", ", arr) + "]";

// Выводим на экран массив
Console.WriteLine(arrStr); 


int sum = 0; // Объявляем переменную для хранения суммы


for (int x = 1; x < arr.Length; x+=2)
{
       sum += arr[x];    // добавляем значение элемента с нечетным индексом к сумме
         

}

Console.WriteLine(sum); 