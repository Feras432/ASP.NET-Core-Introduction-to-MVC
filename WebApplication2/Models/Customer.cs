namespace WebApplication2.Models
{
    public class Customer
    {
        public int CivilId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int Phone { get; set; }

        public Customer(int CivilId, string Name, string Email, int Phone)
        {
            this.CivilId = CivilId;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;

        }

    }
}
