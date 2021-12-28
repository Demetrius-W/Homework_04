using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
                Console.WriteLine("Введите номер необходимой задачи, или 0, чтобы завершить: ");
                int item = int.Parse(Console.ReadLine());
                switch (item)
                { 
                    case 0:
#region Stop
#endregion
                    break;

                    case 1:
#region Exercise_1
                    Console.Clear();
                    Console.Write("Задача №1.\nВведите число строк матрицы: ");
                    int line = Int32.Parse(Console.ReadLine());
                    Console.Write("Введите чило столбцов матрицы: ");
                    int column = Int32.Parse(Console.ReadLine());
                    int sum = 0;
            
                    int[,] matrix = new int [line, column];
            
                    Random compiler = new Random ();
                                    
                    for (int i = 0; i < line; i++)
			        {
                        for (int j = 0; j < column; j++)                       
			            {
                            matrix [i, j] = compiler.Next(10);                    
                            Console.Write($"{matrix[i, j]} ");                 
                            sum += matrix [i, j];  
			            }                        
                        Console.WriteLine();                   
			        }  
                    Console.Write($"\nСумма элементов матрицы: {sum}");
                    Console.ReadLine();
#endregion
                    continue;

                    case 2:
#region Exercise_2
                    Console.Clear();
                    Console.Write("Задача №2.\nВедите длинну последовательности: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] chain = new int [size];                         
                    
                        for (int i = 0; i < chain.Length; i++) 
                        { 
                            Console.WriteLine($"Введите {i+1} число:");
                            chain[i] = int.Parse(Console.ReadLine());
                        }
                        
                        Console.WriteLine("Последовательность чисел:");
                        for (int i = 0; i < chain.Length; i++)
			            {
                            Console.Write($"{chain[i]} ");
			            }

                        int MinValue = chain[0];
                        for (int i = 0; i < chain.Length; i++)
			            {
                            if (MinValue > chain[i])
	                        {
                                MinValue = chain[i];
	                        }
                            
			            }
                        Console.WriteLine($"\n\nМинимальное число: {MinValue}");
                    Console.ReadLine();
#endregion
                    continue;

                    case 3:
#region Exerxise_3
                    Console.Clear();
                    Console.Write("Задача №3.\nВведите максимальное число диапазона. От 0 до ");
                    int max = Int32.Parse(Console.ReadLine())+1;

                    int[] row = new int [max];
                                                        
                    for (int i = 0; i < max; i++)
			        {     
                       row[i] = i;                    
                       Console.Write($"{row[i]} ");                 
                    }
                    Console.WriteLine();   
                    Random fill = new Random();
                    int win = fill.Next(max);
                    Console.WriteLine($"\nИспытайте удачу! Попробуйте угадать число в заданном диапазоне от 0 до {max-1}.");

                    while (true)
                    {                          
                        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
	                    {
                            Console.WriteLine($"Загаданное число: {win}!");
                        break;
                        }
                        else
	                    {
                            Console.Write("Введите число: ");                        
                            int n = Convert.ToInt32(Console.ReadLine());
                        
                            if (n > win)
                            { 
                                Console.WriteLine($"К сожалению, Вы ошиблись.\nЧисло: {n} больше загаданного...");
                            continue;
                            }  
                            else if (n < win)
	                        {
                                Console.WriteLine($"К сожалению, Вы ошиблись.\nЧисло: {n} меньше загаданного...");
                            continue;
	                        }	      
                            else 
                            {
                                Console.WriteLine($"Вы молодец! Загаданное число: {win}!");
                            break;
                            }                     
	                    }                        
                        
                    }                         
                    Console.ReadLine();
#endregion
                    continue;

                    default:
                    Console.Clear();
                    Console.WriteLine("Вы ввели неверный номер задачи.");
                    continue;
                }
            break;
            }
        }
    }
}
