namespace _1lab.Data
{
    public class Schetchik
    {
        public int SchetchikId { get; set; }
        public int? Number { get; set; }
        public string? Type { get; set; }
        public DateTime? LaunchData { get; set; }
        public int AbonentId { get; set; }
        public virtual Abonent Abonent {  get; set; }
    }
}
