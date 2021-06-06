using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductScenario
{
   public class product
    {
        public string Id { get; set; }
        public decimal price { get; set; }


        public product(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.price = 50m;

                    break;

                case "B":
                    this.price = 30m;

                    break;

                case "C":
                    this.price = 20m;

                    break;
                case "D":
                    this.price = 2015m;

                    break;


            }


        }
    }
}
