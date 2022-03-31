namespace ToDoList.Services
{
    public class ToDoService : IToDoService, IDisposable
    {
        private List<Models.ToDoTask> _db;
        public ToDoService()
        {
            _db = new List<Models.ToDoTask>();
            PutInDB();
        }
        Models.ToDoTask task1 = new Models.ToDoTask(1, "task1", "testowy test");
        Models.ToDoTask task2 = new Models.ToDoTask(2, "task2", "kolejny testowy test");

        public Models.ToDoTask GetTask()
        {
            return task1;
        }
        public string Hello()
        {
            return "Hello";
        }

        public void Dispose()
        {
            Console.WriteLine("Wywolano garbage collector"); ;
        }

        public void PutInDB()
        {
            _db.Add(task1);
            _db.Add(task2);
        }
        public Models.ToDoTask GetFromList(int id)
        {
            foreach (var task in _db)
            {
                if(task.Id == id)
                {
                    return task;
                }
            }
            return null;
        }
        public Models.ToDoTask DeleteFromList(int id)
        {
            foreach(var task in _db)
            {
                if(task.Id == id)
                {
                    _db.Remove(task);
                    break;
                }
            }
            return null;
        }

        public void AddTask(Models.ToDoTask task)
        {
             _db.Add(task);
        }
    }
}
