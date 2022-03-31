namespace ToDoList.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ToDoTask(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

    }
}
