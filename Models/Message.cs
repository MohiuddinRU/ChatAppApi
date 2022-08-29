namespace ChatAppApi.Models {
    public class Message {
        public long MessageId{get; set;}
        public string? FromUserId{ get; set;}
        public string? ToUserId { get; set;}
        public string MessageBody { get; set;}
        public DateTime SentAt {get; set;}
        public DateTime? UpdatedAt {get; set;}
        public DateTime? DeletedAt {get; set;}
    }
}