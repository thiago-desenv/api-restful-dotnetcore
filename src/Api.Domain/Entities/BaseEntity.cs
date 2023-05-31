namespace Api.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime? _createAt;
        public DateTime? CreatAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }
    }
}
