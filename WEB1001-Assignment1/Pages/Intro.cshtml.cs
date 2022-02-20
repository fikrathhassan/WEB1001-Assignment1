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
        [FromQuery(Name = "number1")]
        public Double Number_1
        {
            get;
            set;
        }

        [FromQuery(Name = "number2")]
        public Double Number_2
        {
            get;
            set;
        }

        public void OnGet()
        {
        }
    }
}
