using System;
using System.Xml.Linq;

namespace homework_d1
{
    public class Surgeon : Doctor
    {
        public string schedule;
        public string surgSpecialisation;

        public Surgeon(string name, string schedule, string surgSpecialisation) : base(name)
        {
            this.schedule = schedule;
            this.surgSpecialisation = surgSpecialisation;
        }

        public void SurgeonInfo()
        {
            Console.WriteLine("Surgeon " + name + "works on " + surgSpecialisation + ". His work schedule is: " + schedule);
        }
    }
}

