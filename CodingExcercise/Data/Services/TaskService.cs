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
    /// This class exposes functionalities needed for adding,editing,deleting tasks.
    /// </summary>
    public class TaskService : ITaskService
    {
        #region Private Variables

        private TaskRoot _taskRoot;

        #endregion

        #region Constructor

        public TaskService()
        {
            _taskRoot = new TaskRoot();
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Adds new task object to the root list
        /// </summary>
        /// <param name="task">ITask object</param>
        public void AddTask(ITask task)
        {
            _taskRoot.Tasks.Add(task as Task);
        }

        /// <summary>
        /// Removes task object from the root list
        /// </summary>
        /// <param name="task">ITask object</param>
        public void RemoveTask(ITask task)
        {
            //Task taskTobeRemoved = _taskRoot.Tasks.Where(r => r.TaskID == task.TaskID).FirstOrDefault();
            //_taskRoot.Tasks.Remove(taskTobeRemoved);
        }

        /// <summary>
        /// Saves task into XML file.
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <returns>bool flag </returns>
        public bool SaveTask(string filePath)
        {
            bool taskSaved = false;
            try
            {
                taskSaved = XMLHelper.Serialize<TaskRoot>(filePath, _taskRoot);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return taskSaved;
        }

        /// <summary>
        /// Gets ITask object 
        /// </summary>
        /// <returns></returns>
        public ITask GetTaskObject()
        {
            return new Task();
        }


        /// <summary>
        /// Gets Tasks
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public List<ITask> GetTask(string filepath)
        {
            List<ITask> tasks;
            try
            {
                _taskRoot = XMLHelper.DeSerialize<TaskRoot>(filepath);
                tasks = new List<ITask>();
                if (_taskRoot != null)
                {
                    foreach (var task in _taskRoot.Tasks)
                    {
                        tasks.Add(task as ITask);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tasks;
        }

        /// <summary>
        /// Edits task
        /// </summary>
        /// <param name="task"></param>
        public void EditTask(ITask task)
        {
            //Task taskTobeEdited = _taskRoot.Tasks.Where(r => r.TaskID == task.TaskID).FirstOrDefault();
            //if (taskTobeEdited != null)
            //{
            //    taskTobeEdited.TaskName = task.TaskName;
            //    taskTobeEdited.DueDate = task.DueDate;
            //    taskTobeEdited.AssignedTo = task.AssignedTo;
            //    taskTobeEdited.Status = task.Status;
            //    // taskTobeEdited.Project = (task as Task).Project;
            //}
        }

        #endregion
    }
}
