using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Model
{
    /// <summary>
    /// Project Model class.
    /// </summary>
    public class ProjectModel : INotifyPropertyChanged
    {
        #region Private Vraiables
        private bool _isProjectSelected;
        private int _projectID;
        private string _projectName;
        private ObservableCollection<TaskModel> _taskModelList;
        private ObservableCollection<RiskModel> _riskModelList;

        #endregion

        #region Properties

        public int ProjectID
        {
            get { return _projectID; }
            set
            {
                _projectID = value;
                this.OnPropertyChanged("ProjectID");
            }
        }

        public string ProjectName
        {
            get { return _projectName; }
            set
            {
                _projectName = value;
                this.OnPropertyChanged("ProjectName");
            }
        }

        public bool IsProjectSelected
        {
            get { return _isProjectSelected; }
            set
            {
                _isProjectSelected = value;
                this.OnPropertyChanged("IsProjectSelected");
            }
        }

        public ObservableCollection<TaskModel> Task
        {
            get { return _taskModelList; }
            set { _taskModelList = value; }
        }

        public ObservableCollection<RiskModel> Risk
        {
            get { return _riskModelList; }
            set { _riskModelList = value; }
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
