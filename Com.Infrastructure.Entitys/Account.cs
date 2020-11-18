using System;
using System.Collections.Generic;
using System.Text;
using Com.Infrastructure.BasicDomain.BasicEntitys;
using Com.Infrastructure.Entitys.DTO;
namespace Com.Infrastructure.Entitys
{
    public class Account : IEntity, IDTOTransfer<AccountDTO>
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string passwd { get; set; }

        public AccountDTO ToDTO()
        {
            return new AccountDTO { name = name, id = ID, passwd = passwd, desctext = "自动生成" };
        }
    }
}
