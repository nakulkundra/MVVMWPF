using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Framework.Interfaces
{
    /// <summary>
    /// Risk object exposed by IRisk by the DataServices module to clients.
    /// </summary>
    public interface IRisk
    {
        int RiskID { get; set; }
        string RiskDescription { get; set; }
        string RiskLevel { get; set; }
        string Status { get; set; }
        string MitigationPlan { get; set; }
        // IProject Project { get; }
    }
}
