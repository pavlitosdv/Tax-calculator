using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_calculator
{
    class Main_Menu
    {

        public void ShowMenu()
        {
            // Array with predifend dates and rates
            Interest[] dtss = new Interest[] {new Interest( new DateTime(2000,01,01), new DateTime(2000,01,16), 0.19, 0.21 ),
                                              new Interest( new DateTime(2000,01,17), new DateTime(2000,01,26), 0.165, 0.185),
                                              new Interest( new DateTime(2000,01,27), new DateTime(2000,03,08), 0.16, 0.18),
                                              new Interest( new DateTime(2000,03,09), new DateTime(2000,04,19), 0.1525, 0.1725),
                                              new Interest( new DateTime(2000,04,20), new DateTime(2000,06,28), 0.145, 0.165),
                                              new Interest( new DateTime(2000,06,29), new DateTime(2000,09,05), 0.14, 0.16),
                                              new Interest( new DateTime(2000,09,06), new DateTime(2000,11,14), 0.1325, 0.1525),
                                              new Interest( new DateTime(2000,11,15), new DateTime(2000,11,28), 0.1275, 0.1475),
                                              new Interest( new DateTime(2000,11,29), new DateTime(2000,12,12), 0.1225, 0.1425),
                                              new Interest( new DateTime(2000,12,13), new DateTime(2000,12,26), 0.1150, 0.1350),
                                              new Interest( new DateTime(2000,12,27), new DateTime(2001,05,10), 0.1075, 0.1275),
                                              new Interest( new DateTime(2001,05,11), new DateTime(2001,08,30), 0.1050, 0.1250),
                                              new Interest( new DateTime(2001,08,31), new DateTime(2001,09,17), 0.1025, 0.1225),
                                              new Interest( new DateTime(2001,09,18), new DateTime(2001,11,08), 0.0975, 0.1175),
                                              new Interest( new DateTime(2001,11,09), new DateTime(2002,12,05), 0.0925, 0.1125),
                                              new Interest( new DateTime(2002,12,06), new DateTime(2003,03,06), 0.0875, 0.1075),
                                              new Interest( new DateTime(2003,03,07), new DateTime(2003,06,05), 0.0850, 0.105),
                                              new Interest( new DateTime(2003,06,06), new DateTime(2005,12,05), 0.080, 0.10),
                                              new Interest( new DateTime(2005,12,06), new DateTime(2006,03,07), 0.0825, 0.1025),
                                              new Interest( new DateTime(2006,03,08), new DateTime(2006,06,14), 0.0850, 0.1050),
                                              new Interest( new DateTime(2006,06,15), new DateTime(2006,08,08), 0.0875, 0.1075),
                                              new Interest( new DateTime(2006,08,09), new DateTime(2006,10,10), 0.09, 0.11),
                                              new Interest( new DateTime(2006,10,11), new DateTime(2006,12,12), 0.0925, 0.1125),
                                              new Interest( new DateTime(2006,12,13), new DateTime(2007,03,13), 0.0950, 0.1150),
                                              new Interest( new DateTime(2007,03,14), new DateTime(2007,06,12), 0.0975, 0.1175),
                                              new Interest( new DateTime(2007,06,13), new DateTime(2008,07,08), 0.10, 0.12),
                                              new Interest( new DateTime(2008,07,09), new DateTime(2008,10,07), 0.1025, 0.1225),
                                              new Interest( new DateTime(2008,10,08), new DateTime(2008,10,08), 0.0975, 0.1175),
                                              new Interest( new DateTime(2008,10,09), new DateTime(2008,11,11), 0.0925, 0.1125),
                                              new Interest( new DateTime(2008,11,12), new DateTime(2008,12,09), 0.0875, 0.1075),
                                              new Interest( new DateTime(2008,12,10), new DateTime(2009,03,10), 0.08, 0.10),
                                              new Interest( new DateTime(2009,03,11), new DateTime(2009,04,07), 0.075, 0.095),
                                              new Interest( new DateTime(2009,04,08), new DateTime(2009,05,12), 0.0725, 0.0925),
                                              new Interest( new DateTime(2009,05,13), new DateTime(2011,04,12), 0.0675, 0.0875),
                                              new Interest( new DateTime(2011,04,13), new DateTime(2011,07,12), 0.07, 0.09),
                                              new Interest( new DateTime(2011,07,13), new DateTime(2011,11,08), 0.0725, 0.0925),
                                              new Interest( new DateTime(2011,11,09), new DateTime(2011,12,13), 0.07, 0.09),
                                              new Interest( new DateTime(2011,12,14), new DateTime(2012,07,10), 0.0675, 0.0875),
                                              new Interest( new DateTime(2012,07,11), new DateTime(2013,05,07), 0.065, 0.0850),
                                              new Interest( new DateTime(2013,05,08), new DateTime(2013,11,12), 0.06, 0.08),
                                              new Interest( new DateTime(2013,11,13), new DateTime(2014,06,10), 0.0575, 0.0775),
                                              new Interest( new DateTime(2014,06,11), new DateTime(2014,09,09), 0.054, 0.074),
                                              new Interest( new DateTime(2014,09,10), new DateTime(2016,03,15), 0.053, 0.073),
                                              new Interest( new DateTime(2016,03,16), new DateTime(2019,12,31), 0.053, 0.073)
            };

         
        }

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
