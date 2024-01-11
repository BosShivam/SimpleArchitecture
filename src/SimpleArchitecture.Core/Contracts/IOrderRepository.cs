using SimpleArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArchitecture.Core.Contracts
{
    public interface IOrderRepository
    {
        Order GetStaticOrder();
        Order CreateOrder(Order order);
    }
}
