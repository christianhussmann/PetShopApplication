using System;

namespace HussmannDev.PetShopApp.Core.Models
{
    public class Pet
    {
        /*ID: int
        Name: string
        Type: PetType
        Birthdate: DateTime
        SoldDate: DateTime
        Color: string
        Price: double
        */
        public int? Id { get; set; }
        public  string Name { get; set; }
        public  DateTime BirthDate { get; set; }
        public  DateTime SoldDate { get; set; }
        public  string Color { get; set; }
        public  double Price { get; set; }
        public  PetTypes Type { get; set; }
        
        public Owner PetOwner { get; set; }
        
        public override string ToString()
        {
            return $"{Id} - {Name} - {BirthDate} - {SoldDate} - {Color} - {Price} - {Type.Name}";
        }
    }
}