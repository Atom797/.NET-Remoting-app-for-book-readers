using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteIn
{
    public interface Iremote
    {       
        string Authorization(string json);
        string Registration(string json);
    }
}
