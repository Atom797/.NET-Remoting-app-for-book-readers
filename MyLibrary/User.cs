using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        public int id { get; set; }
        public string nicknames { get; set; }
        public string birthdays { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string about { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string type { get; set; }

        public List<ForBook> pages { get; set; }



        public User()
        {

        }
        public User(string login, string pass)
        {
            this.login = login;
            this.password = pass;
        }

        public User(string type, int id, string author, string title)
        {
            this.type = type;
            this.id = id;
            this.author = author;
            this.title = title;
        }



        public User(string name, string surname, string age, string login, string password)
        {

            this.name = name;
            this.surname = surname;
            this.login = login;
            this.age = age;
            this.password = password;

        }
        public User(int id, string name, string surname, string age, string login, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.age = age;
            this.password = password;
        }
    }
}
