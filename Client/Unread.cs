using Newtonsoft.Json;
using RemoteIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Client
{
    public partial class Unread : MaterialForm
    {

        User my = new User();
        public List<ForBook> diaryPages;

        public Unread(User myuser)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown500, Primary.Brown500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);




            my = myuser;
        }



        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Unread_Load(object sender, EventArgs e)
        {
            Iremote_2 obj = (Iremote_2)Activator.GetObject(typeof(Iremote_2), "ipc://myIpcPort/myIpcPort");
            ILease lease = (ILease)((MarshalByRefObject)obj).GetLifetimeService();
            SponsorForClient sponsor = new SponsorForClient();
            lease.Register(sponsor);
            Notes queryStore = new Notes(my);
            string json = JsonConvert.SerializeObject(queryStore);

            string response = obj.InfoAboutOrdersNE(json);

            if (response.Contains("Ошибка!") == false)
            {
                Notes queryResult = JsonConvert.DeserializeObject<Notes>(response);

                this.diaryPages = queryResult.pages;

                for (int i = 0; i < diaryPages.Count; i++) 
                {
                    list.Items.Add("Автор: "+diaryPages[i].author  +"    Название книги: "+ diaryPages[i].title);
                }
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            Iremote_2 obj = (Iremote_2)Activator.GetObject(typeof(Iremote_2), "ipc://myIpcPort/myIpcPort");
            ILease lease = (ILease)((MarshalByRefObject)obj).GetLifetimeService();
            SponsorForClient sponsor = new SponsorForClient();
            lease.Register(sponsor);
            Notes queryStore = new Notes("Check", my.id, author.Text, title.Text);
            string jsondata = JsonConvert.SerializeObject(queryStore);
            obj.Ubrat(jsondata);
        }
    }
}
