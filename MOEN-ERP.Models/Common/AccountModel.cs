using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.Common
{
	public class AccountModel
	{
		

		public SystemUser? User { get; set; }
        public VOfficer? Officer { get; set; }       
        public SystemRole? UserRole { get; set; }
		public SystemInfo? SystemInfo { get; set; }
        public ApiResultsModel? ApiResults { get; set; }	
		public bool? IsAuthenSSO { get; set; }
        public string? RetrunUrl { get; set; }
		public string? UserToken { get; set; }
    }

}
