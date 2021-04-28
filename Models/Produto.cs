using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVazio.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}