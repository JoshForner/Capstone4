using System;
using System.Collections.Generic;

namespace Capstone4.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDue { get; set; }
        public bool TaskComplete { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
