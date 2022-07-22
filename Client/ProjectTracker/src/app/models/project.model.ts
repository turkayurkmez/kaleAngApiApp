import { ProjectTask } from "./projectTask.model";

/* 
  public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartedDate { get; set; }
        public double CompletedRate { get; set; }

        public int? CategoryId { get; set; }

        public ICollection<ProjectTaskListResponse> Tasks { get; set; }
*/
export class Project{
    constructor(
        public id?:number,
        public name?:string,
        public description?:string,
        public startedDate?: Date,
        public completedRate?: number,
        public categoryId?: number,
        public tasks?: ProjectTask[]

    ){

    }
}