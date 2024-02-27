using SQLitePCL;

namespace Mission08_MichaelNateJeffersonBen.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private TaskDataContext _context;
        public EFTaskRepository(TaskDataContext temp)
        {
            _context = temp;
        }

        public List<Task> TaskNames => _context.TaskNames.ToList();

        public void AddTask(Task task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }
    }
}
