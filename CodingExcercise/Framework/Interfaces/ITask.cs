using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Framework.Interfaces
{
    /// <summary>
    /// Task object exposed by ITask by the DataServices module to clients.
    /// </summary>
    public interface ITask
    {
        int TaskID { get; set; }
        string TaskName { get; set; }
        string DueDate { get; set; }
        string AssignedTo { get; set; }
        string Status { get; set; }
        // IProject Project { get; }
    }
}
