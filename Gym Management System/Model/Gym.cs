using System.Text.Json.Serialization;
using System.Text.Json;


namespace HomeWorkPractice.Model
{
    public class Gym
    {
        internal string image;

        public int id { get; set; }
        public string name { get; set; }
        public int Gym_id { get; internal set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Gym>(this);
        }
    }
}
