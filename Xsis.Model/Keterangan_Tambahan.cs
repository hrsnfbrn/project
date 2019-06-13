using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_keterangan_tambahan")]
    public class Keterangan_Tambahan
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
        [StringLength(100)]
        public string emergency_contact_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string emergency_contact_phone { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string expected_salary { get; set; }

        public Nullable<Boolean> is_negotiable { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string start_working { get; set; }

        public Nullable<Boolean> is_ready_to_outofdown { get; set; }

        public Nullable<Boolean> is_apply_other_place { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string apply_place { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string selection_phase { get; set; }

        public Nullable<Boolean> is_ever_badly_sick { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string disease_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string disease_time { get; set; }

        public Nullable<Boolean> is_ever_psychotest { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string psychotest_needs { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string psychotest_time { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string requirements_required { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string other_notes { get; set; }

    }
}
