using System;
using System.Collections.Generic;

#nullable disable

namespace Turboaz.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? UserPhoneNumber { get; set; }
    }
}
