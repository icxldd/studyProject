using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.Infrastructure.BasicDomain.Implements;
using Com.Infrastructure.BasicDomain.Interfaces;
using Com.Infrastructure.Bloc;
using Com.Infrastructure.Entitys;
using Com.Infrastructure.Entitys.DTO;
using Newtonsoft.Json;

namespace RXNetRedis
{
    public partial class Form1 : Form
    {
        private IRedisClientCURD<Account, AccountDTO> _RedisCURD = new RedisClientCURD<Account, AccountDTO>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RXAccount.AccountSubject.Subscribe(x =>
            {
                CFullText.Text += JsonConvert.SerializeObject(x.ToDTO()) + "\n";

                _RedisCURD.SaveAsync(x);
            });


            RXAccount.AccountSubject.Subscribe(x =>
            {
                CFullText.Text += JsonConvert.SerializeObject(x) + "\n";
                _RedisCURD.SaveAsync(x);
            });


            RXAccount.AccountDataSubject.Subscribe(x =>
            {
                CFullText.Text += "打印流消息：" + JsonConvert.SerializeObject(x);
            });

        }
        int selfIndex = 0;
        private void CButtonChangeValue_Click(object sender, EventArgs e)
        {
            {
                RXAccount.pushData(new Account() { name = "icxl", passwd = "666", ID = (++selfIndex).ToString() });
            }

        }

        async private void CbuttonDeleteById_Click(object sender, EventArgs e)
        {
            await _RedisCURD.DeleteAsync(CtxtId.Text);
            var objs = await _RedisCURD.GetALLAsync(0, 1000);
            CFullText.Text += JsonConvert.SerializeObject(objs);
        }

        async private void CbtnALL_Click(object sender, EventArgs e)
        {
            var objs = await _RedisCURD.GetALLAsync(0, 1000);
            CFullText.Text += JsonConvert.SerializeObject(objs);
        }
        int index = 0;
        async private void btnsave_Click(object sender, EventArgs e)
        {
            index++;
            string text = Ctxt2.Text;
            await _RedisCURD.Add(text + "object", JsonConvert.SerializeObject(new { object1 = "123213" }));
            await _RedisCURD.AddList(text + "list", "list" + index);
            await _RedisCURD.AddList(text + "list", "list2" + index);
            await _RedisCURD.AddSet(text + "set", "set" + index);
            await _RedisCURD.AddSet(text + "set", "set2" + index);
            await _RedisCURD.AddToSortedSet(text + "set2", "set2" + index, 100, DateTime.Now.AddDays(1));
            await _RedisCURD.AddToSortedSet(text + "set2", "123123123" + index, 99, DateTime.Now.AddDays(1));
            await _RedisCURD.Add(text + "Increment", 0);
            await _RedisCURD.IncrementKey(text + "Increment", 10);
            await _RedisCURD.DecrementKey(text + "Increment", 1);
        }

        async private void CbtnGet_Click(object sender, EventArgs e)
        {
            string text = Ctxt2.Text;
            string str = "";
            str += "object:" + JsonConvert.SerializeObject(await _RedisCURD.Get(text + "object")) + "\n";
            str += "list:" + JsonConvert.SerializeObject(await _RedisCURD.GetList(text + "list")) + "\n";
            str += "set:" + JsonConvert.SerializeObject(await _RedisCURD.GetSet(text + "set")) + "\n";
            str += "asc:" + JsonConvert.SerializeObject(await _RedisCURD.GetToSortSet(text + "set2")) + "\n";
            str += "desc:" + JsonConvert.SerializeObject(await _RedisCURD.GetToSortSetByDesc(text + "set2")) + "\n";
            CFullText.Text += str;
        }

        async private void CbtnDelete2_Click(object sender, EventArgs e)
        {
            string text = Ctxt2.Text;
            await _RedisCURD.Remove(text + "object");
            await _RedisCURD.Remove(text + "list");
            await _RedisCURD.Remove(text + "set2");
            await _RedisCURD.Remove(text + "set");
        }

        async private void CbtnGetAll2_Click(object sender, EventArgs e)
        {
            CFullText.Text += JsonConvert.SerializeObject(await _RedisCURD.GetALLKeys());
        }

        async private void btnUpdate2_Click(object sender, EventArgs e)
        {
            string text = Ctxt2.Text;
            await _RedisCURD.Set(text + "object", text);
            await _RedisCURD.Set(text + "list", text);
            await _RedisCURD.Set(text + "set2", text);
            await _RedisCURD.Set(text + "set", text);
        }
    }
}
