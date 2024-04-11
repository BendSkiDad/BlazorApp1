using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    [Table("Job_Process")]
    public class JobProcess
    {
        [Key]
        [Column("Job_Process_Id")]
        public byte JobProcessId { get; set; }

        [NotMapped]
        public int Id {
            get
            {
                return (int)JobProcessId;
            }
            set
            {
                JobProcessId = (byte)value;
            }
        }

        [Column("Job_Process_Name")]
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Column("Job_Process_Plural_Name")]
        [Required]
        public string PluralName { get; set; } = string.Empty;
        
        [Column("Is_Inactive")]
        public byte IsInactive { get; set; }
        
        [NotMapped]
        public bool IsActive {
            get
            {
                return IsInactive == 0;
            }
            set
            {
                IsInactive = (byte)(value ? 0 : 1);
            }
        }
        
        [Column("Seq_Num")]
        public byte SequenceNum { get; set; }
    }
}
