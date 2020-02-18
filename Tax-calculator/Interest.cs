using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_calculator
{
    class Interest
    {
        public double DikeopratikosTokos { get; set; }
        public double TokosYperimerias { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public Interest(DateTime startDate, DateTime endDate, double dikeopratikosTokos, double tokosYperimerias)
        {
            StartDate = startDate;
            EndDate = endDate;
            DikeopratikosTokos = dikeopratikosTokos;
            TokosYperimerias = tokosYperimerias;
        }

    }
}
