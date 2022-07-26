namespace LoanApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Profile_creation { get; set; }
        public ICollection<User> FriendList { get; set; }
        public ICollection<Loan> LoanList { get; set; }
    }
}
