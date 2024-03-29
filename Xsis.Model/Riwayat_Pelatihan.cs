﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_riwayat_pelatihan")]
    public class Riwayat_Pelatihan
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
        public string training_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string organizer { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string project_name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string training_year { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string training_month { get; set; }

        public Nullable<int> training_duration { get; set; }

        public Nullable<long> time_period_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string city { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string country { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string notes { get; set; }

    }
}