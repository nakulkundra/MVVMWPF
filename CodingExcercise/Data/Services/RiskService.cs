using CodingExcercise.Framework;
using CodingExcercise.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Data.Services
{
    /// <summary>
    /// This class exposes functionalities needed for adding,editing,deleting risks.
    /// </summary>
    public class RiskService : IRiskService
    {
        #region Private Variables

        private RiskRoot _riskRoot;

        #endregion

        #region Constructor

        public RiskService()
        {
            _riskRoot = new RiskRoot();
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Adds new Risk object to the root list
        /// </summary>
        /// <param name="risk">IRisk object</param>
        public void AddRisk(IRisk risk)
        {
            _riskRoot.Risks.Add(risk as Risk);
        }

        /// <summary>
        /// Removes risk object from the root list
        /// </summary>
        /// <param name="risk">IRisk object</param>
        public void RemoveRisk(IRisk risk)
        {
            Risk riskTobeRemoved = _riskRoot.Risks.Where(r => r.RiskID == risk.RiskID).FirstOrDefault();
            _riskRoot.Risks.Remove(riskTobeRemoved);
        }

        /// <summary>
        /// Saves Risks XML file.
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <returns>bool flag </returns>
        public bool SaveRisk(string filePath)
        {
            bool riskSaved = false;
            try
            {
                riskSaved = XMLHelper.Serialize<RiskRoot>(filePath, _riskRoot);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return riskSaved;
        }

        /// <summary>
        /// Gets IRisk object 
        /// </summary>
        /// <returns></returns>
        public IRisk GetRiskObject()
        {
            return new Risk();
        }

        /// <summary>
        /// Gets  risks
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public List<IRisk> GetRisk(string filepath)
        {
            List<IRisk> risks;
            try
            {
                _riskRoot = XMLHelper.DeSerialize<RiskRoot>(filepath);
                risks = new List<IRisk>();
                if (_riskRoot != null)
                {
                    foreach (var risk in _riskRoot.Risks)
                    {
                        risks.Add(risk as IRisk);                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return risks;

        }

        /// <summary>
        /// Edits risks
        /// </summary>
        /// <param name="risk"></param>
        public void EditTask(IRisk risk)
        {
            Risk riskTobeEdited = _riskRoot.Risks.Where(r => r.RiskID == risk.RiskID).FirstOrDefault();
            if (riskTobeEdited != null)
            {
                riskTobeEdited.RiskDescription = risk.RiskDescription;
                riskTobeEdited.RiskLevel = risk.RiskLevel;
                riskTobeEdited.MitigationPlan = risk.MitigationPlan;
                riskTobeEdited.Status = risk.Status;
                // taskTobeEdited.Project = (risk as Risk).Project;
            }
        }

        #endregion

    }
}
