using HomeWorkPractice.Model;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HomeWorkPractice.Servies
{
    public class jsonFileGymService
    {
        // Json -> Program
        // Need a vraiable for home/root address & then generate file address & then do file handling
        
        public IWebHostEnvironment WebHostEnvironment { get; set; }

        // Set Actual Hosting Environment  E.g: [Here We don't know the environment](?) / Our file name
        public jsonFileGymService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // Generate File Address
        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "gym.json");
            }
        }

        // File Handling
        public IEnumerable<Gym> getRecord()
        {
            using (var filestream = File.OpenText(fileAddress))
            {
                return JsonSerializer.Deserialize<Gym[]>(filestream.ReadToEnd());
            }
        }
    }
}
