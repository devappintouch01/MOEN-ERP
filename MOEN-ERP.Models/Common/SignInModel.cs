using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Common
{
	public class SignInModel
	{
		[Required(ErrorMessage ="ระบุชื่อผู้ใช้งาน")]
		public string UserName { get; set; }

		[Required(ErrorMessage ="ระบุรหัสผ่าน")]
		public string Password { get; set; }

		public bool? RememberMe { get; set; }
		public string? IpAddress { get; set; }
	}


    public class SignInSSOModel
    {     
        public string UserName { get; set; }       
        public string IpAddress { get; set; }
    }

}
