using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{
    [Table("x_online_test")]
    public class Online_Test
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

        public long biodata_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string period_code { get; set; }

        public Nullable<int> period { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> test_date { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> expired_test { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string user_access { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string status { get; set; }
    }
}