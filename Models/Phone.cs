using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SingleStoneExercise.Models
{
	public class Phone
	{
		public Phone()
		{

		}
		[JsonIgnore]
		public int PhoneId { get; set; }
		public string Number { get; set; }
		public string Type { get; set; }
		[JsonIgnore]
		public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
