using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace _20200525_KlasesDarbas
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> _content = new Dictionary<string, string>();
            _content.Add("username", "abcs");
            _content.Add("password", "slaptazodis");

            var httpContent = new FormUrlEncodedContent(_content);
            HttpClient clientas = new HttpClient();
            var atsakymas = clientas.PostAsync("puslapis", httpContent);
        }
    }
}
