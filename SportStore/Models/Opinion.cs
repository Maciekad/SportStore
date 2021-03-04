using SportStoreDal.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class Opinion
    {
        [Key]
        public int OpinionId { get; set; } 
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer CustomerNavigation { get; set; }
    }
}
