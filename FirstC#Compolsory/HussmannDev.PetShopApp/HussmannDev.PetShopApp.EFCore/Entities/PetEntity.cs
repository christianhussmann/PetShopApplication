using System;

namespace HussmannDev.PetShopApp.EFCore.Entities
{
    public class PetEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public int TypeId { get; set; }  
        public int InsuranceId { get; set; }
        public InsuranceEntity Insurance { get; set; }
        
        public int OwnerId { get; set; }

        public OwnerEntity Owner { get; set; }

    }
}