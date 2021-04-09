namespace Attributes
{ 
     //[MemberProfile(Fname = "Alireza", Lname = "Boroumand")]
    [MemberProfile("Alireza", "Boroumand")]
    [MemberProfile("Amir", "Boroumand")]
    public class Member
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public static string FullName { get; set; }
    }
}
