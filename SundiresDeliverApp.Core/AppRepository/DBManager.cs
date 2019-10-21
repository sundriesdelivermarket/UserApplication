using SundiresDeliverApp.Core.Database_Entity;
using SundiresDeliverApp.Core.Repository_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundiresDeliverApp.Core.AppRepository
{
    public class DBManager
    {
        private readonly SundriesMarketEntities _dbContext;

        public MS_ADITMCATRepository ItemCategoryRepository;

        public DBManager()
        {
            _dbContext = new SundriesMarketEntities();
            ItemCategoryRepository = new MS_ADITMCATRepository(_dbContext);
        }

        

    }
}
