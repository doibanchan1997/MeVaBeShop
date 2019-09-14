using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConfigID { get; set; }

        [StringLength(50)]
        public string ConfigName { get; set; }

        [StringLength(250)]
        public string ValueString { get; set; }

        public int ValueInt { get; set; }
    }
}
