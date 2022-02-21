using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB1001_Assignment1.Pages
{
    public class IntroModel : PageModel
    {
        [FromQuery(Name = "Number1")]
        public int Number1
        {
            get;
            set;
        }

        [FromQuery(Name = "Number2")]
        public int Number2
        {
            get;
            set;
        }

        public void OnGet()
        {
        }
    }
}
