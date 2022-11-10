using System;
using System.Collections.Generic;

namespace ClassesHWExample
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray(30);

            //int[] arrMajor = new int[] { 1, 3, 2, 5, 3, 6, 7, 3, 3, 4, 3, 3, 3 };
            //RandArrayMojority(10);

            MaxMult(10);


            var arrPixel = new int[][] {
                new int[] {7,4,0,1},
                new int[] {5,6,2,2},
                new int[]{6,10,7,8},
                new int[]{1,4,2,0} 
            };
           
            BoxPixel(arrPixel);

            Matrix(5);
        } 

        // Создает рандомный массив значений и считает в какой половине больше значений
        public static void RandomArray(int size)
        {
            Console.WriteLine("_________Random Array___________");
            Random random = new Random();
            int a = 0, b = 0;
            int[] array = new int[size];
            foreach (int i in array)
            {
                array[i] = random.Next(1, size + 11);
                Console.Write($"{array[i]} ");
                if (array[i] < size / 2)
                    a++;
                else
                    b++;
            }
            Console.WriteLine($"\nЧисел в диапозоне от нуля до {size / 2} = {a} , остальных {b}");
        }
        // Создает рандомный массив значений и ищет гланвый элемент. Главный элемент повторятеся больше, чем size/2
        /*static void RandArrayMojority(int size)
        {
        Console.WriteLine("_________Rand Array Mojority___________");
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i< size; i++)
            {
                array[i] = random.Next(1, 4);
                Console.Write($"{array[i]} ");
            }
           

            var occurancies = new Dictionary<int, int>();

            int? result = null;
            for (int j = 0; j < array.Length; j++)
            {
                if (occurancies.ContainsKey(array[j]))
                {
                    occurancies[array[j]]++;
                }
                else
                {
                    occurancies.Add(array[j], 1);
                }
                if (occurancies[array[j]] > array.Length / 2)
                {
                    result = array[j];
                    break;
                }
            }
            if (result.HasValue)
                Console.WriteLine($"Major element is {result}");
            else
                Console.WriteLine("There is no majority element");
        }*/


        // пара чисел с наибольшм произведением 

        static void MaxMult(int size)
        {
            Console.WriteLine("_________Max mult___________");
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, size+10);
                Console.Write($"{array[i]} ");
            }


            int temp = array[0] * array[1];
            int n1 = 0, n2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] * array[j] > temp)
                    {
                        temp = array[i] * array[j];
                        n1 = array[i];
                        n2 = array[j];
                    }
                }
            }
            Console.WriteLine($"Pair of numbers {n1}, {n2}");
        }


        // Считает среднее значение в квадрате размером 3x3
        static void BoxPixel(int[][] image)
        {

            Console.WriteLine("_________Box Pixel___________");
            int x = image[0].Length - 2;
            int y = image.Length - 2;
            int[][] b = new int[y][];

            for (int i = 0; i < y; i++)
            {
                b[i] = new int[x];
                for (int j = 0; j < x; j++)
                {
                    b[i][j] = image[i][j] + image[i][j + 1] + image[i][j + 2] +
                              image[i + 1][j] + image[i + 1][j + 1] + image[i + 1][j + 2] +
                              image[i + 2][j] + image[i + 2][j + 1] + image[i + 2][j + 2];
                    Console.WriteLine (b[i][j] /= 9);
                }
            }
        }

        // исходный массив, сумму элементов главной диагонали и преобразованный массив (элемент деленный на сумму гл.диагонали).
        static void Matrix(int N) {

            Console.WriteLine("_________Matrix___________");
            int M = N;
            int[,] a = new int[N, M];

            Random random = new Random();
            int rand;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    rand = random.Next(0, 100);
                    a[i, j] = rand;
                }
            }
            Console.WriteLine("Исходная матрица:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)

                    Console.Write(a[i, j] + " ");

                Console.WriteLine();
            }
            float sum = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; i < M; i++)
                {
                    sum += a[i, j];
                }
            }
            Console.WriteLine("Сумма элементов главной диагонали: " + sum);
      
            Console.WriteLine("\nПреобразованный массив: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    Console.Write(a[i, j] / sum + " ");
                Console.WriteLine();
            }
        }
    }
}
        
