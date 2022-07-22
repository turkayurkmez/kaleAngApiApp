/* 
 public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? ExpectedDate { get; set; }
*/

export class ProjectTask{
    constructor(
        public id?:number,
        public name?:string,
        public description?:string,
        public isCompleted?:boolean,
        public expectedDate?:Date
    ){}
}