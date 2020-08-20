using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Coupon : AuditableEntity
    {
        public string Number { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public virtual Card Card { get; set; }

        public Coupon(string number, string value, string type, Card card)
        {
            Number = number;
            Value = value;
            Type = type;
            Card = card;
        }

        public Coupon()
        {
        }
    }
}