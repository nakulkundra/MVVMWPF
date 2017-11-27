using CodingExcercise.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExcercise.Framework.Interfaces
{
    /// <summary>
    /// Project object exposed by IProject by the DataServices module to clients.
    /// </summary>
    public interface IProject
    {
        int ProjectID { get; set; }
        string ProjectName { get; set; }
        // List<Task> Task { get; set; }
        List<Risk> Risk { get; set; }
    }
}
