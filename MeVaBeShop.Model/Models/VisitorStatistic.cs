using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class VisitorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  VisitorStatisticID { get; set; }

        public DateTime VistedDate { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string IPAddress { get; set; }
    }
}
