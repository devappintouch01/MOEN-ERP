using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Models.RawData
{
    public class VAttachFile
    {
        public int? Id { get; set; }

        public Guid? RowGuid { get; set; }

        public string? ReferenceTable { get; set; }

        public int? ReferenceId { get; set; }

        public string? ReferenceGroup { get; set; }

        public int? Sequence { get; set; }

        public string? Filename { get; set; }

        public string? Extension { get; set; }

        public byte[]? FileData { get; set; }

        public long? FileSize { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }
    }
}
