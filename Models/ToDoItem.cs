using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models
{
	[Table("todoItem")]
	public class ToDoItem
	{
		[Key]
		public string Key { get; set; }

		public string Name { get; set; }

		public bool IsComplete { get; set; }
	}
}

