using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class Provider : Concept
    {
        private string confirmPassword;
        /* DateTime dateCreated;
         string email;
         int id;
        string username;*/
        bool isApproved;
        private string password;
        private string confirmPassword1;
        public string Email { get; set; }
        public string Username { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public static int NbInstance { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Product> Products { get; set; }




        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length <= 5 || value.Length >= 20)
                    Console.WriteLine("Error");
                else
                {
                    password = value;
                }
            }
        }

        public string ConfirmPassword
        {
            get => confirmPassword;
            set
            {
                if (value.Equals(password)) confirmPassword = value;
                else Console.WriteLine("error1");
            }
        }

        public static bool SetIsApproved(Provider p)
        {
            /* if (p.password.Equals(p.ConfirmPassword)) return p.isApproved;
             else return !p.isApproved;*/
            return p.isApproved = p.password.Equals(p.ConfirmPassword);
        }

        public static void SetIsApprouved(string password, string confirmpassword, ref bool IsApprouved)
        { IsApprouved = password == confirmpassword; }


        public bool login(string password, string name)
        {
            if ((name.Equals(Username)) && (password.Equals(Password))) return true;
            else { return false; }
        }




        public Provider(int id, string email, string password, DateTime datecreated)
        {
            Id = id;
            Email = email;
            DateCreated = datecreated;
            NbInstance++;
        }


        public Provider()
        {
            NbInstance++;
        }

        public override string ToString()
        {
            return $"[{Username},{ DateCreated},{isApproved},{Email}]";
        }





        public override void GetDetails()
        {
            /* for (int i = 0; i < Products.Count; i++)
             {
                 Products[i].GetDetails();
             }*/

            foreach (var item in Products)
            {
                item.GetDetails();
            }
        }


        public void GetProducts(string filterType, string filterValue)
        {
            foreach (var item in Products)
            {
                /*if (filterType=="Name")
                {
                    if (item.Name==filterValue)
                    {
                        item.GetDetails();
                    }
                }
                if (filterType == "Price")
                {
                    double x;
                    double.TryParse(filterValue, out x)// tryparse try to convert string to double si nn il retourne une valeur pardefaut 0
                        // pars kima trypars emma ki maynajjemech ya3mellek exception
                    if (item.Price == x)
                    {
                        item.GetDetails();
                    }
                    
                }*/




                /*switch (filterValue)
                {
                    case "Name":
                        if (item.Name == filterValue)
                        {
                            item.GetDetails();
                        }
                        break;

                    case "Price":
                        double x;
                        double.TryParse(filterValue, out x)
                    if (item.Price == x)
                        {
                            item.GetDetails();
                        }
                        break;
                }*/
            }
        }
    }
}
