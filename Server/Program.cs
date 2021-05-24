using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("server.config", false);
            A_and_R enter = new A_and_R();
            RemotingServices.Marshal(enter, "Hi");

            R_and_Ur parking = new R_and_Ur();
            RemotingServices.Marshal(parking, "myIpcPort");

            Console.WriteLine("Сервер работает");
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();
        }
    }
}
