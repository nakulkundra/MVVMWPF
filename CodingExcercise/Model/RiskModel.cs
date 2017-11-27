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
    /// Risk Model class
    /// </summary>
    public class RiskModel : INotifyPropertyChanged
    {
        #region Private member variables

        private int _riskID;
        private string _riskDescription;
        private string _riskLevel;
        private string _status;
        private string _mitigationPlan;
        private IRisk _RiskObj;
        
        #endregion

        #region Constructor

        public RiskModel()
        {
        }

        #endregion

        #region Properties

        public int RiskID
        {
            get { return _riskID; }
            set
            {
                _riskID = value;
                this.OnPropertyChanged("RiskID");
            }
        }

        public string RiskDescription
        {
            get { return _riskDescription; }
            set
            {
                _riskDescription = value;
                this.OnPropertyChanged("RiskDescription");
            }
        }

        public string RiskLevel
        {
            get { return _riskLevel; }
            set
            {
                _riskLevel = value;
                this.OnPropertyChanged("RiskLevel");
            }
        }

        public string MitigationPlan
        {
            get { return _mitigationPlan; }
            set
            {
                _mitigationPlan = value;
                this.OnPropertyChanged("MitigationPlan");
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

        public IRisk RiskObj
        {
            get { return _RiskObj; }
            set { _RiskObj = value; }
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
