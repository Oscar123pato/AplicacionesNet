using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Services
{
    public  interface IPostService
    {
        public Task<List<Post>> Get();
    }
}
