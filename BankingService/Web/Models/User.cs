namespace Web.Models
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public long Id { get; set; }

        public long HashId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public long Pesel { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public long AccountNumber { get; set; }

        public long PhoneNumber { get; set; }
    }
}