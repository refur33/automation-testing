using System;
namespace homework_d1
{
	public class Dentist : Doctor
    {
		public Dentist(String name): base(name)
		{

		}
        override public void Treat()
        {
            Console.WriteLine("Dentist treats " + name);
        }
    }
}

