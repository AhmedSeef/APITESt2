using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Web.Services.Description;

namespace APITESt2
{
    public partial class like : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var p = new data
            {
                BranchID = 1,
                SupplierId = 1,
                TranDate = new DateTime(),
                CurrencyID = 7,
                CurrencyRate = 1,
                DtlValue = 100,
                DtlTaxValue = 0.0,
                DtlDiscountValue = 0.0,
                NetValue = 100.0,
                LocalNetValue = 100.0,
                AddedBy = "fmis_HI_test",
                TransactionDetails = new List<data1>
                {
                    new data1
                    {
                         ItemId=1,
                         DtlValue=100,
                         DtlTaxValue=0,
                         DtlDiscountValue=0,
                         NetValue=100,
                         LocalNetValue=100,
                         CurrencyId=7,
                         CurrencyRate=1

                    },
                    new data1
                    {
                        ItemId=2,
                         DtlValue=100,
                         DtlTaxValue=0,
                         DtlDiscountValue=0,
                         NetValue=100,
                         LocalNetValue=100,
                         CurrencyId=7,
                         CurrencyRate=1
                    }

                    
    }

            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.1.192/AcpApi/");
            var response = client.PostAsJsonAsync("api/invoice/createinvocie", p).Result;
            var data =  response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                Console.Write("aaaa");
                
            }
            else
            {

            }
        }
    }

    class data
    {
        public int BranchID { get; set; }
        public int SupplierId { get; set; }
        public DateTime TranDate { get; set; }
        public int CurrencyID { get; set; }
        public int CurrencyRate { get; set; }
        public int DtlValue { get; set; }
        public double DtlTaxValue { get; set; }
        public double DtlDiscountValue { get; set; }
        public double NetValue { get; set; }
        public double LocalNetValue { get; set; }
        public string AddedBy { get; set; }
        public List<data1> TransactionDetails { get; set; }
    }

    class data1
    {
        public int ItemId { get; set; }
        public int DtlValue { get; set; }
        public int DtlTaxValue { get; set; }
        public int DtlDiscountValue { get; set; }
        public int NetValue { get; set; }
        public int LocalNetValue { get; set; }
        public int CurrencyId { get; set; }
        public int CurrencyRate { get; set; }
    }
}