using MovieReview.Core.DomainObjects;
using System;

namespace MovieReview.Domain.Entities
{
    public class Actor : Entity
    {

        protected Actor() {}

        public Actor(string name, string biography)
        {
            Name = name;
            Biography = biography;
        }

        public string Name { get; private set; }
        public string Biography { get; private set; }

        public void UpdateName(string name)
        {
            Name = name;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateBiography(string biography)
        {
            Biography = biography;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Disable()
        {
            DeletedAt = DateTime.UtcNow;
        }
    }
}
