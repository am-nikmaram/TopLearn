﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLayer.Entities.User
{
    public class User
    {

        public User()
        {

        }

        [Key]
        public int UserId { get; set; }

        [Display(Name ="نام کاربری")]
        [Required(ErrorMessage ="لطفاً {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمی تواند بیشتر از {1} باشد")]
        public string UserName { get; set; }

        [Display(Name ="ایمیل")]
        [Required(ErrorMessage ="لطفاً {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمی تواند بیشتر از {1} باشد")]
        [EmailAddress(ErrorMessage ="ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }

        [Display(Name ="کلمه عبور")]
        [Required(ErrorMessage ="لطفاً {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمی تواند بیشتر از {1} باشد")]
        public string Password { get; set; }

        [Display(Name ="کد فعال سازی")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string ActiveCode { get; set; }

        [Display(Name ="وضعیت")]
        public bool IsActive { get; set; }

        [Display(Name ="آواتار")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string UserAvatar { get; set; }

        [Display(Name ="تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }

        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }
        #endregion


    }
}
