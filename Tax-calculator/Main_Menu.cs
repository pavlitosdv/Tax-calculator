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

    }
}
