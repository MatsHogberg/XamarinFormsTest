using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Helpers
    {
        public static String TodaysDateAsString()
        {
            var date = DateTime.Today.ToString("D");
            return date;
        }
    }
}
