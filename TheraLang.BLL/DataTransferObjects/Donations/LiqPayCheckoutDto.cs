namespace TheraLang.BLL.DataTransferObjects.Donations
{
    public class LiqPayCheckoutDto
    {
        public int? ProjectId { get; set; }
        
        public int? SocietyId { get; set; }
        
        public string Data { get; set; }

        public string Signature { get; set; }
    }
}