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
    public partial class Read : MaterialForm
    {
        User my = new User();
        public List<ForBook> diaryPages;
        public Read(User myuser)
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

        private void OtherNotes_Load(object sender, EventArgs e)
        {

            Iremote_2 obj = (Iremote_2)Activator.GetObject( typeof(Iremote_2), "ipc://myIpcPort/myIpcPort");
            ILease lease = (ILease)((MarshalByRefObject)obj).GetLifetimeService();
            SponsorForClient sponsor = new SponsorForClient();
            lease.Register(sponsor);
            Notes queryStore = new Notes(my);
            string json = JsonConvert.SerializeObject(queryStore);

            string response = obj.InfoAboutOrdersProchital(json);

            if (response.Contains("Ошибка!") == false)
            {
                Notes queryResult = JsonConvert.DeserializeObject<Notes>(response);

                this.diaryPages = queryResult.pages;

                for (int i = 0; i < diaryPages.Count; i++)
                {
                    mylist.Items.Add(diaryPages[i].author + ": " + diaryPages[i].title);
                    //status.Text = "Вы прочитали немного книг, но все еще впереди!";
                }
                if(diaryPages.Count<=3)
                {
                    status.Text = "Вы прочитали немного книг, но все еще впереди!";
                }
                if (diaryPages.Count > 3 && diaryPages.Count <=5)
                {
                    status.Text = "Столько страниц уже прочитано, а сколько еще впереди!";
                }
                if (diaryPages.Count > 5 && diaryPages.Count <=8)
                {
                    status.Text = "Чтение делает человека знающим!";
                }
                if (diaryPages.Count > 8 && diaryPages.Count <=15)
                {
                    status.Text = "Чтение делает человека знающим!";
                }
                if (diaryPages.Count > 15)
                {
                    status.Text = "Твоя любовь к книгам просто поражает!";
                }
            }
        }
    }
}
