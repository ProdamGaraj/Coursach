using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Coupon : AuditableEntity
    {
        [ForeignKey ("CardId")]
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
