using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class LandPost : IPostType
    {
        public string name { get; set; } = "Наземная почта";

        public ITransport GetTransport(bool trainDelivery)
        {
            if (trainDelivery) return new Train();
            return new Car();
        }
    }
}
