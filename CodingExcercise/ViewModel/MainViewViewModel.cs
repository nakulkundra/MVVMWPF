using CodingExcercise.Data.Services;
using CodingExcercise.Framework;
using CodingExcercise.Framework.Interfaces;
using CodingExcercise.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingExcercise.ViewModel
{
    public class MainViewViewModel : INotifyPropertyChanged
    {
        private const string projectxml = @"Data\XMLSchema\Projects.xml";
        private const string taskxml = @"Data\XMLSchema\Tasks.xml";
        private IProjectService _projectService;
        private ITaskService _taskService;
        private IRiskService _riskService;
        private ProjectModel _currentProject;
        private ObservableCollection<RiskModel> _riskModelList;
        private ObservableCollection<TaskModel> _taskModelList;
        private ObservableCollection<ProjectModel> _projectModelList;
        private DelegateCommand _getProjectCommand;
        private DelegateCommand _getRiskCommand;
        private DelegateCommand _getTaskCommand;
        private DelegateCommand _saveProjectCommand;
        private int _projectId;

        public MainViewViewModel()
        {
            _projectService = new ProjectService();
            _riskService = new RiskService();
            _taskService = new TaskService();
            // this.LoadTasks();
            this.LoadProjects();
            // ProjectModelList = _projectService.GetProject(projectxml);
        }

        /// <summary>
        /// This method loads projects.
        /// </summary>
        private void LoadProjects()
        {
            try
            {
                List<IProject> projects = _projectService.GetProject(projectxml);
                this.CreateProjectModel(projects);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(Resource.ReservationsLoadingErrorMsg);
            }
        }

        private void LoadTasks()
        {
            try
            {
                List<ITask> tasks = _taskService.GetTask(taskxml);
                this.CreateTaskModel(tasks);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(Resource.ReservationsLoadingErrorMsg);
            }
        }

        private void CreateTaskModel(List<ITask> tasks)
        {
            foreach (ITask task in tasks)
            {
                //TaskModel taskModel = new TaskModel
                //{
                //    TaskID = task.TaskID,
                //    TaskName = task.TaskName,
                //    Status = task.Status,
                //    DueDate = task.DueDate,
                //    AssignedTo = task.AssignedTo
                //};
            }
        }

        /// <summary>
        /// Creates projectModel list to bind to the datagrid.
        /// </summary>
        /// <param name="projects">list of projects</param>
        private void CreateProjectModel(List<IProject> projects)
        {
            foreach (IProject project in projects)
            {
                ProjectModel projectModel = new ProjectModel
                {
                    ProjectName = project.ProjectName,
                    ProjectID = project.ProjectID
                };
                //foreach (IRisk risk in project.Risk)
                //{
                //    projectModel.Risk.Add(new RiskModel { RiskID = risk.RiskID, RiskDescription = risk.RiskDescription, RiskLevel = risk.RiskLevel, Status = risk.Status, MitigationPlan = risk.MitigationPlan });
                //}
                //foreach (ITask task in project.Task)
                //{
                //    // projectModel.Task.Add(new TaskModel { TaskID = task.TaskID, TaskName = task.TaskName, DueDate = task.DueDate, Status = task.Status, AssignedTo = task.AssignedTo });
                //}

                ProjectModelList.Add(projectModel);
            }
        }

        public ProjectModel CurrentProject
        {
            get { return _currentProject; }
            set
            {
                if (value != _currentProject)
                {
                    _currentProject = value;
                    OnPropertyChanged("CurrentProject");
                }
            }
        }

        //public DelegateCommand SaveProductCommand
        //{
        //    get
        //    {
        //        if (_saveProjectCommand == null)
        //        {
        //            _saveProjectCommand = new DelegateCommand(
        //                param => SaveProduct(),
        //                param => (CurrentProduct != null)
        //            );
        //        }
        //        return _saveProjectCommand;
        //    }
        //}

        public DelegateCommand GetProductCommand
        {
            get
            {
                if (_getProjectCommand == null)
                {
                    //_getProjectCommand = new DelegateCommand(
                    //    param => GetProduct(),
                    //    param => ProjectId > 0
                    //);
                }
                return _getProjectCommand;
            }
        }

        public DelegateCommand GetTaskCommand
        {
            get
            {
                if (_getTaskCommand == null)
                {
                    //_getTaskCommand = new DelegateCommand(
                    //    param => GetProduct(),
                    //    param => ProjectId > 0
                    //);
                }
                return _getTaskCommand;
            }
        }

        public DelegateCommand GetRiskCommand
        {
            get
            {
                if (_getRiskCommand == null)
                {
                    //_getRiskCommand = new DelegateCommand(
                    //    param => GetProduct(),
                    //    param => ProjectId > 0
                    //);
                }
                return _getRiskCommand;
            }
        }

        public int ProjectId
        {
            get { return _projectId; }
            set
            {
                if (value != _projectId)
                {
                    _projectId = value;
                    OnPropertyChanged("ProjectId");
                }
            }
        }
        
        public ObservableCollection<ProjectModel> ProjectModelList
        {
            get { return _projectModelList; }
            set { _projectModelList = value; }
        }

        public ObservableCollection<TaskModel> TaskModelList
        {
            get { return _taskModelList; }
            set { _taskModelList = value; }
        }

        public ObservableCollection<RiskModel> RiskModelList
        {
            get { return _riskModelList; }
            set { _riskModelList = value; }
        }

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
