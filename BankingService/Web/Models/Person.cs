namespace Web.Models
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        [Key]
        public long Id { get; set; }

        public string HashId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public char Gender { get; set; }

        public int Age { get; set; }

        public string Pesel { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public long AccountNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return Name + ' ' + Surname;
        }
    }
}