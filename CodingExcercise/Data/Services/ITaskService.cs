using CodingExcercise.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Data.Services
{
    /// <summary>
    /// Interface which is exposed by the DataServices to clients for Task related functionalities.
    /// </summary>
    public interface ITaskService
    {
        void AddTask(ITask task);

        void RemoveTask(ITask task);

        void EditTask(ITask task);

        bool SaveTask(string filePath);

        ITask GetTaskObject();

        List<ITask> GetTask(string filepath);
    }
}
