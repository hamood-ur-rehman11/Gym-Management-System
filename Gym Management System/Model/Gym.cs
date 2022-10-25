using System.Text.Json.Serialization;
using System.Text.Json;


namespace HomeWorkPractice.Model
{
    public class Gym
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Gym>(this);
        }
    }
}
