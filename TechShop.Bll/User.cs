﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldTech.DI;

namespace WorldTech.Bll
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string CartJson { get; set; }
        public ICart Cart { get; set; }
        public List<(string, int, int)> CartData { get; set; }
    }
}
