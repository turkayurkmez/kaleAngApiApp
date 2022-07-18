﻿using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public class FakeProjectRepository : IProjectRepository
    {
        private List<Project> projects = new List<Project>();
        public FakeProjectRepository()
        {
            projects = new List<Project>
            {
                new Project{ Id=1, Name="Fake Project X", Description="X Description", StartedDate=DateTime.Now, Tasks = new List<ProjectTask>
                {
                    new ProjectTask{ Id=1, Name="Task A", Description="Task A From Project X", ProjectId=1},
                    new ProjectTask{ Id=2, Name="Task B", Description="Task B From Project X", ProjectId=1},

                }
            },               
                new Project{ Id=2, Name="Fake Project Y", Description="Y Description", StartedDate=DateTime.Now, Tasks = new List<ProjectTask>
                {
                    new ProjectTask{ Id=3, Name="Task C", Description="Task C From Project Y", ProjectId=2},
                    new ProjectTask{ Id=4, Name="Task D", Description="Task D From Project Y", ProjectId=2},

                }
            },
                new Project{ Id=3, Name="Fake Project Z", Description="Z Description", StartedDate=DateTime.Now, Tasks = new List<ProjectTask>
                {
                 new ProjectTask{ Id=5, Name="Task E", Description="Task E From Project Z", ProjectId=3},
                 new ProjectTask{ Id=6, Name="Task F", Description="Task F From Project Z", ProjectId=3},

                }
                        }
            };

        }
        public Task Add(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> SearchProjectsByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> SearchProjectsByCategoryName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> SearchProjectsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(Project entity)
        {
            throw new NotImplementedException();
        }
    }
}