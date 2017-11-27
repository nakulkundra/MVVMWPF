using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodingExcercise.Data
{
    [Serializable, XmlRoot("Projects"), XmlType("Projects")]
    public class ProjectRoot
    {
        #region Private Variables

        private List<Project> _projectList;

        #endregion

        #region Properties

        /// <summary>
        /// Projects element collection
        /// </summary>
        [XmlElement("Project")]
        public List<Project> Projects
        {
            get { return _projectList; }
            set { _projectList = value; }
        }

        #endregion

        #region Conctructor

        public ProjectRoot()
        {
            this._projectList = new List<Project>();
        }
        #endregion
    }
}
