using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryOnlineApplication.Models
{
    public class LoginModel
    {
        public string id { get; set; }
        public string code { get; set; }
        public string roleId { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string fullName { get; set; }
    }
}
