using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entities
{
    internal class HourContract
    {

        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract()
        {
        
        }

        public HourContract(DateTime date, double valuePeHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePeHour;
            Hours = hours;
        }

        public  double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
