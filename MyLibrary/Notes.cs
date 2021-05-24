using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Notes
    {
        public string type { get; set; }
        public User user { get; set; }
        public ForBook page { get; set; }
        public List<ForBook> pages { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public int id { get; set; }

        public Notes()
        {
            
        }

        public Notes(string type)
        {
            this.type = type;
        }
        public Notes(User user)
        {
            this.user = user;
        }
        public Notes(string type, User user)
        {
            this.type = type;
            this.user = user;
        }
        public Notes(string type, ForBook page)
        {
            this.type = type;
            this.page = page;
        }
        public Notes(string type, List<ForBook> array)
        {
            this.type = type;
            this.pages = array;
        }

        public Notes(string type, int id, string author, string title)
        {
            this.type = type;
            this.id = id;
            this.author = author;
            this.title = title;
        }



    }
}
