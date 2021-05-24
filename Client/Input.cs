using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemoteIn;
using System.Runtime.Remoting.Lifetime;
using Newtonsoft.Json;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Client
{
    public partial class Input : MaterialForm
    {
        public Input()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown500, Primary.Brown500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void inputbatton_Click(object sender, EventArgs e)
        {
            Iremote obj = (Iremote)Activator.GetObject(
         typeof(Iremote), "tcp://localhost:8086/Hi");

            ILease lease = (ILease)((MarshalByRefObject)obj).GetLifetimeService();
            SponsorForClient sponsor = new SponsorForClient();
            lease.Register(sponsor);
            if (obj == null)
            {
                Console.WriteLine("Сервер недоступен");
                return;
            }
            User user = new User(login1.Text, password1.Text);
            Notes queryStore = new Notes(user);
            string jsondata = JsonConvert.SerializeObject(queryStore);
            string res = obj.Authorization(jsondata);
            if (res.Contains("Ошибка!") == false)
            {

                User forAccount = JsonConvert.DeserializeObject<User>(res);
                //MessageBox.Show("Enter!");
                PersonalForm acc = new PersonalForm(forAccount);
                acc.StartPosition = FormStartPosition.CenterScreen;
                acc.Show();
            }
            else
            {
                MessageBox.Show(res);
            }
        }

        private void Input_Load(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void login1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
