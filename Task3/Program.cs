/*Задайте произвольный массив. Выведете его элементы, начиная с конца.
 Использовать рекурсию, не использовать циклы.
*/

       // Произвольный массив
        int[] array = { 2, 4, 7, 9, 6, 1, 9, 0 };
    {
        // Выводим элементы массива, начиная с конца
        PrintArrayReversed(array, array.Length - 1);
    }

    void PrintArrayReversed(int[] array, int index)
    {
         
        if (index < 0)
            return;

        // Выводим текущий элемент массива
        Console.Write(array[index] + " ");

        // Рекурсивно вызываем функцию для предыдущего элемента
        PrintArrayReversed(array, index - 1);
    }

