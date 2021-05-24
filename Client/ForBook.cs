using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ForBook
    {

        public int id { get; set; }
        public int User_id { get; set; }
        public string login { get; set; }
        public string Text { get; set; }
        public string read { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public int id_db { get; set; }

        public ForBook()
        {

        }
        public ForBook(int id_users)
        {
            this.User_id = id_users;
        }

        public ForBook(int id, string login, string read, string author, string title)
        {
            this.id = id;
            this.login = login;
            this.read = read;
            this.author = author;
            this.title = title;

        }


        public ForBook(int id,string author, string title)
        {
            this.id = id;
            this.author = author;
            this.title = title;

        }



        public ForBook(int id_db, int id, string login, string read, string author, string title)
        {
            this.id_db = id_db;
            this.id = id;
            this.login = login;
            this.read = read;
            this.author = author;
            this.title = title;

        }

    }
}
