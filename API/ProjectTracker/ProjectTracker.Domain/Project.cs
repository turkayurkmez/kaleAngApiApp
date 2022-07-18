using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Domain
{
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? ExpectedFinishedDate { get; set; }
        public DateTime? ActualFinishedDate { get; set; }

        public double CompletedRate { get; private set; }

        //Bir projenin birden fazla task'ı olabilir.
        //Bir proje, bir kategoriye aittir.

        public ICollection<ProjectTask> Tasks { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }



    }
}
