using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteIn
{
   public interface Iremote_2
    {
        string NewNote(string json);
        string InfoAboutOrdersProchital(string json);
        string InfoAboutOrdersNE(string json);
        void Ubrat(string json);
    }
}
