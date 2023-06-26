using System.ComponentModel.DataAnnotations.Schema;
using WorldTech.DI;
using Newtonsoft.Json;

namespace WorldTech.Data.Sql
{
    public class CheckEntity : ICheck
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public int UserId { get; set; }
        public int Price { get; set; }
        public DateTime DateTime { get; set; }
        [NotMapped]
        public ICart Cart { get; set; }
        [NotMapped]
        public IShop Shop { get; set; }
        [NotMapped]
        public List<(string, int, int)> CheckData { get; set; }
        public string CheckJson
        {
            get { return JsonConvert.SerializeObject(this.CheckData); }
            set { this.CheckData = JsonConvert.DeserializeObject<List<(string,int, int)>>(value); }
        }

        public CheckEntity() { }

        public CheckEntity(ICheck item)
        {
            Id = 0;
            Cart = item.Cart;
            Shop = item.Shop;
            UserId = item.UserId;
            ShopName = item.Shop.Name;
            DateTime = item.DateTime;
            CheckData = item.CheckData;
            CheckJson = item.CheckJson;
            foreach (var product in JsonConvert.DeserializeObject<List<(string, int, int)>>(CheckJson))
            {
                Price += product.Item3 * product.Item2;
            }
        }
    }
}

