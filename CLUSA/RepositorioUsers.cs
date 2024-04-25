using MongoDB.Bson;
using MongoDB.Driver;

namespace CLUSA
{
    public class RepositorioUsers
    {
        private IMongoCollection<Users> _Users;

        public List<Users> ListaUsers
        {
            get
            {
                var filter = Builders<Users>.Filter.Empty;
                return _Users.Find<Users>(filter).ToList<Users>();
            }
        }
        public bool Login(string username, string password)
        {
            var filter = Builders<Users>.Filter.Eq(g => g.Username, username);
            try
            {
                var result = _Users.Find(filter).FirstOrDefault().Password;
                if(password == result)
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return false;
        }
        public void Create(Users user)
        {
            _Users.InsertOne(user);
        }

        public void Delete(Users user)
        {
            var filter = Builders<Users>.Filter.Eq("Id", user.ID);
            _Users.DeleteOne(filter);
        }
        public void Udpate(Users user)
        {
            var filter = Builders<Users>.Filter.Eq("Id", user.ID);
            var update = Builders<Users>.Update
                    .Set("Username", user.Username)
                    .Set("Password", user.Password);
            _Users.UpdateOne(filter, update);
        }
        public RepositorioUsers(Users user)
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Users = mongoDatabase.GetCollection<Users>("Users");
        }
    }
}
