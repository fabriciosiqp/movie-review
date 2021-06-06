using MovieReview.Core.DomainObjects;
using System;

namespace MovieReview.Domain.Entities
{
    public class User : Entity
    {

        protected User() { }

        public User(string name, string email, string password, bool isAdmin)
        {
            Name = name;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; } = false;


        public void Disable()
        {
            DeletedAt = DateTime.UtcNow;
        }
    }
}
