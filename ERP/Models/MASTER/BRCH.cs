using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.MASTER
{
    public class BRCH
    {
        [Key, Column("BRCH")]
        [StringLength(10)]
        public string BranchCode { get; set; } = string.Empty;

        [Column("FRAN")]
        [StringLength(10)]
        public string FranCode { get; set; } = string.Empty;

        [ForeignKey(nameof(FranCode))]
        public FRAN? FRAN { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(100)]
        public string NAME { get; set; } = string.Empty;

        [StringLength(100)]
        public string NAMEAR { get; set; } = string.Empty;

        // 🔹 Creation Date
        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;

        // 🔹 Creation Time
        [Column("CREATETM", TypeName = "datetime")]
        public DateTime? CreateTime { get; set; } = DateTime.Now;

        [Column("CREATEBY")]
        [StringLength(10)]
        public string? CreateBy { get; set; }

        [Column("CREATEREMARKS")]
        [StringLength(200)]
        public string? CreateRemarks { get; set; }

        // 🔹 Update Fields
        [Column("UPDATEDT", TypeName = "date")]
        public DateTime? UpdateDate { get; set; }

        [Column("UPDATETM", TypeName = "datetime")]
        public DateTime? UpdateTime { get; set; }

        [Column("UPDATEBY")]
        [StringLength(10)]
        public string? UpdateBy { get; set; }

        [Column("UPDATEMARKS")]
        [StringLength(200)]
        public string? UpdateRemarks { get; set; }
    }
}
