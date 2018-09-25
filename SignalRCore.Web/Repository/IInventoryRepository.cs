using SignalRCore.Web.Models;

using SignalRCore.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCore.Web.Repository
{
    public interface IInventoryRepository
    {
        
        
        IEnumerable<People> Peoples { get; }


    }
}
