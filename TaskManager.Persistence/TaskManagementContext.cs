using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entities;
using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.Persistence.Configuration
{
	public class TaskManagementContext : DbContext
	{
		public TaskManagementContext(DbContextOptions<TaskManagementContext> options)
			: base(options)
		{
		}

		public DbSet<Task> Tasks { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new TaskConfiguration());
		}
	}
}
