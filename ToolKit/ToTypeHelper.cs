using System;
using System.Collections.Generic;
using System.Text;

namespace ToolKit
{
    static class ToTypeHelper
    {
        //create own extension method
        public static short ToShort(this object value)
        {
            return Convert.ToInt16(value);
        }
        public static int ToInt(this object value)
        {
            return Convert.ToInt32(value);
        }
        public static long ToLong(this object value)
        {
            return Convert.ToInt64(value);
        }
        public static string DateTimeToString(this DateTime value)
        {
            return value.ToString("dd-MM-yyy");
        }
        public static bool intEquals(this int first, int second)
        {
            return first == second ? true : false;
        }
    }

}
