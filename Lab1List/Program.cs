using System;
using System.Collections.Generic;


public class Program
{
    private double element;
    private static void Main(string[] args)
    {
        int Quantity;
        Console.WriteLine("Введите длину списка(N)");
        try {
             Quantity = Convert.ToInt32(Console.ReadLine());
        }

        catch
        {
            Console.WriteLine("Введите еще раз ЦЕЛОЕ число");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }

        finally
        {

            Console.WriteLine("Сейчас будет список: "); // Можно вырезать, но для удобства

        }

        // Длина списка
        List<double> list = new List<double>(); // Список элементов типа double- действительные числа с большим диапозоном
       

        // Ввод элементов в список, используя цикл for (создаем переменную i = 0)
        // Пока i < Длины списка выполняй, и прибавляй i на 1
        //      Заполняем список с помощью локальной переменной
        //  

        for (int i = 0; i < Quantity; i++)
        {
            Console.WriteLine($"Введите элемент {i}");
            double el = Convert.ToDouble(Console.ReadLine());
            list.Insert(i, el);
        }

        //Само задание  Задание 1: составить программу, создающую список S и выводящую его после
        // некоторой обработки.
        // Вариант 4.S - цепочка действительных чисел. Удалить четные элементы списка и
        // перемножить все ненулевые нечетные.
        double j = 1; // Переменная для счета
        
        // В нашем списке удаляем лишние четные(ЦЕЛОЕ ЧИСЛО, которое при делении на 2 дает 0) элементы по индексу, индекс смещается, поэтому проверим элементы с прошлого
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 == 0)
            {
                list.RemoveAt(i);
                i = i - 1;
            }

        }
        // В нашем списке перемножаем нечетные
        for (int i = 0; i < list.Count; i++)
        {
            
            if (list[i] != 0 & list[i] % 2 != 0)
            {
                j = j * list[i];
            }
        }


        Console.WriteLine("Вывод Массива");

        for (int i = 0; i < list.Count; i++)
        {
           Console.Write($"элемент {i}: {list[i]}, ");
        }

        Console.WriteLine($"Длина списка {list.Count}");
        Console.WriteLine($"Произведение всех ненулевых элементов списка {j}");
    }
}