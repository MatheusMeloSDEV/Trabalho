using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public string Login(string username, string password)
        {
            var filter = Builders<Users>.Filter.Eq(g => g.Username, username);

            return _Users.Find<Users>(filter).ToString();
        }
        public void Create(Users user)
        {
            _Users.InsertOne(user);
        }

        public void Delete(Users user)
        {
            var filter = Builders<Users>.Filter.Eq("Id", user.Id);
            _Users.DeleteOne(filter);
        }
        public void Udpate(Users user)
        {
            var filter = Builders<Users>.Filter.Eq("Id", user.Id);
            var update = Builders<Users>.Update
                    .Set("Username", user.Username)
                    .Set("Password", user.Password);
            _Users.UpdateOne(filter, update);
        }
        public RepositorioUsers(Users user)
        {
            var mongoClient = new MongoClient(string.Concat("mongodb+srv://", user.Username, ":", user.Password, "@cluster0.cn10nzt.mongodb.net/"));
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Users = mongoDatabase.GetCollection<Users>("Users");
        }
    }
}
