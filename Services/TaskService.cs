namespace moneyapp.Services
{
    public interface ITaskService
    {
        List<TaskModel> GetTasks();
        void AddTask(TaskModel task);
    }
    public class TaskService : ITaskService
    {
        private List<TaskModel> _tasks = new List<TaskModel>();
        public void AddTask(TaskModel task)
        {
            _tasks.Add(task);
        }

        public List<TaskModel> GetTasks()
        {
            return _tasks;
        }
    }
}
