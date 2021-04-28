using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVazio.Controllers
{
    public class OutraController : Controller
    {
        public string Index()
        {
            return "Outra home controller";
        }
    }
}