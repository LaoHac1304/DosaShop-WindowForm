using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosaShop.DTO
{
    public class UserInfo
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Display_name { get; set; }
        public Boolean Role { get; set; }
        public string User_img { get; set; }

        public UserInfo(int id, string username, string email, string password, string phone, string address, string display_name, bool role, string user_img)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            Display_name = display_name;
            Role = role;
            User_img = user_img;
        }
    }
}
