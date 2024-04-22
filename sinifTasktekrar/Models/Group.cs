using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinifTasktekrar.Models
{
    public class Group
    {
        static int Count { get; set; } = 0;
        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public Group(string name)
        {
            Name = name;
            Id = ++Count;
        }

    }
}
