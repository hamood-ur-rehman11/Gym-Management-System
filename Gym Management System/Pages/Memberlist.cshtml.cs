using HomeWorkPractice.Model;
using HomeWorkPractice.Servies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Gym_Management_System.Pages
{
    public class MemberlistModel : PageModel
    {

        jsonFileGymService GymService;

        public IEnumerable<Gym> Gym;

        public MemberlistModel(jsonFileGymService gymservice)
        {
            this.GymService = gymservice;
        }

        public void OnGet()
        {
            Gym = GymService.getRecord();
        }
    }
}
