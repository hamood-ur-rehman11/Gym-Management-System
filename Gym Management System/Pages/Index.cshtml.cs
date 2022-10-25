using HomeWorkPractice.Model;
using HomeWorkPractice.Servies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym_Management_System.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Gym> records { get; private set; }
        public jsonFileGymService Gymservice;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, jsonFileGymService gymService)
        {
            _logger = logger;
            Gymservice = gymService;
        }

        public void OnGet()
        {
            records = Gymservice.getRecord();
        }
    }
}
