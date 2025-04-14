using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo11
{
   public class TrabalahandoComDatas
    {
        public void AulaDatetime() 
        {

            var date1 = new DateTime(2025, 12, 02, 19, 22, 23);
            var date2 = DateTime.Parse("2025/12/12 22:14:32");
            var date3 = DateTime.Now;
            var date4 = DateTime.Today;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);
        
            Console.WriteLine(date1.ToString("yyyy"));
            Console.WriteLine(date1.ToString("dd-MM-yyyy"));

            var dataOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
            Console.WriteLine(dataOffset1.LocalDateTime);
            Console.WriteLine(dataOffset1.UtcDateTime);
        }

        public void AulaSubitrairDatas()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Parse("2025-01-01");

            var diff = date1 - date2;
            var diff2 = date1.Subtract(date2);

            Console.WriteLine((int)diff.TotalDays);
            Console.WriteLine((int)diff.TotalHours);

            Console.WriteLine((int)diff2.TotalDays);
            Console.WriteLine((int)diff2.TotalHours);

        }

        public void AulaAdicionandoDiasMesAno()
        {
            var data1 = DateTime.Now;

            Console.WriteLine(data1.AddDays(4).ToString("dd-MM-yyy HH:mm:ss"));
            Console.WriteLine(data1.AddMonths(2).ToString("dd-MM-yyy HH:mm:ss"));
            Console.WriteLine(data1.AddYears(5).ToString("dd-MM-yyy HH:mm:ss"));
        }


        public void AulaAdicionandoHoraMinutoSegundos()
        {
            var data1 = DateTime.Now;

            Console.WriteLine(data1.ToString("dd-MM-yyy HH:mm:ss"));

          Console.WriteLine(data1.AddHours(4).ToString("HH:mm:ss"));
            Console.WriteLine(data1.AddMinutes(2).ToString("HH:mm:ss"));
            Console.WriteLine(data1.AddSeconds(5).ToString("HH:mm:ss"));
        }

        public void AulaDiadaSemana()
        {
            var data1 = DateTime.Now;

            Console.WriteLine(data1.ToString("dd-MM-yyy HH:mm:ss"));

            Console.WriteLine(data1.DayOfYear);
            Console.WriteLine(data1.DayOfWeek);
            
        }


        public void AulaDateOnly()
        {
            var somenteData = new DateOnly(2025,4,14);

            var somenteData2 = DateOnly.Parse("2025-04-14");

            Console.WriteLine(somenteData);

            Console.WriteLine(somenteData.ToString("dd-MM-yyyy"));
            Console.WriteLine(somenteData2);
        }

        public void AulaTimeOnly()
        {
            var somenteHora = new TimeOnly(12, 23);

            var somenteHora2 = TimeOnly.Parse("12:23");

            Console.WriteLine(somenteHora.ToString("HH:mm:ss")); 
            Console.WriteLine(somenteHora2);    
        }
    }
}
