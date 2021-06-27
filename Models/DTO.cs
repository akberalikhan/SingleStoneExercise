using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SingleStoneExercise.Models
{
	public class DTO
	{
		public DTO()
		{
		}

		public Name1 name { get; set; }
		public Address1 address { get; set; }
		public List<Phone1> phone { get; set; }
		public string email { get; set; }
		}
}
