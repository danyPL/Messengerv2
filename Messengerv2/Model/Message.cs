using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messengerv2.Model
{
    public class Message
    {
        public string Sender { get; set; }
        public string Text { get; set; }
        public bool setByUser { get; set; }
    }
}
