using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ERP.Models.MASTER
{
    public class POHDR
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("FRAN")]
        public string FranCode { get; set; } = string.Empty;

        [Column("BRCH")]
        public string BranchCode { get; set; } = string.Empty;

        [Column("WHSE")]
        public string WhCode { get; set; } = string.Empty;

        [Column("VENDOR")]
        public string VENDOR { get; set; } = string.Empty;

        [Column("DOCTYPE")]
        public string DOCTYPE { get; set; } = string.Empty;

        [Column("DOCNO")]
        public string DOCNO { get; set; } = string.Empty;

        [Column("SEQNO")]
        public string SEQNO { get; set; } = string.Empty;

        [Column("SEQNOPREFIX")]
        public string SEQNOPREFIX { get; set; } = string.Empty;
        

        [ForeignKey(nameof(FranCode))]
        public FRAN? FRAN { get; set; }

        [ForeignKey(nameof(BranchCode))]
        public BRCH? BRCH { get; set; }

        [ForeignKey(nameof(WhCode))]
        public WHSE? WHSE { get; set; }

        [ForeignKey(nameof(VENDOR))]
        public Vendor? Vendor { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string VENDORREFTYPE { get; set; } = "";


        [Column(TypeName = "varchar(10)")]
        public string VENDORREFNO { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string CURRENCY { get; set; } = "";

        [Required]
        [Column(TypeName = "numeric(22,0)")]
        public decimal NOOFITEMS { get; set; }

        [Required]
        [Column(TypeName = "numeric(22,0)")]
        public decimal DISCOUNT { get; set; }


        [Required]
        [Column(TypeName = "numeric(22,0)")]
        public decimal TOTALVALUE { get; set; }


        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;

        [Column("CREATETM", TypeName = "datetime")]
        public DateTime? CreateTime { get; set; } = DateTime.Now;

        [Column("CREATEBY"), StringLength(10)]
        public string? CreateBy { get; set; }

        [Column("CREATEREMARKS"), StringLength(200)]
        public string? CreateRemarks { get; set; }

        [Column("UPDATEDT", TypeName = "date")]
        public DateTime? UpdateDate { get; set; }

        [Column("UPDATETM", TypeName = "datetime")]
        public DateTime? UpdateTime { get; set; }

        [Column("UPDATEBY"), StringLength(10)]
        public string? UpdateBy { get; set; }

        [Column("UPDATEMARKS"), StringLength(200)]
        public string? UpdateRemarks { get; set; }
    }
}
