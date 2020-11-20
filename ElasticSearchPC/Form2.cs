using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Com.Infrastructure.BasicDomain.Interfaces;
using Com.Infrastructure.BasicDomain.Implements;

namespace ElasticSearchPC
{
    public partial class Form2 : Form
    {

        public class document
        {
            public string Id { get; set; }
            public string User { get; set; }

            public DateTime postdate { get; set; }
            public string message { get; set; }

        }
        static Uri node = new Uri("http://116.62.190.90:9200");
        static ConnectionSettings settings = new ConnectionSettings(node);
        static Nest.ElasticClient client = new Nest.ElasticClient(settings);



        Com.Infrastructure.BasicDomain.Interfaces.IElasticClient _elastic = new Com.Infrastructure.BasicDomain.Implements.ElasticClient();

        public Form2()
        {
            InitializeComponent();
        }

        string index = "";
        async private void Cbtnadd_Click(object sender, EventArgs e)
        {
            document obj = new document() { Id = index, User = "icxl" + index.ToString(), postdate = DateTime.Now, message = "mesages" + index.ToString() };
            await _elastic.CreateAsync(obj, i => i.Index("test").Id(index));



        }

        async private void CbtnGetAll_Click(object sender, EventArgs e)
        {
            //var obj1 = client.Get<document>(index, g => g.Index("test"));
            var obj = await _elastic.SearchAsync<document>(g => g.Index("test"));
            //var obj = client.Search<document>(g => g.MatchAll());
            print(JsonConvert.SerializeObject(obj.HitsMetadata.Hits));
        }

        async private void CbtnGetAll2_Click(object sender, EventArgs e)
        {

            //var searchResponse = client.Search<document>(s => s.Index("test")
            //    .Query(q => q
            //        .Fuzzy(m => m.Field(f => f.message).Value("m"))
            //    )
            //);
            //var searchResponse = client.Search<document>(s => s.Index("test")
            //    .Query(q => q.Prefix(p => p.message, "me")
            //    )
            //);


            var searchResponse = await _elastic.SearchAsync<document>(s => s.Index("test")
                  .Query(q => q.Wildcard(p => p.message, "*m*") && q.Range(r => r.Field(f => f.Id).GreaterThanOrEquals(0).LessThan(10))/*&& q.Match(mq => mq.Field(f => f.Id).Query("1")) */&& q.DateRange(r => r
                       .Field(f => f.postdate)
                       .GreaterThanOrEquals(new DateTime(2017, 01, 01))
                       .LessThan(new DateTime(2021, 01, 01))
            )
                  )
              );

            //var searchResponse = client.Search<document>(s => s.Index("test")
            //      .Query(q => q.Wildcard(p => p.message, "*m*") && q.Range(r => r.Field(f => f.Id).GreaterThanOrEquals(0).LessThan(10))/*&& q.Match(mq => mq.Field(f => f.Id).Query("1")) */&& q.DateRange(r => r
            //           .Field(f => f.postdate)
            //           .GreaterThanOrEquals(new DateTime(2017, 01, 01))
            //           .LessThan(new DateTime(2021, 01, 01))
            //)
            //      )
            //  );


            print(JsonConvert.SerializeObject(searchResponse));


            //        print(JsonConvert.SerializeObject(client.Search<document>(g => g.Index("test").From(0).Size(10)
            //        .Query(q => q.Match(m => m.Field(f => f.message).Query("m"))
            //))));



        }

        private void print(string str)
        {
            CtxtFull.Text += str + "\n";
        }

        async private void CbtnUpdate_Click(object sender, EventArgs e)
        {

            document obj = new document() { Id = index, User = "updateicxl" + index.ToString(), postdate = DateTime.Now, message = "updatemesages" + index.ToString() };
            await _elastic.UpdateAsync(obj, i => i
                .Index("test")
                .Id(index)
       );
        }

        async private void CbtnRemove_Click(object sender, EventArgs e)
        {
            await _elastic.RemoveAsync<document>(index, d => d.Index("test"));

            var obj = await _elastic.GetAsync<document>(index, g => g.Index("test"));
            print(JsonConvert.SerializeObject(obj.Source));
        }

        private void CtxtContext_KeyDown(object sender, KeyEventArgs e)
        {
            index = CtxtContext.Text;
        }

        private void CtxtContext_KeyUp(object sender, KeyEventArgs e)
        {
            index = CtxtContext.Text;
        }


    }
}
