using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class TimeFont
    {
        public String TimeFonts(int Number)
        {
            if (Number < 10)
            {
                return "0" + Number;
            } else
            {
                return Number + "";
            }
        }
    }
}
