using MongoDB.Driver;

namespace CLUSA
{
    public class RepositorioUsers
    {
        private readonly IMongoCollection<Users> _Users;

        public RepositorioUsers()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Users = mongoDatabase.GetCollection<Users>("Users");
        }

        public List<Users> ListaUsers
        {
            get
            {
                var filter = Builders<Users>.Filter.Empty;
                return _Users.Find(filter).ToList();
            }
        }

        public async Task<List<Users>> FindAllAsync()
        {
            var filter = Builders<Users>.Filter.Empty;
            return await _Users.Find(filter).ToListAsync();
        }

        public async Task CreateAsync(Users user)
        {
            await _Users.InsertOneAsync(user);
        }

        public async Task UpdateAsync(Users user)
        {
            var filter = Builders<Users>.Filter.Eq(u => u.Id, user.Id);
            var update = Builders<Users>.Update
                .Set(u => u.Username, user.Username)
                .Set(u => u.Password, user.Password)
                .Set(u => u.Admin, user.Admin);
            await _Users.UpdateOneAsync(filter, update);
        }

        public async Task DeleteAsync(Users user)
        {
            var filter = Builders<Users>.Filter.Eq(u => u.Id, user.Id);
            await _Users.DeleteOneAsync(filter);
        }

        public Logado Login(Users user)
        {
            Logado log = new();
            var filter = Builders<Users>.Filter.Eq(g => g.Username, user.Username);
            var usuarioEncontrado = _Users.Find(filter).FirstOrDefault();

            if (usuarioEncontrado == null)
                return log;

            if (usuarioEncontrado.Password == user.Password)
            {
                log.log = true;
                log.admin = usuarioEncontrado.Admin;
            }

            return log;
        }
    }
}
