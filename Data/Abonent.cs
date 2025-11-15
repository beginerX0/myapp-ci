namespace _1lab.Data
{
    public class Abonent
    {
        public int AbonentId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? SecureName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<Schetchik>? Schetchiks { get; set; }

        public string getFullName()=>LastName + " " + Name + " " + SecureName;
    }
}
