using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.DTO
{
    public class TodoitemDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
