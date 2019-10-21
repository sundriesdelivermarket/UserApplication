using SundiresDeliverApp.Core.Database_Entity;
using SundiresDeliverApp.Core.Repository_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundiresDeliverApp.Core.AppRepository
{
    public class MS_ADITMCATRepository : IAD_MSITMCATRepository
    {

        private SundriesMarketEntities _entityManager;
        
        public MS_ADITMCATRepository(SundriesMarketEntities DbContext)
        {
            _entityManager = DbContext;
        }


        public List<AD_MSITMCAT> GetItemCategory()
        {
            return _entityManager.AD_MSITMCAT.ToList();
        }
    }
}
