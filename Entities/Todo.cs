using System;

namespace Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public DateTime Deadline { get; set; }
        public String Description { get; set; }
        public bool IsDone { get; set; }
    }
}
