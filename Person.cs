using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
	internal class Person
	{
		private int _id;
		public int Id { get; set; }

		public string Name { get; set; }
		public string Surname { get; set; }
		public byte Age { get; set; }
        public Person()
        {
            _id++;
			Id = _id;
        }

    }
}
