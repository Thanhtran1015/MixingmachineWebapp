using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IoT.Web.Models
{
    public interface IRPMDisplayDataRepository
    {
        Task Add(RPMDisplayData rPMDisplayData);
        Task Update(RPMDisplayData rPMDisplayData);
        Task Delete(string id);
        Task<RPMDisplayData> GetRPMDisplayData(string id);
        Task<RPMDisplayData> GetRPMDisplayData();
        Task<IEnumerable<RPMDisplayData>> GetRPMDisplayDatas();
    }
}