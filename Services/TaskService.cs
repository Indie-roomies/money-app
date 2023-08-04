namespace moneyapp.Services
{
    public interface ITaskService
    {
        List<TaskModel> GetTasks();
        void AddTask(TaskModel task);
    }
    public class TaskService
    {

    }
}
