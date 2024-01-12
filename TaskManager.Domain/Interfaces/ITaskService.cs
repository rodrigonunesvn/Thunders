using TaskManager.Domain.Models;
using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.Domain.Interfaces
{
	public interface ITaskService
	{
		Task<IEnumerable<Task>> GetAllTasksAsync();
		Task<Task> GetTaskByIdAsync(int taskId);
		System.Threading.Tasks.Task CreateTaskAsync(Task task);
		System.Threading.Tasks.Task UpdateTaskAsync(Task task, string updatedBy);
		System.Threading.Tasks.Task DeleteTaskAsync(int taskId);
	}
}
