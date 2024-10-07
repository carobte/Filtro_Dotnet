using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_CarolinaBustamante.DTO.Auth
{
    public class RegisterEmployeeDTO
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string IdNumber { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
       
    }
}