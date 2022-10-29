using HomeWorkPractice.Model;
using HomeWorkPractice.Servies;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Gym_Management_System.controller
{
    public class FormHandlerController : Controller
    {
        jsonFileGymService GymService;

        public FormHandlerController(jsonFileGymService gymService)
        {
            GymService = gymService;
        }

        [HttpGet]

        public string Get(int id, string name, string image)
        {
            Gym obj = new Gym();
            obj.Gym_id = id;
            obj.image = image;
            obj.name = name;

            IEnumerable<Gym> GymRecords = GymService.getRecord();
            List<Gym> ListGymRecord = GymRecords.ToList();
            ListGymRecord.Add(obj);
            return JsonSerializer.Serialize<List<Gym>>(ListGymRecord);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
