using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class AirPost : IPostType
    {
        public string name { get; set; } = "Наземная почта";

        public ITransport GetTransport(bool trainDelivery)
        {
            return new Airplane();
        }
    }
}
