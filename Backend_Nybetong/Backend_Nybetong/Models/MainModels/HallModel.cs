using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("tblHall")]
    public class HallModel
    {
        [Key]
        public int HID { get; set; }
        public string Hall { get; set; }
        public int FBID { get; set; }
        public bool PåFabriken { get; set; }
        public bool Aktiv { get; set; }


        
    }
}
