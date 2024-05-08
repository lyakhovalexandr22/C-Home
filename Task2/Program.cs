/*Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
*/

    {
        // Вводим значения m и n
        int m = 2;
        int n = 1;

        // Вычисляем значение функции Аккермана и выводим результат
        int result = AckerFunction(m, n);
        Console.WriteLine($"Ack({m}, {n}) = {result}");
    }

     int AckerFunction(int m, int n)
    {
        // Базовый случай: если m равно 0, возвращаем n + 1
        if (m == 0)
            return n + 1;
        
        // Если m > 0 и n равно 0, вызываем функцию для m-1 и 1
        if (n == 0)
            return AckerFunction(m - 1, 1);

        // Иначе вызываем функцию для m-1 и результат функции для m и n-1
        return AckerFunction(m - 1, AckerFunction(m, n - 1));
    }

