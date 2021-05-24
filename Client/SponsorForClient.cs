using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Lifetime;

namespace Client
{
    public class SponsorForClient : MarshalByRefObject, ISponsor
    {
        private DateTime LRenewal;
        int time = 0;
        public SponsorForClient()
        {
            Console.WriteLine("Sponsor has been created. ");
            LRenewal = DateTime.Now;
        }
        public TimeSpan Renewal(ILease lease)
        {
            time++;
            Console.WriteLine("Renewal method of sponsor has been evoked {0} times.", time);
            Console.WriteLine("Time since last call: " + (DateTime.Now - LRenewal).ToString());
            LRenewal = DateTime.Now;
            return TimeSpan.FromSeconds(100);
        }
    }
}
