using System;

namespace Lesson004
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountPars = 4;
            string[] Denuntiatio = new string[]
            {
                "Вывести несколько полных имён",
                "Сумма всех чисел в строке",
                "Обращение строки",
                "Вычисление числа Фибоначчи"
            };
            //Console.WriteLine(System.Text.Encoding.Default.HeaderName);
            //Цикл-обработчик каждого задания
            for (int i = 3; i < CountPars; ++i)
            {
                //Вывод части и названия задания
                Console.WriteLine($"Часть {i + 1}: {Denuntiatio[i]}");

                switch (i)
                {
                    case 0:
                        ShowFIO($"Часть {i + 1}: {Denuntiatio[i]}");
                        break;
                    case 1:
                        Summer();
                        break;
                    case 2:
                        
                        break;
                }
                if (i == 3)
                {
                   CaloFobo(); 

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

        static void Summer()
        {
            Console.WriteLine("Введите числа через пробел для подсчёта их суммы");
            string SomeString = Console.ReadLine();

            Console.WriteLine(GetSumme(SomeString));
        }
        static int GetSumme(string SomeString)
        {
            int Total = 0;
            string Alpha = "0123456789";
            string ReponoFabrica = "";

            //Ищем числовые символы и собираем их в строку с некоторым числом
            //Затем преобразуем эту строку в целое число
            //Добавляем к итоговому результату
            foreach (char Item in SomeString)
            {
                if (Func.Compareiro( Item, Alpha ))
                {
                    ReponoFabrica += Item;
                }
                else
                {
                    Total += Func.GetNumberFromString(ReponoFabrica);
                    ReponoFabrica = "";
                    continue;                    
                }
            }
            //Если строка закончилась, а в накопителе были набраны числовые символы,
            //То преобразуем эту строку в чило с добавлением в итоговый результат
            if(ReponoFabrica != "" )
            {
                Total += Func.GetNumberFromString(ReponoFabrica);
            }

            return Total;
        }

        static void CaloFobo()
        {
            Console.WriteLine("Введите номер элемента для вичисления числа Фибоначчи");

            int Number = Func.GetNumberFromString(Console.ReadLine());

            Console.WriteLine(ClculateF(Number));

        }
        static int ClculateF( int Number001 )
        {
            if(Number001 < 0)
            {
                Number001 = 0;
            }
            int First = 0, Second = 1, Iterator = 0;
            switch(Number001)
            {
                case 0:
                    return First;
                case 1:
                    return Second;
            }
            Iterator = 2;
            return NextCalc(First, First + Second, ref Iterator, ref Number001); ;            
        }
        static int NextCalc( int Last, int Current, ref int Iterator001, ref int Number001)
        {
            if(Iterator001 == Number001)
            {
                return Last + Current;
            }
            ++Iterator001;
            return NextCalc(Current, Last + Current, ref Iterator001, ref Number001);
        }
    }
}
