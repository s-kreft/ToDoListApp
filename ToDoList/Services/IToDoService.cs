using ToDoList.Models;

namespace ToDoList.Services
{
    public interface IToDoService
    {
        void AddTask(ToDoTask task);
        ToDoTask DeleteFromList(int id);
        ToDoTask GetFromList(int id);
        ToDoTask GetTask();
        string Hello();

        void PutInDB();


    } 
}