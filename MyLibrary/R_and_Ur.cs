using Newtonsoft.Json;
using RemoteIn;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class R_and_Ur : MarshalByRefObject, Iremote_2
    {

        string connectString = @"Data Source=DESKTOP-MAEK2VM\SQLEXPRESS;Initial Catalog=book;Integrated Security = True";
        public R_and_Ur()
        {
            Console.WriteLine("Объек DiaryWorkPage создан");
        }
        ~R_and_Ur()
        {
            Console.WriteLine(" Объект DiaryWorkPage удален");
        }
        public override object InitializeLifetimeService()
        {
            ILease lease = (ILease)base.InitializeLifetimeService();
            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(1000);
                lease.SponsorshipTimeout = TimeSpan.FromSeconds(10000);
                lease.RenewOnCallTime = TimeSpan.FromSeconds(1000);
            }
            return lease;
        }

        public string NewNote(string json)
        {
            Console.WriteLine("Метод NewNote вызван");

            Notes obj = JsonConvert.DeserializeObject<Notes>(json);

            string json1 = "NotAdded";
            string query = $"INSERT INTO  [dbo].[Read](id_for_user, login, reads, author, title) VALUES (" +
            $"{Convert.ToInt32(obj.page.id)}," +
            $"'{obj.page.login}'," +
            $"'{obj.page.read}'," +
            $"'{obj.page.author}'," +
            $"'{obj.page.title}')";
            SqlConnection connection = new SqlConnection(connectString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    Notes successfulyRegistr = new Notes("SuccessfulyAdded");
                    json1 = JsonConvert.SerializeObject(successfulyRegistr);
                }
                connection.Close();
            }
            catch
            {
                connection.Close();
            }

            return json1;

        }

        public string InfoAboutOrdersProchital(string json)
        {
            Console.WriteLine("Метод AddToOrders вызван");

            Notes obj = JsonConvert.DeserializeObject<Notes>(json);


            //and reads = 'Прочитал'
            string json1 = null;
            string error = null;
            string query = $"SELECT * FROM  [dbo].[Read] WHERE id_for_user = '{obj.user.id}' and reads = 'Прочитал' ";
            List<ForBook> pages = new List<ForBook>();
            SqlConnection connection = new SqlConnection(connectString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        pages.Add(new ForBook(
                           Convert.ToInt32(reader[0].ToString()),
                           Convert.ToInt32(reader[1].ToString()),
                           reader[2].ToString(),
                           (reader[3].ToString()),
                           (reader[4].ToString()),
                           (reader[5].ToString())

                           ));
                    }
                    Notes result = new Notes("TAKENCARS", pages);
                    json1 = JsonConvert.SerializeObject(result);


                }
                else
                    error = "Ошибка! У вас нет записей!";
                reader.Close();
                connection.Close();
            }
            catch
            {
                error = "Ошибка! Сервер не смог получить данные из БД";
                connection.Close();
            }
            return json1 != null ? json1 : error;

        }



        public string InfoAboutOrdersNE(string json)
        {
            Console.WriteLine("Метод AddToOrders вызван");

            Notes obj = JsonConvert.DeserializeObject<Notes>(json);

            string json1 = null;
            string error = null;
            string query = $"SELECT * FROM  [dbo].[Read] WHERE id_for_user = '{obj.user.id}' and reads = 'Хочу прочитать'";
            List<ForBook> pages = new List<ForBook>();
            SqlConnection connection = new SqlConnection(connectString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        pages.Add(new ForBook(
                           Convert.ToInt32(reader[0].ToString()),
                           Convert.ToInt32(reader[1].ToString()),
                           reader[2].ToString(),
                           (reader[3].ToString()),
                           (reader[4].ToString()),
                           (reader[5].ToString())

                           ));
                    }
                    Notes result = new Notes("TAKENCARS", pages);
                    json1 = JsonConvert.SerializeObject(result);


                }
                else
                    error = "Ошибка! У вас нет записей!";
                reader.Close();
                connection.Close();
            }
            catch
            {
                error = "Ошибка! Сервер не смог получить данные из БД";
                connection.Close();
            }
            return json1 != null ? json1 : error;

        }







        public void  Ubrat(string json)
        {
            Console.WriteLine("Метод AddToOrders вызван");

            Notes obj = JsonConvert.DeserializeObject<Notes>(json);

            Console.WriteLine("Метод AddToOrders вызван");
            string query = $"UPDATE  [dbo].[Read] SET reads = 'Прочитал' WHERE id_for_user = '{obj.id}' and   author = '{obj.author}' and title = '{obj.title}' ";

            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            connection.Close();

        }
    }
}
