using System;
using Com.Infrastructure.BasicDomain.BasicInterfaces;

namespace Com.Infrastructure.Entitys.DTO
{
    public class AccountDTO : IDTO,IEntityTransfer<Account>
    {
        public string id { get; set; }
        public string name { get; set; }
        public string passwd { get; set; }
        public string desctext { get; set; }
    }
}
