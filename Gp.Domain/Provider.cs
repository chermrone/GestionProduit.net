using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class Provider
    {
        /*string confirmPassword;
        DateTime dateCreated;
        string email;
        int id;
        bool isApproved;
        string password;
        string username;*/
        public string ConfirmPassword
        {
            get;
          /*  {
                return confirmPassword;
            }*/
            set;/*
            {
                confirmPassword = value;
            }*/
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Product> Products { get; set; }

        public Provider(int id, string email, string password, DateTime datecreated )
        {
            Id = id;
            Email = email;
            DateCreated = datecreated;
        }
        public Provider()
        {
                
        }
    }
}
