namespace TrialProject.API.Models
{
    public interface IUserModel
    {
        public string Title { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public DateTime DateOfBirth { get; }
        public string City { get; }
        public string State { get; }
        public string Country { get; }

        public Gender Gender { get; }
    }
}
