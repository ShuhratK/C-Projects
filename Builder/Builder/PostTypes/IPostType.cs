using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IPostType
    {
        public string name { get; set; }
        public ITransport GetTransport(bool trainDelivery);
    }
}
