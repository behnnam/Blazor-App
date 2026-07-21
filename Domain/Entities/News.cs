using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Title   { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public User user { get; set; }

    }
}
