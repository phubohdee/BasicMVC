using System.ComponentModel.DataAnnotations;

namespace BasicMVC.Models
{
    public class Member
    {
        //public int ID { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนชื่อ-สกุลด้วย")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนที่อยู่ด้วย")]
        public string Address { get; set; }
    }
}
