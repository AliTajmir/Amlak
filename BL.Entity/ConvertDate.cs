using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entity
{
   public static class ConvertDate
    {
       
        public static string ToShamsi(this DateTime dateTime)
        {
            
            PersianCalendar persianCalendar = new PersianCalendar();
            var datePersian = persianCalendar.GetYear(dateTime).ToString("####") + "/" + persianCalendar.GetMonth(dateTime).ToString("0#") + "/" + persianCalendar.GetDayOfMonth(dateTime).ToString("0#");
            return datePersian;

        }
    }
}
