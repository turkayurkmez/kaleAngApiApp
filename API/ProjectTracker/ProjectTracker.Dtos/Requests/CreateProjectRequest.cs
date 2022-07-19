using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Dtos.Requests
{
    public class CreateProjectRequest
    {
        [Required(ErrorMessage ="Proje adı belirtilmelidir")]
        [MinLength(3, ErrorMessage ="Proje adı en az 3 harften oluşmalıdır")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? ExpectedFinishedDate { get; set; }
        public int? CategoryId { get; set; }
    }
}
