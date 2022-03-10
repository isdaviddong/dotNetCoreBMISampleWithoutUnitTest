using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebBMI.Pages
{
    public class IndexModel : PageModel
    {
        public float BmiResult = 0;

        [BindProperty]
        public int fieldHeight { get; set; }
        [BindProperty]
        public int fieldWeight { get; set; }

        public void OnGet()
        {

        }

        public void OnPostCalculate()
        {
            HealthMgr.BmiCalculator bc = new HealthMgr.BmiCalculator();

            bc.Height = fieldHeight;
            bc.Weight = fieldWeight;

            BmiResult = bc.Calculate() ;
        }
    }
}