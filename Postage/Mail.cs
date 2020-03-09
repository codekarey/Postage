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

    }
}
