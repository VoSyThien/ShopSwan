using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MoHinh.Models
{
    public class Hinh
    {
        public long HinhID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên mô hình")]

        public string TenMoHinh { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        public string MoTa { get; set; }
        [Required]
        [Range(0.01, double.MaxValue,
        ErrorMessage = "Vui lòng nhập giá mong muốn")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Gia { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thể loại")]
        public string TheLoai { get; set; }
    }
}
