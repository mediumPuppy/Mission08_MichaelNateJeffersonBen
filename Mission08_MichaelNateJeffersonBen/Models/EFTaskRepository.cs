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

        public List<TaskData> TaskData => _context.TaskData.ToList();

        public void AddTask(TaskData task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public void Update(TaskData task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }
        public void Delete(TaskData task)
        {
            _context.Remove(task);
            _context.SaveChanges();
        }
    }
}
