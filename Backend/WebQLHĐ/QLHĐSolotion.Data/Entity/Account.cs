//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QLHĐSolotion.Data.Entity
//{
//    [Table("Account")]
//    public partial class Account
//    {
//        public int ID { get; set; }
//        [Required(ErrorMessage = "Mời nhập tên tài khoản")]
//        [StringLength(100, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
//        [Display(Name = "UserName")]
//        public string UserName { get; set; }

//        [Required(ErrorMessage = "Mời nhập mật khẩu")]
//        [StringLength(100, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
//        [DataType(DataType.Password)]
//        public string PassWord { get; set; }

//        [Required(ErrorMessage = "Mời nhập email")]
//        [StringLength(50, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
//        [EmailAddress(ErrorMessage = "Email bạn nhập không đúng! Hãy thử lại!")]
//        [Display(Name = "Email")]
//        public string Email { get; set; }

//        [Required(ErrorMessage = "Mời nhập mô tả")]
//        [StringLength(200, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
//        [Display(Name = "Describe")]
//        public string Describe { get; set; }

//        [Required(ErrorMessage = "Mời nhập ghi chú")]
//        [StringLength(100, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
//        [Display(Name = "Note")]
//        public string Node { get; set; }

//        [Required(ErrorMessage = "Mời chọn nhóm quyền")]
//        //[StringLength(100, ErrorMessage = "", MinimumLength = 3)]
//        //[Display(Name = "GroupID")]
//        public string GroupID { get; set; }
//        public bool Status { get; set; }
//    }
//}
