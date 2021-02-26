using System;
//Самописная библиотека
using MyLib;

namespace Lesson004
{
    enum MySeaso
    {
        Winter, 
        Spring, 
        Summer, 
        Autumn
    };

    class Program
    {
        static void Main(string[] args)
        {
            int CountPars = 4;
            string[] Denuntiatio = new string[]
            {
                "Вывести несколько полных имён",
                "Сумма всех чисел в строке",
                "Определение времени года",
                "Вычисление числа Фибоначчи"
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
                        Summer();
                        break;
                    case 2:
                        CheckSeason();
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

            MyFunc.ShowArray(Total);
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

            Console.WriteLine(GetSumme(Console.ReadLine()));
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
                if ( MyFunc.Compare( Item, Alpha ))
                {
                    ReponoFabrica += Item;
                }
                else
                {
                    Total += MyFunc.GetNumberFromString(ReponoFabrica);
                    ReponoFabrica = "";
                    continue;                    
                }
            }
            //Если строка закончилась, а в накопителе были набраны числовые символы,
            //То преобразуем эту строку в чило с добавлением в итоговый результат
            if(ReponoFabrica != "" )
            {
                Total += MyFunc.GetNumberFromString(ReponoFabrica);
            }

            return Total;
        }

        static void CheckSeason()
        {
            Console.WriteLine("Введите номер месяца");
            Console.WriteLine( CheS002( CheS001( MyFunc.GetNumberFromConsole() ) ) );
        }
        static MySeaso CheS001( int NumberMonth )
        {
            //Смещаем месяцы на единицу вперёд так, что декабрь теперь первый месяц
            //и таким образом все месяцы равномерно распределены по временам года
            ++NumberMonth;             
            MyFunc.CheckClausaAream(ref NumberMonth, 1, 12);

            int NumberSeas = NumberMonth / 4;
            switch (NumberSeas)
            {
                case 0:
                    return MySeaso.Winter;
                    //break;
                case 1:
                    return MySeaso.Spring;
                    //break;
                case 2:
                    return MySeaso.Summer;
                    //break;                  
            }
            return MySeaso.Autumn;
        }
        static string CheS002(MySeaso SomeSeason001)
        {
            switch (SomeSeason001)
            {
                case MySeaso.Winter:
                    return "Зима";
                    //break;
                case MySeaso.Spring:
                    return "Весна";
                    //break;
                case MySeaso.Summer:
                    return "Лето";
                    //break;
            }
            return "Осень";
        }

        static void CaloFobo()
        {
            Console.WriteLine("Введите номер элемента для вичисления числа Фибоначчи");

            int Number = MyFunc.GetNumberFromConsole();

            Console.WriteLine(ClculateF(Number));

        }
        static int ClculateF( int Number001 )
        {
            //Пределы для задания числа
            MyFunc.CheckLimitataAream(ref Number001, 0, 46);

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
            //Console.WriteLine(Last + Current);
            return NextCalc(Current, Last + Current, ref Iterator001, ref Number001);
        }
    }
}
