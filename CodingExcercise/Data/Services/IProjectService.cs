using CodingExcercise.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Data.Services
{
    /// <summary>
    /// Interface which is exposed by the DataServices to clients for project related functionalities.
    /// </summary>
    public interface IProjectService
    {
        List<IProject> GetProject(string filePath);

        IProject GetProjectObject();
    }
}
