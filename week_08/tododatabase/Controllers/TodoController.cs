using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tododatabase.Models;

namespace tododatabase.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        public TodoController(ApplicationContext applicationcontext)
        {
            this.applicationcontext = applicationcontext;
        }

        private Todo todo;
        //private List<Todo> todos;
        private ApplicationContext applicationcontext;

        [Route("")]
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [Route("List")]
        public IActionResult List()
        {
            List<Todo> todos;
            using (var context = applicationcontext)
            {
                todos = context.Todos.ToList();
            }

            return View(todos);
        }

        [Route("Active")]
        public IActionResult Active()
        {
            List<Todo> todos;
            using (var context = applicationcontext)
            {
                todos = context.Todos.Where(p => p.IsDone == false).ToList();
            }

            return View(todos);
        }
        [Route("addTodo")]
        public IActionResult AddTodo()
        {
            return View();
        }

        [HttpPost("addTodo")]
        public IActionResult AddTodo(string title)
        {
            using (var context = applicationcontext)
            {
                var todo = new Todo();
                todo.Title = title;
                context.Todos.Add(todo);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
        [HttpGet("{id}/delete")]
        public IActionResult DeleteTodo([FromRoute]long id)
        {
            using (var context = applicationcontext)
            {
                context.Todos.Remove(context.Todos.Find(id));
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit([FromRoute]long id)
        {
            Todo todoToChange;
            using (var context = applicationcontext)
            {
                todoToChange = context.Todos.Find(id);
            }
            return View(todoToChange);
        }
        [HttpPost("{id}/edit")]
        public IActionResult Edit([FromRoute]long id, string title, bool isUrgent, bool isDone, string description)
        {
            using (var context = applicationcontext)
            {
                var changed = context.Todos.Find(id);
                changed.Title = title;
                changed.IsUrgent = isUrgent;
                changed.IsDone = isDone;
                changed.Description = description;
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        [HttpPost("search")]
        public IActionResult Search(string search)
        {
            List<Todo> searchedTodos = new List<Todo>();
            using (var context = applicationcontext)
            {
                //searchedTodos=context.Todos.Where(p => p.Description.Contains(search)).Where(p=>p.Title.Contains(search)).ToList();
                searchedTodos.AddRange(context.Todos.ToList().Where(p => p.Title ==search));
                searchedTodos.AddRange(context.Todos.ToList().Where(p => p.Description ==search));
            }

            return View("List", searchedTodos);
        }
    }
}