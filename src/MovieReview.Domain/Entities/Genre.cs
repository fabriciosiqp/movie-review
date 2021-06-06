using MovieReview.Core.DomainObjects;
using System;

namespace MovieReview.Domain.Entities
{
    public class Genre : Entity
    {

        protected Genre() {}

        public Genre(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void UpdateName(string name)
        {
            Name = name;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Disable()
        {
            DeletedAt = DateTime.UtcNow;
        }
    }
}
