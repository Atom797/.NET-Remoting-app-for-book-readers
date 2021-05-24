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
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown500, Primary.Brown500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            RemotingConfiguration.Configure("client.config", true);
        }

        private void input_Click(object sender, EventArgs e)
        {
            Input input = new Input();
            input.StartPosition = FormStartPosition.CenterScreen;
            input.Show();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.StartPosition = FormStartPosition.CenterScreen;
            registration.Show();
        }
    }
}
