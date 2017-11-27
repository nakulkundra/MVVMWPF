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
    /// This class maps to the Project element in the Project.xml file.
    /// </summary>
    [XmlType("Project")]
    public class Project : IProject
    {

        #region Private Variables

        // private List<Task> _task;
        private List<Risk> _risk;
        private int _projectID;
        private string _projectName;

        #endregion

        #region Properties

        /// <summary>
        /// Project ID
        /// </summary>
        [XmlAttribute]
        public int ProjectID
        {
            get { return _projectID; }
            set { _projectID = value; }
        }


        /// <summary>
        /// Project Name
        /// </summary>
        [XmlAttribute]
        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        /// <summary>
        /// Task
        /// </summary>
        //[XmlAttribute]
        //public List<Task> Task
        //{
        //    get { return _task; }
        //    set { _task = value; }
        //}

        /// <summary>
        /// Risk
        /// </summary>
        [XmlAttribute]
        public List<Risk> Risk
        {
            get { return _risk; }
            set { _risk = value; }
        }

        #endregion
        
    }
}
