namespace _1lab.Data
{
    public class Pokazanie
    {
        public int PokazanieId { get; set; }
        public DateTime? DataPokazaniya { get; set; }
        public int? ZnacheniePokazaniya { get; set; }
        public int SchetchikId { get; set; }
        public virtual Schetchik? Schetchik { get; set; }
    }
}
