using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLinkUI
{
    public class WLServerResponse
    {
        public bool worked { get; }
        public dynamic info { get; }
        public WLServerResponse(bool worked, dynamic info)
        {
            this.worked = worked;
            this.info = info;
        }
    }
}
