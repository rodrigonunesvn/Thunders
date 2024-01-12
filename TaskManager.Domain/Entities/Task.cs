using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Entities
{
	public class Task
	{
		public int TaskId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime DueDate { get; set; }
		public DateTime? CompletionDate { get; set; }
		public string Status { get; set; }
		public string Priority { get; set; }		
	}
}
