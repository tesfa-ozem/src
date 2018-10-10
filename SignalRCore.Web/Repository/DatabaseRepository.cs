using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRCore.Web.Models;
using SignalRCore.Web.Persistence;
using Microsoft.EntityFrameworkCore;
using SignalRCore.Web.ViewModel;


namespace SignalRCore.Web.Repository
{
    public class DatabaseRepository : IInventoryRepository
    {
        private Func<InventoryContext> _contextFactory;

        
        public IEnumerable<People> Peoples => GetAgents();

        private IEnumerable<People> GetAgents()
        {
            throw new NotImplementedException();
        }

        public DatabaseRepository(Func<InventoryContext> context)
        {
            _contextFactory = context;
        }

        public DatabaseRepository()
        {
        }

        public Task CreateAgent(AgentViewModel agentViewModel)
        {
            try
            {
                using (var context = _contextFactory.Invoke())
                {
                    if (context.AppUsers.Any(x => x.FirstName == agentViewModel.FirstName))
                    {
                        var currentAgent = context.AppUsers.FirstOrDefault(x => x.FirstName == agentViewModel.FirstName);


                    }
                    else
                    {
                        context.Add(new AppUsers
                        {
                            FirstName = agentViewModel.FirstName,
                            LastName = agentViewModel.LastName,
                            IdNumber = agentViewModel.IdNumber
                        });
                    }

                    context.SaveChanges();
                }
                return Task.FromResult(true);
            }
            catch (Exception)
            {

                return Task.FromResult(false);
            }
        }

       

    }
}
