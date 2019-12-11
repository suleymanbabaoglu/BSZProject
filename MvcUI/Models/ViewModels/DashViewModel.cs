using System.Linq;

namespace MvcUI.Models.ViewModels
{
    public class DashViewModel
    {
        public int pcount;
        public int ucount;
        public DashViewModel()
        {
            using (var db= new BSZContext())
            {
                pcount = db.products.Count();
                ucount = db.users.Count();

            }
        }
    }
}