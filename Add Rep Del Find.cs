using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_B
{
    class FindW
    {
        public static int Findw(Activity[] act, int n, string fynd) //Returns -1 if not found
        {
            int i = 0;
            for (i = 0; i < n; i++)
            {
                if (fynd.Equals(act[i].Name, StringComparison.CurrentCultureIgnoreCase) == true) return i;
            }
            return -1;
        }
    }


    public class RepSchedule
    {
        public static void Rep(Activity[] act, int n)
        {
            int i = 0;
            Console.WriteLine("Nama aktivitas yang ingin diganti: ");
            string test = Console.ReadLine();
            i = FindW.Findw(act, n, test);
            if (i == -1)
            {
                Console.WriteLine("==Silahkan ketik ulang==");
                Rep(act, n);
                return;
            }
            AddSchedule.Add(act, i);
        }
    }
    public class AddSchedule
    {
        public static void Add(Activity[] act, int i)
        {
            
            //Name
            Console.WriteLine("\n- Nama aktivitas: ");
            string name = Console.ReadLine();
            //Category
            Console.WriteLine("- Kategori aktivitas: ");
            string kateg = Console.ReadLine();
            //Time
            Console.WriteLine("-- Waktu aktivitas: ");
            Console.WriteLine("- Bulan (angka): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("- Tanggal : ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("- Jam (24h, tanpa menit): ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("- Menit: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(2021, month, date, hour, minute, 00);
            //Set
            act[i] = new Activity(name, kateg, dt);

        }
    }
    public class DelSchedule
    {
        public static void Delete(Activity[] act, int n)
        {
            int i = 0;
            while (i < 100)
            {
                i = 0;
                Console.WriteLine("Nama aktivitas yang ingin dihapus: ");
                string test = Console.ReadLine();

                i = FindW.Findw(act, n, test);
                if (i == -1)
                {
                    Console.WriteLine("==Silahkan ketik ulang==");
                    Delete(act, n);
                    return;
                }
                Console.WriteLine(i);
                Console.WriteLine("Apakah anda ingin menghapus aktivitas :");
                Console.WriteLine("||| {0}, Kategori: {1}, Waktu: {2} ? ||| 1 = Iya, 2 = Tidak, 3 = Exit", act[i].Name, act[i].Category, act[i].Dt);
                int ti = Convert.ToInt32(Console.ReadLine());

                if (ti == 1)
                {
                    act[i].Name = "kosong";
                    act[i].Category = "kosong";
                    act[i].Dt = new DateTime(0);
                    Console.WriteLine("Berhasil dihapus");
                    return;
                }
                else if (ti == 3) return;
            }
        }
    }
   
}

