using System;

namespace Lesson004
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountPars = 1;
            string[] Denuntiatio = new string[]
            {
                "Вывести несколько полных имён",
                "Телефонный справочник",
                "Обращение строки",
                "Морской бой",
                "Смещение элементов массива"
            };
            //Console.WriteLine(System.Text.Encoding.Default.HeaderName);
            //Цикл-обработчик каждого задания
            for (int i = 0; i < CountPars; ++i)
            {
                //Вывод части и названия задания
                Console.WriteLine($"Часть {i + 1}: {Denuntiatio[i]}");

                switch (i)
                {
                    case 0:
                        ShowFIO($"Часть {i + 1}: {Denuntiatio[i]}");
                        break;
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                }
                if (i == 4)
                {
                    

                    Console.WriteLine();
                    Console.WriteLine("Все части пройдены");
                    Console.WriteLine("Для выхода нажмите любую клавишу");
                    Console.ReadKey();

                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Для перехода к следующей части нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ShowFIO(string Ad)
        {
            int CountFullNames = 4;
            string[] SomeString = { "", "", "" };
            string[] Alert = { "Имя", "Фамилию", "Отчество" };
            string[] Total = new string [CountFullNames];

            for (int i = 0; i < CountFullNames; ++i)
            {
                if( i > 0)
                {
                    Console.WriteLine(Ad);
                }
                
                for (int j = 0; j < Alert.Length; ++j)
                {
                    Console.WriteLine($"Введите {Alert[j]}");
                    SomeString[j] = Console.ReadLine();                    
                }
                Total[i] = GetFullName(SomeString[0], SomeString[1], SomeString[2]);

                Console.Clear();
            }

            for (int i = 0; i < CountFullNames; ++i)
            {
                Console.WriteLine(Total[i]);
            }
        }
        static string GetFullName(string FirstName, string LastName, string Patronymic)
        {
            char Spacer = ' ';
            string Fuller = FirstName + Spacer + LastName + Spacer + Patronymic;
            return Fuller;
        }
    }
}
