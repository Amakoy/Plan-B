using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_B
{
    public abstract class Texter
    {
        public abstract int Opening();
        public abstract void Thanks();
    }

    public class Teks : Texter
    {
        public override int Opening()
        {
            Console.WriteLine("\nMenu : \n" +
                                    "1 = Add Activity \n" +
                                    "2 = Show Schedule \n" +
                                    "3 = Delete Activity \n" +
                                    "4 = Replace Activity \n" +
                                    "5 = Exit");
            Console.WriteLine("Ketik command: ");
            int cond = Convert.ToInt32(Console.ReadLine());

            return cond;
        }

        public override void Thanks()
        {
            Console.WriteLine("==================Thank you, have a great day !==================");
        }

    }
}
