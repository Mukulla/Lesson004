using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson004
{
    class Func
    {
        static public bool Compareiro(char Value, string SomeString001 )
        {
            foreach (char Item in SomeString001)
            {
                if(Value == Item)
                {
                    return true;
                }
            }
            return false;
        }
        static public int GetNumberFromString(string SomeString)
        {
            int SomeValue;
            //Проверяем на соответствие типу int
            if (!int.TryParse(SomeString, out SomeValue))
            {
                SomeValue = 0;
            }
            return SomeValue;
        }
    }
}
