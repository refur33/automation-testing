using System;
namespace homework_d1
{
	abstract public class Doctor
	{
		public String name;
		public Doctor(String name)
		{
			this.name = name;
		}
			//virtual public void Treat()
			//{
			//Console.WriteLine("Doctor treats " + name );
			//}
		abstract public void Treat();
		}
	}

