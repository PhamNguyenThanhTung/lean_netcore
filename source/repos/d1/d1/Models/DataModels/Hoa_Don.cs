using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace d1.Models.DataModels
{
    [Table("Hoa_Don")]
    public class Hoa_Don
    {
        [DisplayName("ID")]
        [StringLength(50)]
        public string ID{ get; set; }
        [DisplayName("Mã hóa đơn")]
        [StringLength(50)]
        public string ID_Hoadon { get; set; }
        [DisplayName("Mã khách hàng")]
        [StringLength(50)]
        public string ID_KH { get; set; }
        [DisplayName("Ngày hóa đơn")]
        [DataType(DataType.Date)]
        public DateTime date_hd { get; set; }
        [DisplayName("Ngày nhận")]
        [DataType(DataType.Date)]
        public DateTime date_nn { get; set; }
        [DisplayName("Ngày hóa đơn")]
        [StringLength(50)]
        public string date_hd { get; set; }
    }
}
