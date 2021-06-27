using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SingleStoneExercise.Models
{
	public class Phone1
	{
		public Phone1()
		{

		}
		public int Id { get; set; }
		public string Number { get; set; }
		public string Type { get; set; }

		//public int AddressId { get; set; }
		//public virtual Address Address { get; set; }
	}
}
