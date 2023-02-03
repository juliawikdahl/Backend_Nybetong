using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblHall")]
    public class HallModel
    {
        public int HID { get; set; }
        public string Hall { get; set; }
        public int FBID { get; set; }
        public bool PåFabriken { get; set; }
        public bool Aktiv { get; set; }

    }
}
