using System;
namespace homework_d1
{
	public class Surgeon: Doctor
    {
		public String bodyPart;
		public Surgeon(String name, String bodyPart): base(name)
		{
			this.bodyPart = bodyPart;
		}

		override public void Treat()
		{
			Console.WriteLine("Surgeon treats " + name + " " + bodyPart);
		}
		
	}
}

