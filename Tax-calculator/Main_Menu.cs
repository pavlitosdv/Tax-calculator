using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_calculator
{
    class Main_Menu
    {



        private double Calculate_Dikeopratikos_Tokos(double capital, double DikeopratikosTokos, TimeSpan days)
        {
            return (capital * DikeopratikosTokos * (((double)days.TotalDays) / (double)360));
        }

        private double Calculate_Tokos_Yperimerias(double capital, double TokosYperimerias, TimeSpan days)
        {
            return (capital * TokosYperimerias * (((double)days.TotalDays) / (double)360));
        }


        private void PrintEachPeriodDetails(DateTime startDate, DateTime endDate, TimeSpan days, Interest dtss, double dikeopratikos, double yperimerias)
        {
            Console.WriteLine("Start date: {0, -6} | End date: {1, -5} | days: {2, -3}", startDate.ToString("MMM d, yyyy"), endDate.ToString("MMM d, yyyy"), days.Days);
            Console.WriteLine("Dikeopratikos rate: {0, -5} | Interest: {1, -5:C2}", dtss.DikeopratikosTokos, dikeopratikos);
            Console.WriteLine("Yperimerias rate: {0, -5} | Interest: {1, -5:C2}", dtss.TokosYperimerias, yperimerias);
            Console.WriteLine();
        }

        private void PrintTotalAmount(double capital, double local_store1, double local_store2)
        {
            Console.WriteLine("Initial Capital: {0, -6}", capital);
            Console.WriteLine("Total Dikeopratikos Rate: {0, -6:C2}", local_store1);
            Console.WriteLine("Total Yperimerias Rate: {0, -6:C2}", local_store2);
            Console.WriteLine("Total Payment: {0, -6:C2}", local_store1 + local_store2 + capital);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
