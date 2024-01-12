using System.Linq.Expressions;
using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.Domain.Interfaces
{
	public interface ITaskRepository
	{
		Task<IEnumerable<Task>> GetAllTasksAsync();
		Task<Task> GetTaskByIdAsync(int taskId);
		System.Threading.Tasks.Task AddTaskAsync(Task task);
		System.Threading.Tasks.Task UpdateTaskAsync(Task task);
		System.Threading.Tasks.Task DeleteTaskAsync(int taskId);
	}
}
