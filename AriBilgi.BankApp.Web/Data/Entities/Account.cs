namespace AriBilgi.BankApp.Web.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public int AccountNo { get; set; }

        public int ApplicationUserId { get; set; }

        //NAVIGATE PROPERTY
        public ApplicationUser ApplicationUser { get; set; }
    }
}
