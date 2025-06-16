using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_kasir.Config
{
    public class Helper
    {
        public static void backToHome(Object obj)
        {
            if(obj is Form form)
            {
                MainMenu mainMenu = new MainMenu();
                form.Hide();
                mainMenu.Show();
            }
        }
        public static void redirectTo(object obj1, object obj2)
        {
            if (obj1 is Form form && obj2 is Form form2)
            {
                form.Hide();
                form2.Show();
            }
        }
    }
}
