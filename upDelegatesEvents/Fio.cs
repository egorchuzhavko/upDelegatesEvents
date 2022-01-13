using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Fio
    {
        public string ShortInfo(string[] name) 
        { 
            return $"{name[0]} {name[1]}"; 
        }
        public string LongInfo(string[] name) 
        { 
            return $"{name[0]} {name[1][0]} {name[2][0]}"; 
        }
    }
}
