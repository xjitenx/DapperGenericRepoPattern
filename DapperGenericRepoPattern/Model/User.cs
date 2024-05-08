using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DapperGenericRepoPattern.Model
{
    [Table("dbo.[User]")]
    public class User: IDbEntity
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Column("Name")]
        public string? Name { get; set; }
        [Column("Address")]
        public string? Address { get; set; }
        [Column("MobileNo")]
        public string? MobileNo { get; set; }
    }
}
