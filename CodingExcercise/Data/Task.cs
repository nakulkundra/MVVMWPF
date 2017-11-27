using CodingExcercise.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodingExcercise.Data
{
    /// <summary>
    /// This class maps to the Task element in Task.xml file.
    /// </summary>
    [XmlType("Task")]
    public class Task : ITask
    {
        #region Private member variables

        private int _taskID;
        private string _taskName;
        private string _dueDate;
        private string _assignedTo;
        private string _status;

        // private IProject _project;

        #endregion

        //#region Properties

        ///// <summary>
        ///// Task ID 
        ///// </summary>
        [XmlElement("TaskID")]
        public int TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }


        ///// <summary>
        ///// Task Name 
        ///// </summary>
        [XmlElement("TaskName")]
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }

        ///// <summary>
        ///// DueDate
        ///// </summary>
        [XmlElement("DueDate")]
        public string DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        ///// <summary>
        ///// AssignedTo
        ///// </summary>
        [XmlElement("AssignedTo")]
        public string AssignedTo
        {
            get { return _assignedTo; }
            set { _assignedTo = value; }
        }

        ///// <summary>
        ///// Status
        ///// </summary>
        [XmlElement("Status")]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        ////[XmlElement("Project")]
        ////public IProject Project
        ////{
        ////    get { return _project; }
        ////    set { _project = value; }
        ////}

        //#endregion
    }
}
