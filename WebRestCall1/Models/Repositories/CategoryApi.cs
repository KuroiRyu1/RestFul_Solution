using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WebRestCall1.Models.Repositories
{
    public class CategoryApi
    {
        public async Task<List<Category>> GetCates()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8020/");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("username", "getun");
            client.DefaultRequestHeaders.Add("pwd", "wuwa");
            client.DefaultRequestHeaders.Add("tk", "123");
            HttpResponseMessage res = await client.GetAsync("dm/dms");
            //WebClient client = new WebClient();
            //client.BaseAddress = @"http://192.168.150.155:8020/";
            //client.Headers.Add("Accept", "application/json");
            //HttpResponseMessage response = await client.OpenReadAsync("api/categoryapi");
            List<Category> cates = new List<Category>();
            if (res.IsSuccessStatusCode == true)
            {
                var dataJson = res.Content.ReadAsStringAsync().Result;
                cates = JsonConvert.DeserializeObject<List<Category>>(dataJson);
            }
            return cates;
        }
        public async Task<int> CreateCates(Category item)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress= new Uri("http://192.168.150.155:8020/");
            HttpResponseMessage response = await client.GetAsync("api/categoryapi");
            return 0;
        }
    }
}