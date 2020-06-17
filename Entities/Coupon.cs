using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Coupon : AuditableEntity
    {
        public string Number { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public Coupon(string number, string value, string type, int cardId)
        {
            Number = number;
            Value = value;
            Type = type;
            CardId = cardId;
        }
        public Coupon()
        {
                
        }
    }
}
