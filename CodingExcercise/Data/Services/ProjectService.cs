using CodingExcercise.Framework;
using CodingExcercise.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Data.Services
{
    /// <summary>
    /// This class provided functionalities for fetching Project information.
    /// </summary>
    public class ProjectService : IProjectService
    {
        #region Public Methods
        /// <summary>
        /// Gets Project list from Project.xml file
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <returns>list of projects</returns>
        public List<IProject> GetProject(string filePath)
        {
            List<IProject> tables = new List<IProject>();
            try
            {
                // string project = XMLHelper.DeSerialize<string>(filePath);
                ProjectRoot tablesRootList = XMLHelper.DeSerialize<ProjectRoot>(filePath);

                foreach (var table in tablesRootList.Projects)
                {
                    tables.Add(table as IProject);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tables;
        }

        /// <summary>
        /// Creates a new project object
        /// </summary>
        /// <returns>IProject object</returns>
        public IProject GetProjectObject()
        {
            return new Project();
        }

        #endregion
    }
}
