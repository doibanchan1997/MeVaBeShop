using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupportOnlineID { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Department { get; set; }

        [MaxLength(250)]
        public string Skype { get; set; }

        [MaxLength(250)]
        public string Mobile { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Facebook { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
