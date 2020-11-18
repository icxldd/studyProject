using Com.Infrastructure.Entitys;
using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Text;
namespace Com.Infrastructure.Bloc
{
    public class RXAccount
    {
        private static Subject<Account> _AccountData = new Subject<Account>();


        private static Subject<Account> _AccountDataPrint = new Subject<Account>();

        public static void pushData(Account account)
        {
            _AccountData.OnNext(account);
        }

        public static Subject<Account> AccountSubject { get; } = _AccountData;



        public static Subject<Account> AccountDataSubject { get; } = _AccountDataPrint;
    }
}
