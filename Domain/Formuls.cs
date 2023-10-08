using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp2.Domain
{
    public class Formuls
    {
        static public int GetPercent(decimal number, decimal max)
        {
            return (int)((number / max) * 100);
        }
        static public decimal GetNumberFromPercent(decimal number, int percent)
        {
            return number / 100 * percent;
        }

    }
}
