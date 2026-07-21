using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool Status { get; set; } = false;
       
    }
}
