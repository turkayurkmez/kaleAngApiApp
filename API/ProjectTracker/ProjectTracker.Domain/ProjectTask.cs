using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Domain
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? ExpectedDate { get; set; }


        public int? ProjectId { get; set; }
        public Project Project { get; set; }



    }
}
