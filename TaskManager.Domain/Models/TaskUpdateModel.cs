using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.Domain.Models
{
	public class TaskUpdateModel
	{
		public Task Task { get; set; }
		public string UpdatedBy { get; set; }
	}
}
