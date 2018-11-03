using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WangDaMiao
{
    public class WebApiHelp
    {
        HttpClient myhttpClient = new HttpClient();
        private Uri _url = null;

        public void _connection(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                _url = new Uri(str);
            }
        }

        public void GetRequest()
        {
            myhttpClient.BaseAddress = _url;
            HttpResponseMessage response = myhttpClient.GetAsync("api/ApiDemo/Get2").Result;
            string result = "";
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }
        }


    }
}
