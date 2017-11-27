using CodingExcercise.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcercise.Data.Services
{
    interface IRiskService
    {
        void AddRisk(IRisk risk);

        void RemoveRisk(IRisk risk);

        void EditTask(IRisk risk);

        bool SaveRisk(string filePath);

        IRisk GetRiskObject();

        List<IRisk> GetRisk(string filepath);
    }
}
