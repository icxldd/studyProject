using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Infrastructure.BasicDomain.BasicInterfaces
{
    public interface IEntityTransfer<T> where T : IEntity
    {
        T ToEntity();
    }
}
