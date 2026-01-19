using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen4ik
{
    internal class Achievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsUnlocked { get; set; }

        public Achievement(int id, string name, string description, bool isUnlocked = false)
        {
            Id = id;
            Name = name;
            Description = description;
            IsUnlocked = isUnlocked;
        }

    }
}
