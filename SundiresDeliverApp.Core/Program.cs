using SundiresDeliverApp.Core.AppRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundiresDeliverApp.Core
{
    class Program
    {
        public static void Main(string[] args)
        {
            ReportManager reportManager = new ReportManager();

            reportManager.GetItemCategory();
        }
    }
}
