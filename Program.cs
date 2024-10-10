// задание 1
// Создать массив из 10 случайных чисел в диапазоне от 0 до 5. 
// Сжать массив, удалив из него все 0, и заполнить освободившиеся справа
// элементы значениями -1.

// int[] array = new int[10];
// Random random = new Random();

// for (int i = 0; i < array.Length; i++){
//     array[i] = random.Next(0, 5);
// }

// Console.Write("start array: ");
// for(int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
// }

// for(int i = 0; i < array.Length; i++){
//     if(array[i] == 0){
//         array[i] = -1;
//     }
// }

// Console.Write("\n");


// Console.Write("finish array: ");
// for(int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
// }
// Console.Write("\n");





// 2. Заполнить квадратную матрицу размером N x N по спирали 
// (N - нечётное число). Число 1 ставится в центр матрицы, а затем массив
// заполняется по спирали против часовой стрелки значениями по
// возрастанию.


// int[,] array = new int[5, 5];
//  int num = 1;  // Начальное значение
//  int center = 2; // Индекс центра массива

//         // Установка начальной точки (центра массива)
//         array[center, center] = num;

//         // Заполнение по спирали
//         for (int layer = 1; layer <= center; layer++) // Проход по слоям
//         {
//             // Заполнение правого края (сверху вниз)
//             for (int i = center - layer; i <= center + layer; i++)
//             {
//                 array[i, center + layer] = num++;
//             }
//             // Заполнение нижнего края (слева направо)
//             for (int j = center + layer - 1; j >= center - layer; j--)
//             {
//                 array[center + layer, j] = num++;
//             }
//             // Заполнение левого края (снизу вверх)
//             for (int i = center + layer - 1; i >= center - layer; i--)
//             {
//                 array[i, center - layer] = num++;
//             }
//             // Заполнение верхнего края (справа налево)
//             for (int j = center - layer + 1; j <= center + layer - 1; j++)
//             {
//                 array[center - layer, j] = num++;
//             }
//         }


// for (int i = 0; i < 5; i++){
//     for(int j = 0; j < 5; j++ ){
//          Console.Write("{0, 4}", array[i, j]);
//     }
//     Console.Write("\n");

// }   



// Console.Write("\n");





// Дан двумерный массив размерностью N × М, заполненный
// случайными числами из диапазона от 0 до 100. Выполнить
// циклический сдвиг массива на заданное количество столбцов.
// Направление сдвига задаёт пользователь.

 int row = 5;
        int col = 4;
        int[,] array = new int[row, col];
        Random random = new Random();

        Console.WriteLine("Enter shift (positive for right, negative for left): ");
        string answer = Console.ReadLine();
        int shift = int.Parse(answer);

        // Заполнение массива случайными числами
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                array[i, j] = random.Next(0, 100);
            }
        }

        // Вывод исходного массива
        Console.WriteLine("Original Array:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Сдвиг массива
        int effectiveShift = (shift % col + col) % col; // Чтобы учитывать сдвиг больше чем количество столбцов

        for (int i = 0; i < row; i++)
        {
            // Создание временного массива для текущей строки
            int[] tempRow = new int[col];

            // Сдвигаем текущую строку
            for (int j = 0; j < col; j++)
            {
                tempRow[j] = array[i, (j - effectiveShift + col) % col];
            }

            // Копируем сдвинутые значения обратно в массив
            for (int j = 0; j < col; j++)
            {
                array[i, j] = tempRow[j];
            }
        }

        // Вывод сдвинутого массива
        Console.WriteLine("Shifted Array:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    