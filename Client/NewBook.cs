using Newtonsoft.Json;
using RemoteIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Client
{
    public partial class NewBook : MaterialForm
    {
        User my = new User();
        //DiaryPage mypage = new DiaryPage();

        public NewBook(User myuser)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown500, Primary.Brown500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            my = myuser;
        }
        private void ToBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToAdd_Click(object sender, EventArgs e)
        {
            
            Iremote_2 obj = (Iremote_2)Activator.GetObject(typeof(Iremote_2), "ipc://myIpcPort/myIpcPort");
            ILease lease = (ILease)((MarshalByRefObject)obj).GetLifetimeService();
            SponsorForClient sponsor = new SponsorForClient();
            lease.Register(sponsor);
            ForBook user = new ForBook (my.id,my.login, read.Text, author.Text, title.Text);
            Notes queryStore = new Notes(user);
            string json = JsonConvert.SerializeObject(queryStore);
            
            string response = obj.NewNote(json);
            Notes result = JsonConvert.DeserializeObject<Notes>(response);
            switch (result.type)
            {
                case "SuccessfulyAdded":
                    MessageBox.Show(" Запись добавлена!");

                    break;
                case "NotAdded":
                    throw new Exception();
                    break;
            }
        }

        private void NewNote_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
