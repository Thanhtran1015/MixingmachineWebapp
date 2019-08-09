using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IoT.Web.Models
{
    public class RPMDisplayDataRepository : IRPMDisplayDataRepository
    {
        MongoDbContext db = new MongoDbContext();
        public async Task Add(RPMDisplayData rPMDisplayData)
        {
            try
            {
                await db.RPMDisplayData.InsertOneAsync(rPMDisplayData);
            }
            catch
            {
                throw;
            }
        }
        public async Task<RPMDisplayData> GetRPMDisplayData(string id)
        {
            try
            {
                FilterDefinition<RPMDisplayData> filter = Builders<RPMDisplayData>.Filter.Eq("Id", id);
                return await db.RPMDisplayData.Find(filter).FirstOrDefaultAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<RPMDisplayData> GetRPMDisplayData()
        {
            try
            {
                return await db.RPMDisplayData.Find(_ => true).Limit(1).SingleAsync();
            }
            catch (Exception ex)
            {
                var mesage = ex.Message;
                throw;
            }
        }
        public async Task Update(RPMDisplayData rPMDisplayData)
        {
            try
            {
                //await db.RPMDisplayData.ReplaceOneAsync(filter: g => g.Id == rPMDisplayData.Id, replacement: rPMDisplayData);
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
                FilterDefinition<RPMDisplayData> data = Builders<RPMDisplayData>.Filter.Eq("Id", id);
                await db.RPMDisplayData.DeleteOneAsync(data);
            }
            catch
            {
                throw;
            }
        }


        public async Task<IEnumerable<RPMDisplayData>> GetRPMDisplayDatas()
        {
            try
            {
                return await db.RPMDisplayData.Find(_ => true).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}