using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Entities
{
    public class Card : AuditableEntity
    {
        public string CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }

        public Card(
            string cardNumber,
            string firstName,
            string lastName,
            string mobilePhone,
            string email,
            string gender,
            ICollection<Coupon> coupons)
        {
            CardNumber = cardNumber;
            FirstName = firstName;
            LastName = lastName;
            MobilePhone = mobilePhone;
            Email = email;
            Gender = gender;
            Coupons = coupons;
        }

        public Card()
        {
        }
    }
}