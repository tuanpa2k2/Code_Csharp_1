using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrNames = { "Nguyễn Văn A", "Nguyễn Văn B", "Phí Anh Tuấn", "Trần Thị Thảo" };
            //C1: 

            //foreach (var x in arrNames.Where(c => c.StartsWith("P")))
            //{
            //    Console.WriteLine(x);
            //}

            //C2:
            foreach (var x in arrNames)
            {
                if (x.StartsWith("P"))
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
