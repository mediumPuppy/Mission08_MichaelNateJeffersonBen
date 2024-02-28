namespace Mission08_MichaelNateJeffersonBen.Models
{
    public interface ITaskRepository
    {
        List<TaskData> TaskData { get; }

        public void AddTask(TaskData task);
    }
}
