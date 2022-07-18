using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Dtos.Responses
{
    public class ProjectListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartedDate { get; set; }
        public double CompletedRate { get; set; }

        public IEnumerable<ProjectTaskListResponse> Tasks { get; set; }


    }
}
