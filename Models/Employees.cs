using System;
using System.ComponentModel.DataAnnotations;

namespace ADO_CRUD.Models
{
	public class Employees
	{
		public int  Id { get; set; }

        [Required]
		public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public string City { get; set; }
    }
}

