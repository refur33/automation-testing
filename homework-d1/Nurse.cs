using System;
using System.Xml.Linq;

namespace homework_d1
{
	public class Nurse: Doctor
    {
        public string nurSpecialisation;
        public Nurse(String name, String nurSpecialisation) : base(name)
		{
            this.nurSpecialisation = nurSpecialisation;
        }

        public void NurseInfo()
        {
            Console.WriteLine("Nurse " + name + "works in " + nurSpecialisation);
        }

        //override public void Treat()
        //{
        //    Console.WriteLine("Therapist treats " + name);
        //}

    }
}

