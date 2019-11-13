using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace tododatabase.Models
{
    public class Todo
    {
        public long Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        [DefaultValue(false)]
        public bool IsUrgent { get; set; }
        [DefaultValue(false)]
        public bool IsDone { get; set; }
       // public List<Assignee> Assignees {get;set;}

        public Todo()
        {

        }
    }
}
