using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson004
{
    class Func
    {
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
