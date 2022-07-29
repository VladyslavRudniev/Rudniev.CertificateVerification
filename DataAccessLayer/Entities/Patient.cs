using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public Certificate Certificate { get; set; }
    }
}
