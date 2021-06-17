using System;

namespace Plan_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity[] act = new Activity[100];
            int cek = 0;
            int show;
            int n = 0;
            int i = 0;
            Teks texto = new Teks();

            Load.Loads(act, ref i, ref n);
            
            while (cek == 0)
            {
                int cond = texto.Opening();

                if (cond == 1) //Add
                {
                    AddSchedule.Add(act, i);
                    i++;
                    n++;
                }

                else if (cond == 2) //Show
                {
                    Console.WriteLine("1 = Semua, 2 = Berdasarkan Kategori");
                    show = Convert.ToInt32(Console.ReadLine());
                    if (show == 1) ShowSchedule.showSchedule(act, n); //show all
                    else if (show == 2) //show category
                    {
                        ShowCat.showSchedule(act, n);
                    }
                }
                else if (cond == 3) DelSchedule.Delete(act, n); //Delete

                else if (cond == 4) RepSchedule.Rep(act, n); //Replace

                else if (cond == 5) //Exit
                {
                    texto.Thanks();
                    cek = 1; 
                }
            }
        }
    }
}
