namespace ChatAppApi.Models {
    public class User {
        public long UserId {get; set;}
        public string? FirstName{ get; set;}
        public string? LastName { get; set;}
        public string? Email { get; set;}
        public string? PhoneNumber{ get; set;}
        public DateTime RegisteredAt {get; set;}
        public DateTime? UpdatedAt {get; set;}
        public DateTime? DeletedAt {get; set;}


    }
}