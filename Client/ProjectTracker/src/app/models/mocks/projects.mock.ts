import { Project } from "../project.model";
import { ProjectTask } from "../projectTask.model";

export const Projects: Project[] = [
    new Project(1, 'yetkilendirme SİSTEMİ','Sahte Açıklama 1', new Date(2022,6,15),0.25,1,
    [
        new ProjectTask(1,'Sahte görev 1','Açıklama 1', false,new Date(2022,7,10)),
        new ProjectTask(2,'Sahte görev 2','Açıklama 2', false,new Date(2022,7,15)),

    ]
    ),
    new Project(2, 'ödeme sistemleri','Sahte Açıklama 2', new Date(2022,6,15),0.25,1,
    [
        new ProjectTask(3,'Sahte görev 3','Açıklama 3', true,new Date(2022,7,10)),
        new ProjectTask(4,'Sahte görev 4','Açıklama 4', true,new Date(2022,7,15)),

    ]
    )
]