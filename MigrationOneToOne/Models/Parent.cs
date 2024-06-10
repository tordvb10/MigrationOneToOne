namespace MigrationOneToOne.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ChildId { get; set; }
        public Child Child { get; set; }
    }
}
