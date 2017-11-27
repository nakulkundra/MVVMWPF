using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodingExcercise.Data
{
    [Serializable, XmlRoot("Tasks"), XmlType("Tasks")]
    public class TaskRoot
    {
        #region Private Variables

        private List<Task> _tasks = null;

        #endregion

        #region Constructor

        public TaskRoot()
        {
            _tasks = new List<Task>();
        }
        #endregion

        #region Properties

        /// <summary>
        /// XML Root Element for Tasks.xml file.
        /// </summary>
        [XmlElement("Task")]
        public List<Task> Tasks
        {
            get { return _tasks; }
            set { _tasks = value; }
        }

        #endregion
    }
}
