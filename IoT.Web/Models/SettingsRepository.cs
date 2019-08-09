using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IoT.Web.Models
{
    public class SettingsRepository : ISettingsRepository
    {
        MongoDbContext db = new MongoDbContext();
        public async Task Add(Settings setting)
        {
            try
            {
                await db.Settings.InsertOneAsync(setting);
            }
            catch
            {
                throw;
            }
        }
        public async Task<Settings> GetSettings(string id)
        {
            try
            {
                FilterDefinition<Settings> filter = Builders<Settings>.Filter.Eq("Id", id);
                return await db.Settings.Find(filter).FirstOrDefaultAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Settings>> GetSettingss()
        {
            try
            {
                return await db.Settings.Find(_ => true).ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task Update(Settings setting)
        {
            try
            {
                await db.Settings.ReplaceOneAsync(filter: g => g.Id == setting.Id, replacement: setting);
            }
            catch
            {
                throw;
            }
        }
        public async Task Delete(string id)
        {
            try
            {
                FilterDefinition<Settings> data = Builders<Settings>.Filter.Eq("Id", id);
                await db.Settings.DeleteOneAsync(data);
            }
            catch
            {
                throw;
            }
        }


    }
}