using System;
namespace homework_d1
{
	public class Dentist : Doctor
    {
		public Dentist(String name): base(name)
		{

		}
        public void DentistInfo()
        {
            Console.WriteLine("Dentist" + name);
        }
    }
}

