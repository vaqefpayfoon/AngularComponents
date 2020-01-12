using System;

namespace Domain.Dtos
{
    public class UserForRegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }        
        public DateTime DateOfBirth { get; set; }
        public string MoreInfo { get; set; }           
        public Guid CityId { get; set; }
        public string CityName { get; set; }     
        public string UserRole { get; set; }   
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}