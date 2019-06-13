using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_undangan")]
    public class Undangan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }

        public Nullable<long> modified_by { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> modified_on { get; set; }

        public Nullable<long> deleted_by { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        public Nullable<long> schedule_type_id { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> invitation_date { get; set; }

        public Nullable<long> ro { get; set; }

        public Nullable<long> tro { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string other_ro_tro { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string location { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string status { get; set; }
    }
}