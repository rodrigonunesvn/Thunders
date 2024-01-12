using Microsoft.AspNetCore.Mvc;
using TaskManager.Domain.Interfaces;
using TaskManager.Domain.Models;
using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TasksController : ControllerBase
	{
		private readonly ITaskService _taskService;

		public TasksController(ITaskService taskService)
		{
			_taskService = taskService;
		}

		// GET: api/tasks
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Task>>> GetTasks()
		{
			var tasks = await _taskService.GetAllTasksAsync();
			return Ok(tasks);
		}

		// GET: api/tasks/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Task>> GetTask(int id)
		{
			var task = await _taskService.GetTaskByIdAsync(id);

			if (task == null)
			{
				return NotFound();
			}

			return task;
		}

		// POST: api/tasks
		[HttpPost]
		public async Task<ActionResult<Task>> PostTask(Task task)
		{
			await _taskService.CreateTaskAsync(task);
			return CreatedAtAction(nameof(GetTask), new { id = task.TaskId }, task);
		}

		// PUT: api/tasks/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTask(int id, [FromBody] TaskUpdateModel model)
		{
			if (id != model.Task.TaskId)
			{
				return BadRequest();
			}

			try
			{
				await _taskService.UpdateTaskAsync(model.Task, model.UpdatedBy);
				return NoContent();
			}
			catch (Exception ex)
			{
				// Aqui você pode adicionar um tratamento de erro mais específico
				return BadRequest(ex.Message);
			}
		}

		// DELETE: api/tasks/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTask(int id)
		{
			var task = await _taskService.GetTaskByIdAsync(id);
			if (task == null)
			{
				return NotFound();
			}

			await _taskService.DeleteTaskAsync(id);

			return NoContent();
		}
	}
}
