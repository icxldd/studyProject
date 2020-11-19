using Com.Infrastructure.BasicDomain.BasicInterfaces;
using Com.Infrastructure.Entitys.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Infrastructure.Entitys.Dtos
{
    public class AccountDTO : IDTO, IEntityTransfer<Account>
    {
        public string id { get; set; }
        public string name { get; set; }
        public string passwd { get; set; }
        public string desctext { get; set; }

        public Account ToEntity()
        {
            return new Account() { ID = id, name = name, passwd = passwd };
        }
    }
}
