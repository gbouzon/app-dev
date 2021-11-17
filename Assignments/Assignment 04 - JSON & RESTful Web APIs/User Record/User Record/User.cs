using System;

namespace User_Record
{
    class User
    {
        //attributes
        //named exactly as the attr in each json string
        private int id;
        private string email;
        private string first_name;
        private string last_name;
        private string avatar; //stores the url where the image is

        //constructor
        public User(int id, string email, string first_name, string last_name, string avatar)
        {
            ID = id;
            Email = email;
            FirstName = first_name;
            LastName = last_name;
            Avatar = avatar;
        }

        public override string ToString() //for testing
        {
            string str = "";

            str += String.Format($"| {"User ID",-20} | {ID,30} |");
            str += String.Format($"| {"Email",-20} | {Email,-30} |");
            str += String.Format($"| {"First Name",-20} | {FirstName,-30} |");
            str += String.Format($"| {"Last Name",-20} | {LastName,-30} |");
            str += String.Format($"| {"Avatar",-20} | {Avatar,-30} |");

            return str;
        }

        //properties
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.first_name;
            }
            set
            {
                this.first_name = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.last_name;
            }
            set
            {
                this.last_name = value;
            }
        }
        public string Avatar
        {
            get
            {
                return this.avatar;
            }
            set
            {
                this.avatar = value;
            }
        }
    }
}