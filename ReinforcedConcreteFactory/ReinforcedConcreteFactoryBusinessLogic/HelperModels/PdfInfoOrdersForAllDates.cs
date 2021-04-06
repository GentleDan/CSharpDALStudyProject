using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryBusinessLogic.HelperModels
{
    public class PdfInfoOrdersForAllDates
    {
        public string FileName { get; set; }

        public string Title { get; set; }

        public List<ReportOrdersForAllDatesViewModel> Orders { get; set; }
    }
}
