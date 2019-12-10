using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcUI.Models.Entities;

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