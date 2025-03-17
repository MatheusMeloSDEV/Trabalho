using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLUSA
{
    public class RepositorioFatRec
    {
        private readonly IMongoCollection<FatRec> _Fatrec;
        public async Task CreateAsync(FatRec fatrec)
        {
            await _Fatrec.InsertOneAsync(fatrec);
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var filter = Builders<FatRec>.Filter.Eq("_id", id);
            await _Fatrec.DeleteOneAsync(filter);
        }

        public async Task UpdateAsync(FatRec fatrec)
        {
            await Task.WhenAll
            (
                AtualizarDocumento(_Fatrec, fatrec.Id, fatrec)

            );
        }
    }
}
