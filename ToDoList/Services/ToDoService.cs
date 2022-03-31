namespace ToDoList.Services
{
    public class ToDoService : IToDoService, IDisposable
    {
        private Dictionary<int, Models.ToDoTask> _db;
        public ToDoService()
        {
            _db = new Dictionary<int, Models.ToDoTask>();
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
            _db.Add(task1.Id, task1);
            _db.Add(task2.Id, task2);
        }
        public Models.ToDoTask GetFromList(int id)
        {
            foreach (var task in _db)
            {
                if(task.Key == id)
                {
                    return task.Value;
                }
            }
            return null;
        }
        public void DeleteFromList(int id)
        {
            if(_db.ContainsKey(id))
            {
                _db.Remove(id);
            }
        }

        public void AddTask(Models.ToDoTask task)
        {
            if(!_db.ContainsKey(task.Id))
            {
                _db.Add(task.Id, task);
            }
             
        }
    }
}
