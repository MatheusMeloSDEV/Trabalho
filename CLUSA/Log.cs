using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace CLUSA
{
    public class Log
    {
        public string Método {  get; set; } = String.Empty;
        public string Nome {  get; set; } = String.Empty;
        public string Data { get; set; } = DateTime.Now.ToString("dd/MM/AAAA");
    }
}
