using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.MASTER
{
    [Table("FRAN")]
    public class FRAN
    {
        // 🔹 Primary Key — Franchise Code (e.g., FR001)
        [Key]
        [Column("FRAN")]
        [StringLength(10)]
        [Required(ErrorMessage = "Franchise Code is required.")]
        public string FranCode { get; set; } = string.Empty;

        // 🔹 Auto-Increment or Numeric Identifier
        [Column("ID", TypeName = "numeric(22, 0)")]
        public decimal Id { get; set; }

        // 🔹 Franchise Name
        [Required(ErrorMessage = "Name is required.")]
        [Column("NAME")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        // 🔹 Arabic Name
        [Required(ErrorMessage = "Arabic Name is required.")]
        [Column("NAMEAR")]
        [StringLength(100)]
        public string NameAr { get; set; } = string.Empty;

        // 🔹 Creation Date
        [Column("CREATEDT", TypeName = "date")]
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
