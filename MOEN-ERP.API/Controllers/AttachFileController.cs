using MOEN_ERP.API.Services.Repository;
using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AttachFile = MOEN_ERP.DAL.Models.AttachFile;
using MOEN_ERP.Models.RawData;
using Microsoft.EntityFrameworkCore;
using LinqKit;

namespace MOEN_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachFileController : ControllerBase
    {
        private readonly MOENDOCSContext _contextDoc;
        public AttachFileController(MOENDOCSContext contextDoc)
        {
            _contextDoc = contextDoc;
        }

        [HttpPost("AddAttachFile")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> AddAttachFile([FromBody] AttachFile data)
        {
            var res = new ApiResultsModel();

            try
            {
                var add = new AttachFile();
                add.RowGuid = data.RowGuid;
                add.ReferenceTable = data.ReferenceTable;
                add.ReferenceGroup = data.ReferenceGroup;
                add.ReferenceId = data.ReferenceId;

                if (add.ReferenceId != 0)
                {
                    var max = _contextDoc.AttachFiles.Where(x => x.ReferenceId == add.ReferenceId && x.ReferenceTable == add.ReferenceTable).OrderBy(x => x.Sequence).FirstOrDefault();
                    if (max != null)
                        add.Sequence = max.Sequence + 1;
                    else
                        add.Sequence = 1;
                }

                add.Filename = data.Filename;
                add.Extension = data.Extension;
                add.FileData = data.FileData;
                add.FileSize = data.FileSize;
                add.CreateBy = data.CreateBy;
                add.CreateOn = DateTime.Now;

                _contextDoc.AttachFiles.Add(add);
                await _contextDoc.SaveChangesAsync();
                res.Type = ApiResultsType.success.ToString();

                add.FileData = null;
                res.Data = add;
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Type = ApiResultsType.error.ToString();
            }
            return Ok(res);
        }

        [HttpGet("GetAttachFileGuidNoData/{GuidId}")]
        public async Task<IActionResult> GetAttachFileGuidNoData(string GuidId)
        {
            var res = await _contextDoc.AttachFiles.Where(x => x.RowGuid == Guid.Parse(GuidId)).Select(
                          s => new AttachFile
                          {
                              Id = s.Id,
                              RowGuid = s.RowGuid,
                              ReferenceTable = s.ReferenceTable,
                              ReferenceId = s.ReferenceId,
                              ReferenceGroup = s.ReferenceGroup,
                              Sequence = s.Sequence,
                              Filename = s.Filename,
                              Extension = s.Extension,
                              FileSize = s.FileSize,
                              CreateBy = s.CreateBy,
                              CreateOn = s.CreateOn,
                              UpdateBy = s.UpdateBy,
                              UpdateOn = s.UpdateOn,

                          }
                          ).FirstOrDefaultAsync();

            return Ok(res);
        }


        [HttpGet("GetAttachFileGuid/{GuidId}")]
        public async Task<IActionResult> GetAttachFileGuid(string GuidId)
        {
            var res = await _contextDoc.AttachFiles.FirstOrDefaultAsync(x => x.RowGuid == Guid.Parse(GuidId)) ?? new AttachFile();
            return Ok(res);
        }

        [HttpGet("GetAttachFileImageGuid/{GuidId}")]
        public async Task<IActionResult> GetAttachFileImageGuid(string GuidId)
        {
            var res = await _contextDoc.AssetImages.FirstOrDefaultAsync(x => x.RowGuid == Guid.Parse(GuidId)) ?? new AssetImage();
            return Ok(res);
        }

        [HttpGet("GetAttachFileNoDataList")]
        public async Task<IActionResult> GetAttachFileNoDataList([FromBody] AttachFile data)
        {
            var whr = PredicateBuilder.True<AttachFile>();
            if (data.Id != null && data.Id != 0) whr = whr.And(x => x.Id == data.Id);
            if (data.RowGuid != null && data.RowGuid != default) whr = whr.And(x => x.RowGuid == data.RowGuid);
            if (data.ReferenceTable != null) whr = whr.And(x => x.ReferenceTable == data.ReferenceTable);
            if (data.ReferenceId != null) whr = whr.And(x => x.ReferenceId == data.ReferenceId);
            if (data.ReferenceGroup != null) whr = whr.And(x => x.ReferenceGroup == data.ReferenceGroup);
            if (data.Sequence != null) whr = whr.And(x => x.Sequence == data.Sequence);
            if (data.Filename != null) whr = whr.And(x => x.Filename == data.Filename);
            if (data.Extension != null) whr = whr.And(x => x.Extension == data.Extension);
            if (data.FileSize != null) whr = whr.And(x => x.FileSize == data.FileSize);

            var res = _contextDoc.AttachFiles.Where(whr).Select(
                s => new AttachFile
                {
                    Id = s.Id,
                    RowGuid = s.RowGuid,
                    ReferenceTable = s.ReferenceTable,
                    ReferenceId = s.ReferenceId,
                    ReferenceGroup = s.ReferenceGroup,
                    Sequence = s.Sequence,
                    Filename = s.Filename,
                    Extension = s.Extension,
                    FileSize = s.FileSize,
                    CreateBy = s.CreateBy,
                    CreateOn = s.CreateOn,
                    UpdateBy = s.UpdateBy,
                    UpdateOn = s.UpdateOn,
                }
                ).ToList();
            return Ok(res);
        }


        [HttpDelete("DeleteAttachFileGuid/{GuidId}")]
        public async Task<IActionResult> DeleteAttachFileGuid(string GuidId)
        {
            var res = new ApiResultsModel();

            try
            {
                var data = await _contextDoc.AttachFiles.FirstOrDefaultAsync(x => x.RowGuid == Guid.Parse(GuidId));
                if (data != null)
                {
                    _contextDoc.AttachFiles.Remove(data);
                    await _contextDoc.SaveChangesAsync();
                    res.Type = ApiResultsType.success.ToString();
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Type = ApiResultsType.error.ToString();
            }
            return Ok(res);
        }
        [HttpDelete("DeleteAttachFileImageGuid/{GuidId}")]
        public async Task<IActionResult> DeleteAttachFileImageGuid(string GuidId)
        {
            var res = new ApiResultsModel();

            try
            {
                var data = await _contextDoc.AssetImages.FirstOrDefaultAsync(x => x.RowGuid == Guid.Parse(GuidId));
                if (data != null)
                {
                    _contextDoc.AssetImages.Remove(data);
                    await _contextDoc.SaveChangesAsync();
                    res.Type = ApiResultsType.success.ToString();
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Type = ApiResultsType.error.ToString();
            }
            return Ok(res);
        }



        [HttpGet("GetAttachFileImageGuidNoData/{GuidId}")]
        public async Task<IActionResult> GetAttachFileImageGuidNoData(string GuidId)
        {
            var res = await _contextDoc.AssetImages.Where(x => x.RowGuid == Guid.Parse(GuidId)).Select(
                          s => new AssetImage
                          {
                              Id = s.Id,
                              RowGuid = s.RowGuid,
                              ReferenceGroup = s.ReferenceGroup,
                              Sequence = s.Sequence,
                              Filename = s.Filename,
                              Extension = s.Extension,
                              FileSize = s.FileSize,
                              CreateBy = s.CreateBy,
                              CreateOn = s.CreateOn,
                              UpdateBy = s.UpdateBy,
                              UpdateOn = s.UpdateOn,
                              AssetId = s.AssetId,
                              AssetTrackImageId = s.AssetTrackImageId,
                              IsMain = s.IsMain
                          }
                          ).FirstOrDefaultAsync();

            return Ok(res);
        }
        [HttpPost("AddAttachFileImage")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> AddAttachFileImage([FromBody] AssetImage data)
        {
            var res = new ApiResultsModel();

            try
            {
                var add = new AssetImage();
                add.RowGuid = data.RowGuid;
                add.ReferenceGroup = data.ReferenceGroup;
                add.AssetId = data.AssetId;

                if (add.AssetId != 0)
                {
                    var max = _contextDoc.AssetImages.Where(x => x.AssetId == add.AssetId && x.ReferenceGroup == add.ReferenceGroup).OrderBy(x => x.Sequence).FirstOrDefault();
                    if (max != null)
                        add.Sequence = max.Sequence + 1;
                    else
                        add.Sequence = 1;
                }

                add.Filename = data.Filename;
                add.Extension = data.Extension;
                add.ImageData = data.ImageData;
                add.FileSize = data.FileSize;
                add.CreateBy = data.CreateBy;
                add.CreateOn = DateTime.Now;

                _contextDoc.AssetImages.Add(add);
                await _contextDoc.SaveChangesAsync();
                res.Type = ApiResultsType.success.ToString();

                add.ImageData = null;
                res.Data = add;
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Type = ApiResultsType.error.ToString();
            }
            return Ok(res);
        }

        [HttpGet("GetAttachImageFileList")]
        public async Task<IActionResult> GetAttachImageFileList([FromBody] AssetImage data)
        {
            var whr = PredicateBuilder.True<AssetImage>();
            if (data.Id != null && data.Id != 0) whr = whr.And(x => x.Id == data.Id);
            if (data.RowGuid != null && data.RowGuid != default) whr = whr.And(x => x.RowGuid == data.RowGuid);
            if (data.AssetId != null) whr = whr.And(x => x.AssetId == data.AssetId);
            if (data.ReferenceGroup != null) whr = whr.And(x => x.ReferenceGroup == data.ReferenceGroup);
            if (data.Sequence != null) whr = whr.And(x => x.Sequence == data.Sequence);
            if (data.Filename != null) whr = whr.And(x => x.Filename == data.Filename);
            if (data.Extension != null) whr = whr.And(x => x.Extension == data.Extension);
            if (data.FileSize != null) whr = whr.And(x => x.FileSize == data.FileSize);

            var res = _contextDoc.AssetImages.Where(whr).Select(
                s => new AssetImage
                {
                    Id = s.Id,
                    RowGuid = s.RowGuid,
                    ReferenceGroup = s.ReferenceGroup,
                    Sequence = s.Sequence,
                    Filename = s.Filename,
                    Extension = s.Extension,
                    FileSize = s.FileSize,
                    CreateBy = s.CreateBy,
                    CreateOn = s.CreateOn,
                    UpdateBy = s.UpdateBy,
                    UpdateOn = s.UpdateOn,
                    AssetId = s.AssetId,
                    ImageData = s.ImageData,
                    IsMain = s.IsMain
                }
                ).ToList();
            return Ok(res);
        }

    }
}
