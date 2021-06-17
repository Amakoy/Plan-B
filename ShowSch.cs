using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_B
{
    public class ShowSchedule
    {
        public static void showSchedule(Activity[] act, int n)
        {
            Console.WriteLine("================= Your Activities =================\n");
            for (int i = 0; i < n; i++)
            {
                while (act[i].Name == "kosong")
                {
                    i += 1;
                    if (act[i] == null) break;
                }
                if (act[i] == null) break;
                Console.WriteLine("{0}, Kategori: {1}, Waktu: {2}", act[i].Name, act[i].Category, act[i].Dt);
            }
            Console.WriteLine("====================================================");
        }

    }

    public class ShowCat : ShowSchedule
    {
        new public static void showSchedule(Activity[] act, int n)
        {
            int[] j = new int[30];
            int c = 0;
            Console.WriteLine("Kategori yang ingin di cari:");

            string kateg = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (String.Equals(kateg, act[i].Category, StringComparison.InvariantCultureIgnoreCase))
                {
                    j[c] = i;
                    c++;
                }
            }

            Console.WriteLine("================= Your Activities =================\n");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("{0}, Kategori: {1}, Waktu: {2}", act[j[i]].Name, act[j[i]].Category, act[j[i]].Dt);
            }
            Console.WriteLine("====================================================");
        }
    }
}
