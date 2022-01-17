using DotnetCoreStartProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationProject.Contracts.Persistence
{
    public interface IOrderRepository: IAsyncRepository<Order>
    {
       
    }
}
