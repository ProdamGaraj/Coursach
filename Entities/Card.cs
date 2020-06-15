using System;

namespace Entities
{
    public class Card : AuditableEntity
    {
        public long CardNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; } 

        public Card(long cardNo, string name, string lastName, string mobilePhone, string email, string gender){
            CardNo = cardNo;
            Name = name;
            LastName = lastName;
            MobilePhone = mobilePhone;
            Email = email;
            Gender = gender;
        }
        public Card()
        {

        }
    }
}
