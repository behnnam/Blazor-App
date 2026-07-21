using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool Status { get; set; } = false;
        public List<News> news { get; set; }

    }
}
