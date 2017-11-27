using CodingExcercise.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Model
{
    /// <summary>
    /// Task Model class
    /// </summary>
    public class TaskModel : INotifyPropertyChanged
    {
        #region Private member variables

        private int _taskID;
        private string _taskName;
        private DateTime _dueDate;
        private string _assignedTo;
        private string _status;
        private ITask _TaskObj;



        #endregion

        #region Constructor

        public TaskModel()
        {
            
        }

        #endregion

        #region Properties

        public int TaskID
        {
            get { return _taskID; }
            set
            {
                _taskID = value;
                this.OnPropertyChanged("TaskID");
            }
        }

        public string TaskName
        {
            get { return _taskName; }
            set
            {
                _taskName = value;
                this.OnPropertyChanged("TaskName");
            }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set
            {
                _dueDate = value;
                this.OnPropertyChanged("DueDate");
            }
        }


        public string AssignedTo
        {
            get { return _assignedTo; }
            set
            {
                _assignedTo = value;
                this.OnPropertyChanged("AssignedTo");
            }
        }

        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                this.OnPropertyChanged("Status");
            }
        }

        public ITask TaskObj
        {
            get { return _TaskObj; }
            set { _TaskObj = value; }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (null != PropertyChanged)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
