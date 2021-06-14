using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AdminModel : PageModel
    {
        [BindProperty]
        public string Kullan�c�Ad� { get; set; }
        [BindProperty]
        public string �ifre { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPostForm()
        {
            if (Kullan�c�Ad� == "admin" && �ifre == "123")
            {
                return RedirectToPage("/Users/Admin185746qwa"); //Kullan�c� bilgileri do�ruysa admin sayfas�na y�nlen
            }
            else
            {
                return RedirectToPage("");//yanl��sa ayn� yerde kal
            }
        }
    }
}

