using Microsoft.AspNetCore.SignalR;
using SignalRCore.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCore.Web.Hubs
{
    public class Inventory : Hub
    {
        private readonly IInventoryRepository _repository;

        public Inventory(IInventoryRepository repository)
        {
            _repository = repository;
        }

        

        
    }
}
