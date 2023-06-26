using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldTech.DI;

namespace WorldTech.Bll
{
    public class Check : ICheck
    {
        public ICart Cart { get; set; }
        public IShop Shop { get; set; }
        public List<(string, int, int)> CheckData { get; set; }
        public int Price { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string CheckJson { get; set; }
    }
}
