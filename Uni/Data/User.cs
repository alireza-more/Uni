using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Uni.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "نام نمیتواند خالی باشد")]
        public string Name { get; set; }

        [Display(Name = "ایمیل")]
        [EmailAddress(ErrorMessage = "ایمیل را با فرمت صحیح وارد کنید")]
        [Required(ErrorMessage = "ایمیل نمیتواند خالی باشد")]
        public string Email { get; set; }


        [Display(Name ="شماره تماس")]
        [Required(ErrorMessage = "شماره تماس نمیتواند خالی باشد")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "شماره تماس را با فرمت صحیح وارد کنید")]
        [Phone(ErrorMessage = "شماره تماس را با فرمت صحیح وارد کنید")]
        [MinLength(11,ErrorMessage ="شماره تماس را به درستی وارد کنید")]
        public string Phone { get; set; }
    }
}
