namespace SeuCevApi.Model
{
    public class Base
    {
        public long Id { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
        public bool Ativo { get; set; } = true;
    }
}
