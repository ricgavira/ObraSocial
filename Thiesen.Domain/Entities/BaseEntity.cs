namespace ObraSocial.Domain.Entities
{
    public abstract class BaseEntity<T> where T : BaseEntity<T>
    {
        protected BaseEntity()
        {
            CreateAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
    }
}