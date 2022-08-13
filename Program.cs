Console.WriteLine("Программа, которая принимает на вход массив данных. И выводит массив из существующего с элементами, длина которых меньше трех");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");


Console.WriteLine("Введите колличество элементов в массиве");
int FirstIndexNumber = Convert.ToInt32(Console.ReadLine());
int SecondIndexNumber = 0;

string[] firstArray = new string[FirstIndexNumber];
FillFirstArray(firstArray,ref SecondIndexNumber);
Console.WriteLine("Исходный массив данных:");
PrintArray(firstArray);
Console.WriteLine("-------------------------------------------------------------------");

Console.WriteLine("Колличество элементов массива, которые удовлетворяют наше условие:");
Console.WriteLine(SecondIndexNumber);
Console.WriteLine("-------------------------------------------------------------------");

string[] secondArray = new string[SecondIndexNumber];
FillCurrentArray(firstArray, secondArray);
Console.WriteLine("Искомый массив данных:");
PrintArray(secondArray);
Console.WriteLine("-------------------------------------------------------------------");

/* FillFirstArray - Метод, который заполняет исходный массив данных, ввод с клавиатуры и заодно проверяющий, удовлетворяет ли вводимый элемент массива нашему словию (array[i].Lenght <= 3)
Если элемент массива удовлетворяет условию, то длина искомого массива увеличивается на 1*/
string[] FillFirstArray(string[] array, ref int maxIndexArray)
    {
        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введи {i+1} элемент: ");
            array[i] = Console.ReadLine();
            Console.WriteLine();
            if (array[i].Length <= 3) 
            {
                maxIndexArray = maxIndexArray + 1;
            }
        }
        Console.WriteLine();
        return array;
    }
/* FillCurrentArray - Метод, перебирает элементы исходного массива, и если он (элемент) меньше или равен 3, то его значение присвается в элемент искомого массива*/
string[] FillCurrentArray(string[] firstArray, string[] secondArray)
    {
        int j = 0;
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i].Length <= 3)
            {
                secondArray[j] = firstArray[i];
                j++;
            }
        }
        return secondArray;
    }
/* PrintArray - Универсальный метод вывода в консоль одномерного массива*/
static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i ++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine();
    }
/************************************************************************************/