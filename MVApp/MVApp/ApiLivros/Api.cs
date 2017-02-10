using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVApp.ApiLivros
{
    public static class Api
    {
        public static async Task<List<Model.Livro>> GetAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var json = await client.GetStringAsync("http://mvalivros.azurewebsites.net/api/livros");
                    var livros = JsonConvert.DeserializeObject<List<Model.Livro>>(json);
                    return livros;
                }
            }
            catch (Exception ex){
                throw ex;
            }
        }
    }
}
