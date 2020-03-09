using System;
using System.Collections.Generic;
using System.Text;

namespace Postage
{
    class Mail
    {
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal Thick { get; set; }
        public decimal Weight { get; set; }

        public Mail(decimal length, decimal height, decimal thick, decimal weight)
        {
            Length = length;
            Height = height;
            Thick = thick;
            Weight = weight;
        }

        public static string MailType(Mail item) // w > t > h/l
        {
            string type;
            if (item.Weight < 70 && item.Height >= 3 && item.Height<=17 && item.Length >= 6 && item.Length<= 27 && item.Thick >= 1 / 4 && item.Thick<=17)
            {
                return type = "parcel";
            }
            if (item.Height<12 && item.Length<15 && item.Thick<3/4 &&(item.Height>6+1/8 || item.Length > 11+1/2 || item.Thick> 1 / 4))
            {

                    return type = "enevelope";
            }
            if (item.Height >= 3 + 1 / 2 && item.Height <= 6 + 1 / 8 && item.Length >= 5 && item.Length < 11 + 1 / 2 && item.Thick <= 1 / 4)
            {
                return type = "letter";
            }
            if(item.Height>= 3+1/2 && item.Height <=4+1/2 && item.Length>=5 && item.Length<= 6 && item.Thick>= 7/1000 && item.Thick>=16/1000 && item.Thick <= 1 / 4)
            {
                return type = "postcard";
            }

            return "No matching type";
        }
    }
}
