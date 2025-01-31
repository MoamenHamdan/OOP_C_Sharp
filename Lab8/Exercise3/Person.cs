using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Person
    {
		private string  name;
		private string  address;

		public string  Address
		{
			get { return address; }
			set { address = value; }
		}


		public string  Name
		{
			get { return name; }
			set { name = value; }
		}

		public Person()
		{

		}

		public Person(string name , string address)
		{
			this.name = name;
			this.address = address;

		}
		//public override string ToString()
		//{
		//	return "Person's Name " + name + " and his address is " + address;
		//}




	}
}
