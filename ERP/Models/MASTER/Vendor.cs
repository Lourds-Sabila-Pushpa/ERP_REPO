using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ERP.Models.MASTER
{
    public class Vendor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(TypeName = "varchar(10)")]
        public string VENDOR { get; set; } = string.Empty;


        [Column(TypeName = "varchar(100)")]
        public string NAME { get; set; } = "";


        [Column(TypeName = "varchar(100)")]
        public string NAMEAR { get; set; } = "";


        [Column(TypeName = "varchar(50)")]
        public string PHONE { get; set; } = "";


        [Column(TypeName = "varchar(100)")]
        public string EMAIL { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        public string ADDRESS { get; set; } = "";



        [Column(TypeName = "varchar(50)")]
        public string VATNO { get; set; } = "";


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
