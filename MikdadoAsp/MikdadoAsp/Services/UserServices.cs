using Mikado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mikado.Services
{
    public class UserServices
    {

        public string AddUser(User _user)
        {
            using (var db = new MikadoDbContext())
            {
                if (db == null)
                {
                    return "the connection to the databse failed";
                }

                if (_user == null)
                {
                    return "the user is null";
                }

                if (String.IsNullOrEmpty(_user.Email))
                {
                    return "the media have empty parameter";
                }

                db.Users.Add(_user);
                db.SaveChanges();

                throw new NotImplementedException("Not fully implemented.");
            }
        }

        public User GetUser(int _userId)
        {
            using (var db = new MikadoDbContext())
            {
                var myUser = db.Users.Where(m => m.UserId == _userId).ToList();
                return myUser[0];
            }
        }

        public string DeleteMedia( int _userId)
        {
            using (var db = new MikadoDbContext())
            {
                User userToDelete = GetUser(_userId);
                db.Users.Remove(userToDelete);
                db.SaveChanges();
            }
                throw new NotImplementedException("Not fully implemented.");
        }
    }
}
