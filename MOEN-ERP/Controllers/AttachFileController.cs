using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.ViewModel;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using System;
using System.IO;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Controllers
{
    public class AttachFileController : Controller
    {
        //private readonly IDataService _dataService;
        private readonly IAttachFileService _attachFile;
        public AttachFileController(IAttachFileService attachFile)
        {
            _attachFile = attachFile;
        }

        #region Attach File
        [HttpPost]
        public async Task<ActionResult> RenderAttachFileImage(string eleId, int refId, string refGuidId, string fileGuidId, string refTable, string refCmp, bool? read)
        {
            var attImgList = new AssetImage();
            if (refId > 0)
            {
                var att = await _attachFile.GetAttachFileListImageAsync(new AssetImage()
                {
                    AssetId = refId,
                    ReferenceGroup = refCmp
                });
                if (att.Count() > 0) attImgList = att.FirstOrDefault();
            }
            else if (fileGuidId != null)
            {
                string[] arrFileGuid = fileGuidId.Split("||");
                foreach (var rFile in arrFileGuid)
                {
                    if (!string.IsNullOrEmpty(rFile))
                    {
                        var att = await _attachFile.GetAttachFileImageGuidNoDataAsync(rFile);
                        attImgList = att;
                    }
                }
            }


            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["fileGuidId"] = fileGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            return PartialView("_RenderAttachFileImage", attImgList);
        }
        #endregion

        #region Attach File PDF List
        [HttpPost]
        public async Task<ActionResult> RenderAttachFilePDFList(string eleId, int refId, string refGuidId, string fileGuidId, string refTable, string refCmp, bool? read)
        {
            var attImgList = new List<AttachFile>();
            if (refId > 0)
            {
                var att = await _attachFile.GetAttachFileNoDataListAsync(new AttachFile()
                {
                    ReferenceId = refId,
                    ReferenceTable = refTable,
                    ReferenceGroup = refCmp
                });
                attImgList.AddRange(att);
            }
            else
            {
                if (fileGuidId != null)
                {
                    string[] arrFileGuid = fileGuidId.Split("||");
                    foreach (var rFile in arrFileGuid)
                    {
                        if (!string.IsNullOrEmpty(rFile))
                        {
                            var att = await _attachFile.GetAttachFileGuidNoDataAsync(rFile);

                            if (att != null) attImgList.Add(att);
                        }
                    }
                }
            }

            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["fileGuidId"] = fileGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            return PartialView("_RenderAttachFilePDFList", attImgList);
        }

        [HttpPost]
        public async Task<ActionResult> AddItemFilePDF(string[] fileGuidId, string[] imageName, int refId, string refGuidId, string refCmp, string refTable, string eleId, string read)
        {
            //AttachFileViewModel attImg = new AttachFileViewModel();
            var attImgList = new List<AttachFile>();

            var count = 0;
            if (imageName != null && imageName.Length > 0) count = imageName.Count();

            var i = 0;
            if (fileGuidId != null)
            {
                foreach (var itm in fileGuidId)
                {
                    var guid = Guid.Parse(itm);
                    //var att = await _attachFile.GetAttachFileGuidAsync(guid.ToString());
                    var att = await _attachFile.GetAttachFileGuidNoDataAsync(guid.ToString());
                    att.Filename = imageName[i];
                    attImgList.Add(att);
                    i++;
                }
            }
            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            TempData["fileGuidId"] = string.Join("||", fileGuidId);
            attImgList.Add(new AttachFile());
            if (count != 0 && count == attImgList.Count()) ViewBag.errorAddImg = "กรุณาใส่รูปให้ครบก่อนเพิ่มรูปภาพ";
            return PartialView("_RenderAttachFilePDFList", attImgList);
        }

        #endregion


        #region Attach File List
        [HttpPost]
        public async Task<ActionResult> RenderAttachFileList(string eleId, int refId, string refGuidId, string fileGuidId, string refTable, string refCmp, bool? read, bool? list)
        {
            var attImgList = new List<AttachFile>();
            if (refId > 0)
            {
                var att = await _attachFile.GetAttachFileNoDataListAsync(new AttachFile()
                {
                    ReferenceId = refId,
                    ReferenceTable = refTable,
                    ReferenceGroup = refCmp
                });
                attImgList.AddRange(att);
            }
            else
            {
                if (fileGuidId != null)
                {
                    string[] arrFileGuid = fileGuidId.Split("||");
                    foreach (var rFile in arrFileGuid)
                    {
                        if (!string.IsNullOrEmpty(rFile))
                        {
                            var att = await _attachFile.GetAttachFileGuidNoDataAsync(rFile);

                            if (att != null) attImgList.Add(att);
                        }
                    }
                }
            }

            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["fileGuidId"] = fileGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            TempData["list"] = list;

            return PartialView("_RenderAttachFileList", attImgList);
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> UplaodFile()
        {
            try
            {
                var user = new Appz(HttpContext).CurrentSignInUser;

                var files = Request.Form.Files[0];

                var refCmp = Request.Form["refCmp"].ToString();
                var refId = !string.IsNullOrEmpty(Request.Form["refId"].ToString()) ? Convert.ToInt32(Request.Form["refId"].ToString()) : 0;
                var refTable = Request.Form["refTable"].ToString();

                if (files == null || files.Length == 0)
                    return Content("file not selected");

                byte[] fileByte;
                using (var stream = new MemoryStream())
                {
                    files.CopyTo(stream);
                    fileByte = stream.ToArray();
                }

                if (files == null || files.Length == 0) return Json(new { status = "failed", remark = "file not selected" });


                var fileUpload = new AttachFile()
                {
                    CreateOn = DateTime.Now,
                    CreateBy = user.User.Id,
                    RowGuid = Guid.NewGuid(),
                    ReferenceTable = refTable,
                    ReferenceId = refId,
                    ReferenceGroup = refCmp,
                    FileSize = files.Length,
                    Filename = files.FileName,
                    Extension = files.ContentType,
                    FileData = fileByte,
                };
                var res = await _attachFile.AddAttachFileAsync(fileUpload);
                if (res.Type == "success")
                {
                    var resData = JsonConvert.DeserializeObject<AttachFile>(res.Data.ToString());
                    fileUpload.FileData = null;
                    return Json(new { Success = true, attach = fileUpload });

                }
                else
                {
                    return Json(new { Success = false, Remark = res.Message });

                }
            }
            catch (Exception ex)
            {

                return Json(new { Success = false, attach = (AttachFile)null, Remark = ex.Message });
            }


        }

        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> UplaodFileImage()
        {
            try
            {
                var user = new Appz(HttpContext).CurrentSignInUser;

                var files = Request.Form.Files[0];

                var refCmp = Request.Form["refCmp"].ToString();
                var refId = !string.IsNullOrEmpty(Request.Form["refId"].ToString()) ? Convert.ToInt32(Request.Form["refId"].ToString()) : 0;
                var refTable = Request.Form["refTable"].ToString();

                if (files == null || files.Length == 0)
                    return Content("file not selected");

                byte[] fileByte;
                using (var stream = new MemoryStream())
                {
                    files.CopyTo(stream);
                    fileByte = stream.ToArray();
                }

                if (files == null || files.Length == 0) return Json(new { status = "failed", remark = "file not selected" });


                var fileUpload = new AssetImage()
                {
                    CreateOn = DateTime.Now,
                    CreateBy = user.User.Id,
                    RowGuid = Guid.NewGuid(),
                    AssetId = refId,
                    ReferenceGroup = refCmp,
                    FileSize = files.Length,
                    Filename = files.FileName,
                    Extension = files.ContentType,
                    ImageData = fileByte,
                };
                var res = await _attachFile.AddAttachFileImageAsync(fileUpload);
                if (res.Type == "success")
                {
                    var resData = JsonConvert.DeserializeObject<AttachFile>(res.Data.ToString());
                    fileUpload.ImageData = null;
                    return Json(new { Success = true, attach = fileUpload });

                }
                else
                {
                    return Json(new { Success = false, Remark = res.Message });

                }
            }
            catch (Exception ex)
            {

                return Json(new { Success = false, attach = (AttachFile)null, Remark = ex.Message });
            }


        }

        [HttpPost]
        public async Task<ActionResult> AddItemFile(string[] fileGuidId, string[] imageName, int refId, string refGuidId, string refCmp, string refTable, string eleId, string read)
        {
            //AttachFileViewModel attImg = new AttachFileViewModel();
            var attImgList = new List<AttachFile>();

            var count = 0;
            if (imageName != null && imageName.Length > 0) count = imageName.Count();

            var i = 0;
            if (fileGuidId != null)
            {
                foreach (var itm in fileGuidId)
                {
                    var guid = Guid.Parse(itm);
                    //var att = await _attachFile.GetAttachFileGuidAsync(guid.ToString());
                    var att = await _attachFile.GetAttachFileGuidNoDataAsync(guid.ToString());
                    att.Filename = imageName[i];
                    attImgList.Add(att);
                    i++;
                }
            }
            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            TempData["fileGuidId"] = string.Join("||", fileGuidId);
            attImgList.Add(new AttachFile());
            if (count != 0 && count == attImgList.Count()) ViewBag.errorAddImg = "กรุณาใส่รูปให้ครบก่อนเพิ่มรูปภาพ";
            return PartialView("_RenderAttachFileList", attImgList);
        }

        public async Task<IActionResult> ViewAttachFile(string Id, string refTable = null, string refCmp = null, string inline = "Y")
        {
            var att = await _attachFile.GetAttachFileGuidAsync(Id);
            if (att != null)
            {
                if (inline == "Y")
                {
                    return File(att.FileData, att.Extension);
                }
                else
                {
                    return File(att.FileData, att.Extension, att.Filename);
                }
            }

            return Content("File not found");


        }

        public async Task<IActionResult> ViewAttachFileByRef(string refTable, int id, string inline = "Y")
        {
            var att = await _attachFile.GetAttachFileImageByRef(refTable, id);
            if (att != null && att.Id != 0)
            {
                if (inline == "Y")
                {
                    return File(att.FileData, att.Extension);
                }
                else
                {
                    return File(att.FileData, att.Extension, att.Filename);
                }
            }

            return Content("File not found");


        }
        #endregion


        #region Attach File List Other Ms Word 
        [HttpPost]
        public async Task<ActionResult> RenderAttachFileOtherMsWordList(string eleId, int refId, string refGuidId, string fileGuidId, string refTable, string refCmp, bool? read)
        {
            var attImgList = new List<AttachFile>();
            if (refId > 0)
            {
                var att = await _attachFile.GetAttachFileNoDataListAsync(new AttachFile()
                {
                    ReferenceId = refId,
                    ReferenceTable = refTable,
                    ReferenceGroup = refCmp
                });
                attImgList.AddRange(att);
            }
            else
            {
                if (fileGuidId != null)
                {
                    string[] arrFileGuid = fileGuidId.Split("||");
                    foreach (var rFile in arrFileGuid)
                    {
                        if (!string.IsNullOrEmpty(rFile))
                        {
                            //var att = await _attachFile.GetAttachFileGuidAsync(rFile);
                            var att = await _attachFile.GetAttachFileGuidNoDataAsync(rFile);
                            if (att != null) attImgList.Add(att);
                        }
                    }
                }
            }

            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["fileGuidId"] = fileGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            return PartialView("_RenderAttachFileOtherMsWordList", attImgList);
        }

        [HttpPost]
        public async Task<IActionResult> UplaodFileOtherMsWord()
        {
            try
            {
                var files = Request.Form.Files[0];

                var refCmp = Request.Form["refCmp"].ToString();
                var refId = !string.IsNullOrEmpty(Request.Form["refId"].ToString()) ? Convert.ToInt32(Request.Form["refId"].ToString()) : 0;
                var refTable = Request.Form["refTable"].ToString();

                if (files == null || files.Length == 0)
                    return Content("file not selected");

                byte[] fileByte;
                using (var stream = new MemoryStream())
                {
                    files.CopyTo(stream);
                    fileByte = stream.ToArray();
                }

                if (files == null || files.Length == 0) return Json(new { status = "failed", remark = "file not selected" });


                var fileUpload = new AttachFile()
                {
                    CreateOn = DateTime.Now,
                    CreateBy = -1,
                    RowGuid = Guid.NewGuid(),
                    ReferenceTable = refTable,
                    ReferenceId = refId,
                    ReferenceGroup = refCmp,
                    FileSize = files.Length,
                    Filename = files.FileName,
                    Extension = files.ContentType,
                    FileData = fileByte,
                };
                var res = await _attachFile.AddAttachFileAsync(fileUpload);
                if (res.Type == "success")
                {
                    var resData = JsonConvert.DeserializeObject<AttachFile>(res.Data.ToString());
                    return Json(new { Success = true, attach = fileUpload });

                }
                else
                {
                    return Json(new { Success = false, Remark = res.Message });

                }
            }
            catch (Exception ex)
            {

                return Json(new { Success = false, attach = (AttachFile)null, Remark = ex.Message });
            }


        }

        [HttpPost]
        public async Task<ActionResult> AddItemFileOtherMsWord(string[] fileGuidId, string[] imageName, int refId, string refGuidId, string refCmp, string refTable, string eleId, string read)
        {
            //AttachFileViewModel attImg = new AttachFileViewModel();
            var attImgList = new List<AttachFile>();

            var count = 0;
            if (imageName != null && imageName.Length > 0) count = imageName.Count();

            var i = 0;
            if (fileGuidId != null)
            {
                foreach (var itm in fileGuidId)
                {
                    var guid = Guid.Parse(itm);
                    var att = await _attachFile.GetAttachFileGuidAsync(guid.ToString());
                    //var att = await _attachFile.GetAttachFileGuidNoDataAsync(guid.ToString());
                    att.Filename = imageName[i];
                    attImgList.Add(att);
                    i++;
                }
            }
            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            TempData["fileGuidId"] = string.Join("||", fileGuidId);
            attImgList.Add(new AttachFile());
            if (count != 0 && count == attImgList.Count()) ViewBag.errorAddImg = "กรุณาใส่รูปให้ครบก่อนเพิ่มรูปภาพ";
            return PartialView("_RenderAttachFileOtherMsWordList", attImgList);
        }

        public async Task<IActionResult> ViewAttachFileOtherMsWord(string Id, string refTable = null, string refCmp = null, string inline = "Y")
        {
            var att = await _attachFile.GetAttachFileGuidAsync(Id);
            //var att = await _attachFile.GetAttachFileGuidNoDataAsync(Id);
            if (att != null)
            {
                if (inline == "Y")
                {
                    return File(att.FileData, att.Extension);
                }
                else
                {
                    return File(att.FileData, att.Extension, att.Filename);
                }
            }

            return Content("File not found");


        }

        #endregion


        #region Attach Image List

        [HttpPost]
        public async Task<ActionResult> RenderAttachFileImageList(string eleId, int refId, string refGuidId, string fileGuidId, string refTable, string refCmp, bool? read)
        {
            var attImgList = new List<AttachFile>();
            if (refId > 0)
            {
                var att = await _attachFile.GetAttachFileNoDataListAsync(new AttachFile()
                {
                    ReferenceId = refId,
                    ReferenceTable = refTable,
                    ReferenceGroup = refCmp
                });
                attImgList.AddRange(att);
            }
            else
            {
                if (fileGuidId != null)
                {
                    string[] arrFileGuid = fileGuidId.Split("||");
                    foreach (var rFile in arrFileGuid)
                    {
                        if (!string.IsNullOrEmpty(rFile))
                        {
                            var att = await _attachFile.GetAttachFileGuidAsync(rFile);
                            if (att != null) attImgList.Add(att);
                        }
                    }
                }
            }

            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["fileGuidId"] = fileGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            return PartialView("_RenderAttachFileImageList", attImgList);
        }





        public async Task<IActionResult> ViewAttachFileImage(string Id, string refTable = null, string refCmp = null, string inline = "Y")
        {
            var att = await _attachFile.GetAttachFileImageGuidAsync(Id);
            if (att != null)
            {
                if (inline == "Y")
                {
                    return File(att.ImageData, "image/jpeg");
                }
                else
                {
                    return File(att.ImageData, att.Extension, att.Filename);
                }
            }

            return Content("File not found");


        }


        [HttpPost]
        public async Task<ActionResult> AddItemImage(string[] fileGuidId, string[] imageName, int refId, string refGuidId, string refCmp, string refTable, string eleId, string read)
        {
            //AttachFileViewModel attImg = new AttachFileViewModel();
            var attImgList = new List<AttachFile>();

            var count = 0;
            if (imageName != null && imageName.Length > 0) count = imageName.Count();

            var i = 0;
            if (fileGuidId != null)
            {
                foreach (var itm in fileGuidId)
                {
                    var guid = Guid.Parse(itm);
                    var att = await _attachFile.GetAttachFileGuidAsync(guid.ToString());
                    //var att = await _attachFile.GetAttachFileGuidNoDataAsync(guid.ToString());
                    att.Filename = imageName[i];
                    attImgList.Add(att);
                    i++;
                }
            }
            TempData["eleId"] = eleId;
            TempData["refId"] = refId;
            TempData["refGuidId"] = refGuidId;
            TempData["refTable"] = refTable;
            TempData["refCmp"] = refCmp;
            TempData["readOnly"] = read;
            TempData["fileGuidId"] = string.Join("||", fileGuidId);
            attImgList.Add(new AttachFile());
            if (count != 0 && count == attImgList.Count()) ViewBag.errorAddImg = "กรุณาใส่รูปให้ครบก่อนเพิ่มรูปภาพ";
            return PartialView("_RenderAttachFileImageList", attImgList);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFile(string fileGuid)
        {
            var res = new ApiResultsModel();
            res = await _attachFile.DeleteAttachFileGuidAsync(fileGuid);
            return Json(res);

        }

        [HttpPost]
        public async Task<IActionResult> DeleteFileImage(string fileGuid)
        {
            var res = new ApiResultsModel();
            res = await _attachFile.DeleteAttachFileImageGuidAsync(fileGuid);
            return Json(res);

        }


        #endregion

    }
}
