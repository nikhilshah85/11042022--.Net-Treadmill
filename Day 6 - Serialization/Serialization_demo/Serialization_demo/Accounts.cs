using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_demo
{
    [Serializable]
    public  class Accounts
    {
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accType { get; set; }
        public double accBalance { get; set; }
        public string accEmail { get; set; }
        public bool accIsActive { get; set; }
    }
}
