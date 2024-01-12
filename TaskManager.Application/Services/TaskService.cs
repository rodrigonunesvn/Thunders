using TaskManager.Domain.Interfaces;
using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.Application.Services
{
	public class TaskService : ITaskService
	{
		private readonly ITaskRepository _taskRepository;

		public TaskService(ITaskRepository taskRepository)
		{
			_taskRepository = taskRepository;
		}

		public async Task<IEnumerable<Task>> GetAllTasksAsync()
		{
			return await _taskRepository.GetAllTasksAsync();
		}

		public async Task<Task> GetTaskByIdAsync(int taskId)
		{
			return await _taskRepository.GetTaskByIdAsync(taskId);
		}

		public async System.Threading.Tasks.Task CreateTaskAsync(Task task)
		{			
			await _taskRepository.AddTaskAsync(task);
		}

		public async System.Threading.Tasks.Task UpdateTaskAsync(Task task, string updatedBy)
		{
			var existingTask = await _taskRepository.GetTaskByIdAsync(task.TaskId);

			if (existingTask == null)
			{
				throw new ArgumentException("Tarefa não encontrada.");
			}

			if (existingTask.Priority != task.Priority)
			{
				throw new InvalidOperationException("Não é permitido alterar a prioridade de uma tarefa.");
			}
			
			await _taskRepository.UpdateTaskAsync(task);		
		}

		public async System.Threading.Tasks.Task DeleteTaskAsync(int taskId)
		{
			await _taskRepository.DeleteTaskAsync(taskId);
		}		
	}
}
