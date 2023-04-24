using Microsoft.AspNetCore.Mvc;
using Models.TodoItem;

namespace Controllers.TodoController{
    [ApiController]
    [Route("/api/[controller]")]
    public class TodoController : ControllerBase
    {
        public TodoController()
        {
            
        }

        [Route("[method]")]
        public List<TodoItem> getAll(){
            var list = new List<TodoItem>();
            


            return list;
        }
    }
}