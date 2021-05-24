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
    public class A_and_R : MarshalByRefObject, Iremote

    {
        string connectString = @"Data Source=DESKTOP-MAEK2VM\SQLEXPRESS;Initial Catalog=book;Integrated Security = True";
        public A_and_R()
        {
            Console.WriteLine("Объект EnterR создан");
        }
        ~A_and_R()
        {
            Console.WriteLine(" Объект EnterR удален");
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



        public string Authorization(string json)
        {
            Console.WriteLine("Метод вызван авторизации");

            Notes obj = JsonConvert.DeserializeObject<Notes>(json);
            string connectString = @"Data Source=DESKTOP-MAEK2VM\SQLEXPRESS ; Initial Catalog=book ;Integrated Security = True";
            string json1 = null;
            string error = null;
            string query = $"SELECT * FROM Users WHERE login = '{obj.user.login}' and password = '{obj.user.password}' ";
            SqlConnection connection = new SqlConnection(connectString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    User ExistingUser = new User(
                       Convert.ToInt32(reader[0].ToString()), reader[1].ToString(), (reader[2].ToString()), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

                    json1 = JsonConvert.SerializeObject(ExistingUser);
                }
                else
                    error = "Ошибка! Вы не правильно ввели логин или пароль";
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                error = "Ошибка! Сервер не смог получить данные из БД" + ex.Message;
                connection.Close();
            }
            if (json1 != null)
            {
                return json1;
            }
            else return error;

        }



        public string Registration(string json)
        {
            Console.WriteLine("Метод Registration вызван");

            Notes obj = JsonConvert.DeserializeObject<Notes>(json);


            string json1 = "UNREGISTERED";
            string query = $"INSERT INTO Users(name, surname, age, login, password) VALUES (" +
                $"'{obj.user.name}'," +
                $"'{obj.user.surname}'," +
                $"'{obj.user.age}'," +
                $"'{obj.user.login}'," +
                 $"'{obj.user.password}')";

            SqlConnection connection = new SqlConnection(connectString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    Notes successfulyRegistr = new Notes("SuccessfulyRegistered");
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
        


    }
}
