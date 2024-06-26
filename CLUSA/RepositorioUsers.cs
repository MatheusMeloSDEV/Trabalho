﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.ComponentModel;

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
        public Logado Login(Users user)
        {
            Logado Log = new Logado();
            bool? resultAdmin = null;
            string? result = null;

            var filter = Builders<Users>.Filter.Eq(g => g.Username, user.Username);
            result = _Users.Find(filter)
                             .FirstOrDefaultAsync<Users>()?
                             .Result?.Password;

            var filterAdmin = Builders<Users>.Filter.Eq(g => g.Username, user.Username);
            resultAdmin = _Users.Find(filter)
                             .FirstOrDefaultAsync<Users>()
                             .Result?.Admin;

            if (result == null)
            {
                return Log;
            }
            else
            {
                if (user.Password == result)
                {
                    Log.log = true;
                    if(resultAdmin == true)
                    {
                        Log.admin = true;
                        return Log;
                    }
                    else
                    {
                        return Log;
                    }
                }
            }
            return Log;
        }
        public async Task Create(Users user, string USER)
        {
            await Task.Run(() =>
            {
                _Users.InsertOne(user);
            });
        }

        public async Task Delete(Users user, string USER)
        {
            await Task.Run(() => 
            {
                var filter = Builders<Users>.Filter.Eq("ID", user.ID);
                _Users.DeleteOne(filter);
            });
        }
        public async Task Udpate(Users user, string USER)
        {
            await Task.Run(() =>
            {
                var filter = Builders<Users>.Filter.Eq("ID", user.ID);
                var update = Builders<Users>.Update
                        .Set("Username", user.Username)
                        .Set("Password", user.Password)
                        .Set("Admin", user.Admin);
                _Users.UpdateOne(filter, update);
            });
        }
        public List<Users> FindAll()
        {
            var filter = Builders<Users>.Filter.Empty;
            return _Users.Find<Users>(filter).ToList<Users>();
        }

        public RepositorioUsers()
        {
            var mongoClient = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Trabalho");
            _Users = mongoDatabase.GetCollection<Users>("Users");
        }
    }
}
