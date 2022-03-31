using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly Services.IToDoService _toDoService;


        public ToDoController(Services.IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet("/hello")]   
        public string getHello()
        {
            return _toDoService.Hello();
        }
        
        [HttpGet("qwerty")]   
        public string GetQwerty()
        {
            return "qwertyuiop[";
        }

        [HttpGet("/task/{id}")]
        public Models.ToDoTask GetTask(int id)
        {
            return _toDoService.GetFromList(id);
        }

        [HttpPost("post")]
        public void PostTask(Models.ToDoTask task)
        {
            _toDoService.AddTask(task);
        }

        [HttpDelete("/delete/{id}")]
        public Models.ToDoTask DeleteTask(int id)
        {
            return _toDoService.DeleteFromList(id);
        }
    }
}
