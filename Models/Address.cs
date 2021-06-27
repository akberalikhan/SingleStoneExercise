using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SingleStoneExercise.Models
{
	public class Address
	{
		public Address()
		{
			
		}
		[JsonIgnore]
		public int AddressId { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string email { get; set; }
		public Name Name { get; set; }
		[JsonIgnore]
		public int NameId { get; set; }
		public  ICollection<Phone> Phones { get; set; }
	}
}
