using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Infrastructure.BasicDomain.BasicInterfaces
{


    /// <summary>
    /// DTO转换
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDTOTransfer<T> where T : IDTO
    {

        T ToDTO();
    }
}
