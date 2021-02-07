using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Net;


namespace AppFWT.Clases
{
    
    public class UserManager
    {
        const String URL = "http:///developerfwt.atwebpages.com/php/";

        private HttpClient getClient()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        //Registrar usuario
        public async void registrar(string user, string mail, string password)
        {
            HttpClient client = getClient();
            var result = await client.GetAsync(URL + "registro.php?user=" + user + "&mail=" + mail + "&password=" + password);
        }


    }
}
