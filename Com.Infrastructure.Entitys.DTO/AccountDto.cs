using System;
using Com.Infrastructure.BasicDomain.BasicEntitys;
namespace Com.Infrastructure.Entitys.DTO
{
    public class AccountDTO : IDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string passwd { get; set; }
        public string desctext { get; set; }
    }
}
