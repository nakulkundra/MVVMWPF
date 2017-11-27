using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodingExcercise.Data
{
    [Serializable, XmlRoot("Risks"), XmlType("Risks")]
    public class RiskRoot
    {
        #region Private Variables

        private List<Risk> _risks = null;

        #endregion

        #region Constructor

        public RiskRoot()
        {
            _risks = new List<Risk>();
        }
        #endregion

        #region Properties

        /// <summary>
        /// XML Root Element for Risk.xml file.
        /// </summary>
        [XmlElement("Risk")]
        public List<Risk> Risks
        {
            get { return _risks; }
            set { _risks = value; }
        }

        #endregion
    }
}
