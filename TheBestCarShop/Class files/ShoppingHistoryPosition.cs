using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestCarShop.Class_files
{
    public class ShoppingHistoryPosition
    {
        public DateTime ReceivedDate { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(ReceivedDate);
            Console.WriteLine(SentDate);
            Console.WriteLine(DeliveredDate);
            Console.WriteLine(Name);
            Console.WriteLine(Price);
            Console.WriteLine(Quantity);
            Console.WriteLine();
        }
    }
}
