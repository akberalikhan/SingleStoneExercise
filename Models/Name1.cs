using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SingleStoneExercise.Models
{
    public class Name1
    {
		public Name1()
		{
			
		}

		public int Id { get; set; }
		public string First { get; set; }
		public string Middle { get; set; }
		public string Last { get; set; }

		
	}
}
