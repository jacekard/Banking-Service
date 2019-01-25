namespace Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Transaction
    {
        [Key]
        public long Id { get; set; }

        public long HashId { get; set; }

        [Timestamp]
        public DateTime Timestamp { get; set; }

        public double Amount { get; set; }

        public User Sender { get; set; }

        public User Receiver { get; set; }
    }
}