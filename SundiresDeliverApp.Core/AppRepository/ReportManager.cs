using SundiresDeliverApp.Core.Database_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundiresDeliverApp.Core.AppRepository
{
    public class ReportManager
    {
        private readonly DBManager _dBManager;

        public ReportManager()
        {
            _dBManager = new DBManager();

        }

        public List<AD_MSITMCAT> GetItemCategory()
        {
            var itemCategory = _dBManager.ItemCategoryRepository.GetItemCategory();
            return itemCategory;
        }

    }
}
