using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class AllToDoModel
    {
        public List<ToDoModel> TodoList { get; set; }
        public ToDoModel Todo { get; set; }
    }
}