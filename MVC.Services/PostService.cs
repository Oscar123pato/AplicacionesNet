using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MVC.Services
{
    public class PostService : IPostService
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        public async Task<List<Post>> Get()
        {
            var cliente = new HttpClient(); //clase cliente que permite enviar/consultar una ApiRest, funciona por el protocolo http
            var response = await cliente.GetAsync(url);//devuelve la tarea de operación asincrona, representando el objeto
            var body = await response.Content.ReadAsStringAsync();// devuelve el mensaje de la operación asincrona
            var posts = JsonSerializer.Deserialize<List<Post>>(body);// devuelve un valor Json
            return posts;
        }
    }
}
