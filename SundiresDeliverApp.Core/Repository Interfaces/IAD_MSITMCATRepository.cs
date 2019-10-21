using SundiresDeliverApp.Core.Database_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundiresDeliverApp.Core.Repository_Interfaces
{
   public interface IAD_MSITMCATRepository
    {
        List<AD_MSITMCAT> GetItemCategory();


    }
}
