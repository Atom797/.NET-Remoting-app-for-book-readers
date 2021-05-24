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
    public partial class PersonalForm : MaterialForm
    {
        User my = new User();
        public PersonalForm(User user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown500, Primary.Brown500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            my = user;
            name.Text = user.name;
            surname.Text = user.surname;
            age.Text = user.age;
            if(my.id<=4)
            {
                level.Text = "Ты одни из первых возпользовался услугами нашего приложения!\n Спасибо тебе за это!";
            }
            if (my.id==1)
            {
                level.Text = "Ты наш первый пользователь нашего приложения!\nСпасибо тебе за это!";
            }
            if (4<my.id)
            {
                level.Text = "Спасибо тебе за то, что воспользовался нашим преложением!";
            }


        }

        private void ToOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            NewBook newNote = new NewBook(my);
            newNote.Show();

        }

        private void Look_Click(object sender, EventArgs e)
        {
            Read other = new Read(my);
            other.Show();
        }

        private void Personal_Load(object sender, EventArgs e)
        {

        }

        private void unread_Click(object sender, EventArgs e)
        {
            Unread other = new Unread(my);
            other.Show();

        }
    }
}
