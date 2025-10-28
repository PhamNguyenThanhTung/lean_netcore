using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace d1.Models.DataModels
{
    [Table("Quan_tri")]
    public class Quan_tri
    {
        [DisplayName("ID")]
        [StringLength(50)]
        public string Qt_ID { get; set; }
        [DisplayName("Tài khoản")]
        [StringLength(50)]
        public string TaiKhoan { get; set; }
        [DisplayName("Mật khẩu")]
        [StringLength(50)]
        public string MatKhau { get; set; }
        [DisplayName("Trạng thái")]
        [StringLength(50)]
        public string Thau { get; set; }

    }
}
