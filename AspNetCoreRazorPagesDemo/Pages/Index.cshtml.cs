using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreRazorPagesDemo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreRazorPagesDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
       

        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ViewResult OnGet()
        {
          
            
        }
    }
}
