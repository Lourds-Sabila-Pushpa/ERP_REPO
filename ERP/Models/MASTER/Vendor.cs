using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ERP.Models.MASTER
{
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        [Column(TypeName = "varchar(10)")]
        public string VENDOR { get; set; } = "";


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


        [JsonIgnore]
        public DateOnly CREATEDT { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        [JsonIgnore]
        public DateTime CREATETM { get; set; } = DateTime.Now;

        [JsonIgnore]
        [Column(TypeName = "varchar(10)")]
        public string CREATEBY { get; set; } = "";

        [JsonIgnore]
        [Column(TypeName = "varchar(200)")]
        public string CREATEREMARKS { get; set; } = "";

        [JsonIgnore]
        public DateOnly UPDATEDT { get; set; } = new DateOnly(1900, 1, 1);

        [JsonIgnore]
        public DateTime UPDATETM { get; set; } = new DateTime(1900, 1, 1);

        [JsonIgnore]
        [Column(TypeName = "varchar(10)")]
        public string UPDATEBY { get; set; } = "";

        [JsonIgnore]
        [Column(TypeName = "varchar(200)")]
        public string UPDATEMARKS { get; set; } = "";
    }
}
