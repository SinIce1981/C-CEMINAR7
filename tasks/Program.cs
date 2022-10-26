
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4

// void Zadacha46()
// {
//     Random random = new Random();
//     int rows = random.Next(4, 8);
//     int columns = random.Next(4, 8);
//     Console.WriteLine($"Массив размера {rows}*{columns}");
//     int[,] numbers = new int[rows, columns];

//    FillArray(numbers);
//    PrintArray(numbers);

// }

// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = random.Next(-10, 11);
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }
// Zadacha46();

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по
//  формуле: A = i+j. Выведите полученный массив на экран

// void Zadacha48()
// {
// Random random = new Random();
//     int rows = random.Next(4, 8);
//     int columns = random.Next(4, 8);
//     Console.WriteLine($"Массив размера {rows}*{columns}");
//     int[,] numbers = new int[rows, columns];

//    FillArray(numbers);
//    PrintArray(numbers);

// }

// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = i+j;
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }

// Zadacha48();


// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


// void Zadacha49()
// {

//     Random random = new Random();
//     int rows = random.Next(4, 8);
//     int columns = random.Next(4, 8);
//     Console.WriteLine($"Массив размера {rows}*{columns}");
//     int[,] numbers = new int[rows, columns];

//      FillArray(numbers);
//     PrintArray(numbers);
//     for (int i = 0; i < rows; i +=2)
//     {
//         for (int j = 0; j < columns; j +=2)
//         {
//             numbers[i, j] = numbers[i, j]*numbers[i, j] ;
//         }
//     }
//     Console.WriteLine();
//     PrintArray(numbers);
// }

// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = random.Next(-10, 11); ;
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }

// Zadacha49();

// void Zadacha51()
// {

//     Random random = new Random();
//     int rows = random.Next(4, 4);
//     int columns = rows;
//     Console.WriteLine($"Массив размера {rows}*{columns}");
//     int[,] numbers = new int[rows, columns];
//     int sum = 0;

//     FillArray(numbers);
//     PrintArray(numbers);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (i == j)
//             {
//                 sum = sum + numbers[i, j];
//             }
//         }
//     }
//     Console.WriteLine(sum);

// }

// void FillArray(int[,] numbers)
// {
//     Random random = new Random();
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[i, j] = random.Next(-10, 11); ;
//         }
//     }
// }
// void PrintArray(int[,] numbers)
// {
//     int rows = numbers.GetLength(0);
//     int columns = numbers.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(numbers[i, j] + "\t");
//         }
//         Console.WriteLine();

//     }
// }

// Zadacha51();

// Дан двумерный массив из двух строк и двадцати двух столбцов. В его пер-
// вой строке записано количество мячей, забитых футбольной командой в той
// или иной игре, во второй — количество пропущенных мячей в этой же игре.
// а) Для каждой проведенной игры напечатать словесный результат: "выиг-
// рыш", "ничья" или "проигрыш".
// Денис Сапрыкин: а) Для каждой проведенной игры напечатать словесный результат: "выиг-
// рыш", "ничья" или "проигрыш".
// б) Определить количество выигрышей данной команды.
// в) Определить количество выигрышей и количество проигрышей данной
// команды.
// г) Определить количество выигрышей, количество ничьих и количество про-
// игрышей данной команды.
// д) Определить, в скольких играх разность забитых и пропущенных мячей
// была большей или равной трем.
// е) Определить общее число очков, набранных командой (за выигрыш даются
// 3 очка, за ничью — 1, за проигрыш — 0).

void Zadacha1()
{


    Random random = new Random();
    int rows = 2;
    int columns = 10;
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];


    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    int win = 0;
    int lose = 0;
    int draw = 0;
    int points =0;
    for (int i = 0; i < columns; i++)
    {
        if (numbers[0, i] > numbers[1, i])
        {
        win++;
            Console.WriteLine($"win {numbers[0, i]}:{numbers[1, i]}");
        }
        if (numbers[0, i] < numbers[1, i])
       
        {
            lose++;
            Console.WriteLine($"lose {numbers[0, i]}:{numbers[1, i]}");
        }
        if (numbers[0, i] == numbers[1, i])
      
        {
              draw++;
            Console.WriteLine($"draw {numbers[0, i]}:{numbers[1, i]}");
        }
    }

    Console.WriteLine("Количество побед :" + win);
    Console.WriteLine("Количество поражений :" + lose);
    Console.WriteLine("Количество ничьих :" + draw);
    points = win*3+draw;
    Console.WriteLine($"Количество очков команды {points}");



}

void FillArray(int[,] numbers, int minBalls = 0, int maxBalls = 1)
{
    maxBalls++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(minBalls, maxBalls); ;
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();

    }
}

Zadacha1();