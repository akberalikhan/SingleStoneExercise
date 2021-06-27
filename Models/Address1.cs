using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SingleStoneExercise.Models
{
	public class Address1
	{
		public Address1()
		{
			
		}
	
		public int Id { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
      

	}
}
