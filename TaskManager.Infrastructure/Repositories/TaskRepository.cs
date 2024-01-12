using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Interfaces;
using TaskManager.Persistence.Configuration;
using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.Infrastructure.Repositories
{
	public class TaskRepository : ITaskRepository
	{
		private readonly TaskManagementContext _context;

		public TaskRepository(TaskManagementContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Task>> GetAllTasksAsync()
		{
			return await _context.Tasks
				.ToListAsync();
		}

		public async Task<Task> GetTaskByIdAsync(int taskId)
		{
			return await _context.Tasks
				.FirstOrDefaultAsync(t => t.TaskId == taskId);
		}

		public async System.Threading.Tasks.Task AddTaskAsync(Task task)
		{
			await _context.Tasks.AddAsync(task);
			await _context.SaveChangesAsync();
		}

		public async System.Threading.Tasks.Task UpdateTaskAsync(Task task)
		{
			_context.Tasks.Update(task);
			await _context.SaveChangesAsync();
		}

		public async System.Threading.Tasks.Task DeleteTaskAsync(int taskId)
		{
			var task = await GetTaskByIdAsync(taskId);
			if (task != null)
			{
				_context.Tasks.Remove(task);
				await _context.SaveChangesAsync();
			}
		}
	}
}
