using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DapperGenericRepoPattern.Model
{
    [Table("user")]
    public class User: IDbEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Column("name")]
        public string? Name { get; set; }
        [Column("address")]
        public string? Address { get; set; }
        [Column("mobile_no")]
        public string? MobileNo { get; set; }
    }
}
