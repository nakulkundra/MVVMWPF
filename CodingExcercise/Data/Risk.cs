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
    /// This class maps to the Task element in Risk.xml file.
    /// </summary>
    [XmlType("Risk")]
    public class Risk : IRisk
    {
        #region Private member variables

        private int _riskID;
        private string _riskDescription;
        private string _riskLevel;
        private string _mitigationPlan;
        private string _status;

        // private IProject _project;

        #endregion


        #region Properties

        /// <summary>
        /// Risk ID 
        /// </summary>
        [XmlElement("RiskID")]
        public int RiskID
        {
            get { return _riskID; }
            set { _riskID = value; }
        }

        /// <summary>
        /// Risk Description 
        /// </summary>
        [XmlElement("RiskDescription")]
        public string RiskDescription
        {
            get { return _riskDescription; }
            set { _riskDescription = value; }
        }

        /// <summary>
        /// RiskLevel
        /// </summary>
        [XmlElement("RiskLevel")]
        public string RiskLevel
        {
            get { return _riskLevel; }
            set { _riskLevel = value; }
        }

        /// <summary>
        /// Mitigation Plan
        /// </summary>
        [XmlElement("MitigationPlan")]
        public string MitigationPlan
        {
            get { return _mitigationPlan; }
            set { _mitigationPlan = value; }
        }

        /// <summary>
        /// Status
        /// </summary>
        [XmlElement("Status")]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        //[XmlElement("Project")]
        //public IProject Project
        //{
        //    get { return _project; }
        //    set { _project = value; }
        //}

        #endregion
    }
}
