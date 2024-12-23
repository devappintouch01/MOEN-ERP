using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.ViewModel.AudioVisualServiceConsider
{
    //internal class AudioVisualServiceConsider
    //{
    //}
    public class SearchAudioVisualServiceConsider
    {
        public string? SearchBookingCode { get; set; }
        //public string? SearchLocation { get; set; }
        //public int? SearchLastStatusId { get; set; }
        public string? SearchBookerName { get; set; }
        public int? SearchBookerOrgId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchUseDateFrom { get; set; }
        public DateTime? SearchUseDateTo { get; set; }
        public bool? SearchIsConsider { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemOfficerId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }
        public int? SearchSystemOrganizationId { get; set; }

    }


    public class SearchAudioVisualServiceConfirm
    {
        public string? SearchBookingCode { get; set; }
        public string? SearchLocation { get; set; }
        public int? SearchLastStatusId { get; set; }
        public DateTime? SearchBookingDateFrom { get; set; }
        public DateTime? SearchBookingDateTo { get; set; }
        public DateTime? SearchUseDateFrom { get; set; }
        public DateTime? SearchUseDateTo { get; set; }
        public bool? SearchIsConsider { get; set; }
        public int? SearchSystemUserId { get; set; }
        public int? SearchSystemUserRoleId { get; set; }
        public string? SearchBookerName { get; set; }

    }


}
