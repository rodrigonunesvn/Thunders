using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Models
{
	public class UserTaskCompletionModel
	{
		public string UserName { get; set; }
		public int CompletedTasksCount { get; set; }
	}
}
