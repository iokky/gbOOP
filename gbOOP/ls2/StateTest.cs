using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace gbOOP.ls2
{
    public class StateTest
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        
        public StateTest(string name)
        {
            Id = 1;
            this.Name = name;
        }

        public void SaveState()
        {
            File.WriteAllText("state.json", JsonSerializer.Serialize(this));
        }

        public static StateTest LoadState()
        {
            var data = File.ReadAllText("state.json");
            StateTest? result;
            try 
            {
                result = JsonSerializer.Deserialize<StateTest>(data);
            }
            catch (JsonException ex)
            {
                result = new StateTest("default");
            }
            return result;
        }

        public void Info() => Console.WriteLine($"id: {Id} name: {Name}");
    }
}
