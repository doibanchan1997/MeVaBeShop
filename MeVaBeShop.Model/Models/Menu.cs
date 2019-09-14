using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }


        [StringLength(250)]
        public string Link { get; set; }


        public int? DisplayOrder { get; set; }


        [StringLength (250)]
        public string Target { get; set; }

        public bool? Status { get; set; }

        public int? MenuTypeID { get; set; }

        public int? MenuParentID { get; set; }

        public virtual MenuType MenuType { get; set; }
    }
}
