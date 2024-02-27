namespace Mission08_MichaelNateJeffersonBen.Models
{
    public interface ITaskRepository
    {
        List<Task> TaskNames { get; }

        public void AddTask(Task task);
    }
}
