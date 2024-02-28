namespace Mission08_MichaelNateJeffersonBen.Models
{
    public interface ITaskRepository
    {
        List<TaskData> TaskData { get; }

        public void AddTask(TaskData task);
        public void Delete(TaskData task);

        public void Update(TaskData task);
    }
}
