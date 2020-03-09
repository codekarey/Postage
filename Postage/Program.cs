using System;

namespace Postage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USPS Mailing & Shipping Prices");
            bool loop = true;
            while (loop)
            {
                string type = Get("What will you be mailing?\n" +
                    "1 - Enter Size & Shape   2  - Size and Shape Information");
                switch (type)
                {
                    case "1":
                        decimal h = decimal.Parse(Get("Enter the length"));
                        decimal l = decimal.Parse(Get("Enter the height"));
                        decimal t = decimal.Parse(Get("Enter the thickness"));
                        decimal w = decimal.Parse(Get("Enter the weight"));
                        Mail mailItem =  new Mail(h, l, t, w);

                        break;
                    case "2":
                        Console.WriteLine("These details define the shape and size of mailpiece options:\n" +
                            "POSTCARD : Rectangular & (At least: 3-1/2 inches high x 5 inches long x 0.007 inch thick) - (No more: than 4 - 1 / 4 inches high x 6 inches long x 0.016 inches thick)\n" +
                            "LETTER : Rectangular (At least: 3 - 1 / 2 inches high x 5 inches long x 0.007 inch thick.) - (No more than 6 - 1 / 8 inches high x 11 - 1 / 2 inches long x 1 / 4 inch thick.)\n" +
                            "ENVELOPE : (Have one dimension that is greater than: 6 - 1 / 8 inches high OR 11 -½ inches long OR ¼ inch thick.)&(Be no more than: 12 inches high x 15 inches long x ¾ inch thick.)\n" +
                            "PARCEL : Maximum weight is 70 pounds. (At least: 3 inches high x 6 inches long x 1 / 4 inch thick.) - (Less than: 108 inches in length and girth combined.Length is the measurement of the longest dimension and girth is the distance around the thickest part(perpendicular to the length))\n" +
                            "If you need more information check out : https://www.usps.com/business/prices.htm");
                       break;
                    default:
                        Console.WriteLine("Please enter the #");
                        break;
                }
            }
        }
        public static string Get(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

    }
}
