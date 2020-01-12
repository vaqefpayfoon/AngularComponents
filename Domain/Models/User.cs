using System; 

namespace Domain.Models
{
    public class User : Entity
    {
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FullName { get; set; }           
        public string NationalCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MoreInfo { get; set; }
        public Guid CityId { get; set; }
        public City City { get; set; }        
        public Role UserRole { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public string PhotoUrl { get; set; }
    }
}