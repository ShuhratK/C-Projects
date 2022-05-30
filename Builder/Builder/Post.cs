using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Post
    {
        public ITransport planDelivery(string deliveryType, bool trainDelivery = false)
        {
            IPostType postType;

            switch(deliveryType)
            {
                case "Air":
                    postType = new AirPost();
                    break;
                case "Land":
                    postType = new LandPost();
                    break;
                default:
                    throw new Exception("There is no such delivery type");
            }

            return postType.GetTransport(trainDelivery);
        }
    }
}
