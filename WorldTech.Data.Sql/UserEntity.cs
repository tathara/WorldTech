using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using WorldTech.DI;

namespace WorldTech.Data.Sql
{
    public class UserEntity : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public ICart Cart { get; set; }
        [NotMapped]
        public List<(string, int, int)> CartData { get; set; }
        public string CartJson
        {
            get { return JsonConvert.SerializeObject(this.CartData); }
            set { this.CartData = JsonConvert.DeserializeObject<List<(string, int, int)>>(value); }
        }

        public UserEntity() { }

        public UserEntity(IUser user)
        {
             
            Id = 0;
            Name = user.Name;
            Login = user.Login;
            Password = user.Password;
            Cart = user.Cart;
            CartData = user.CartData;
        }
    }
}
