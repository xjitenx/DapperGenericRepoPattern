using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DapperGenericRepoPattern.Model
{
    public interface IDbEntity
    {
        public Guid Id { get; set; }
    }
}
