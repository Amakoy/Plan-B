using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_B
{
    public class Activity
    {
        private string name;
        private string category;
        private DateTime dt = new DateTime();
        public Activity(string Name, string Category, DateTime Dt)
        {
            name = Name;
            category = Category;
            dt = Dt;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public DateTime Dt
        {
            get { return dt; }
            set { dt = value; }
        }
    }
}
