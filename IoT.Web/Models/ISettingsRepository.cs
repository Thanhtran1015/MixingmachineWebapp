using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IoT.Web.Models
{
    public interface ISettingsRepository
    {
        Task Add(Settings setting);
        Task Update(Settings setting);
        Task Delete(string id);
        Task<Settings> GetSettings(string id);
        Task<IEnumerable<Settings>> GetSettingss();
    }
}