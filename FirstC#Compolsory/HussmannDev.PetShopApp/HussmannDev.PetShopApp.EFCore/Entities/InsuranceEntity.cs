namespace HussmannDev.PetShopApp.EFCore.Entities
{
    public class InsuranceEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
        public int InsuranceId { get; set; }
        
        public InsuranceEntity Insurance { get; set; }
    }
}