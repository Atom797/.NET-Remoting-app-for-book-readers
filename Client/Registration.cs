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
    public partial class Registration : MaterialForm
    {
        public Registration()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown500, Primary.Brown500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void regB_Click(object sender, EventArgs e)
        {
            string response=null;
            Iremote obj = (Iremote)Activator.GetObject(typeof(Iremote), "tcp://localhost:8086/Hi");
            ILease lease = (ILease)((MarshalByRefObject)obj).GetLifetimeService();
            SponsorForClient sponsor = new SponsorForClient();
            lease.Register(sponsor);

            //if(name.Text!=null)
            //{
            //    if (surname.Text != null)
            //    {
            //        if (age.Text != null)
            //        {
            //            if (login.Text != null)
            //            {
            //                if (password.Text != null)
            //                {
                                User user = new User(
                                 name.Text,
                                 surname.Text,
                                 age.Text,
                                 login.Text,
                                 password.Text
                                 );
            Notes queryStore = new Notes(user);
            string json = JsonConvert.SerializeObject(queryStore);
                                response = obj.Registration(json);
            //                }
            //                else MessageBox.Show("введите ваш пароль", "window title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //            else MessageBox.Show("введите ваш логин", "window title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else MessageBox.Show("введите ваш возраст", "window title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else MessageBox.Show("введите вашу фамилию", "window title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else MessageBox.Show("введите вашe имя","window title",MessageBoxButtons.OK,MessageBoxIcon.Warning);



            //объект юзера, юзер может быть залогиненым(получены все его данные) или незалогиненым(получены ошибки) и
            // зарегистрированным(получено сообщение об успехе 'TYPE = REGISTERED') или незарегистрированным(получено сообщение об успехе 'TYPE = UNREGISTERED')

            Notes result = JsonConvert.DeserializeObject<Notes>(response);

            switch (result.type)
            {
                case "SuccessfulyRegistered":
                    MessageBox.Show(" Вы успешно зарегистировались");

                    break;
                case "UNREGISTERED":
                    throw new Exception();
                    break;
            }
            if(response== null)
            {
                MessageBox.Show("вы ввели некоректные данные", "window title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Registration registration = new Registration();
                registration.StartPosition = FormStartPosition.CenterScreen;
                registration.Show();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void aboutTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
