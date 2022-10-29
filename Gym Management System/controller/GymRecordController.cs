using HomeWorkPractice.Model;
using HomeWorkPractice.Servies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Collections;
using System.Collections.Generic;

namespace Gym_Management_System.controller
{
    [Route("/[controller]")]
    [ApiController]
    public class GymRecordController : ControllerBase
    {
        jsonFileGymService GymService;
        public GymRecordController(jsonFileGymService gymService)

        {
            this.GymService = gymService;

        }
        [HttpGet]
        
         public IEnumerable<Gym> Get()
        {
            return GymService.getRecord();
        }
    
    }




    }