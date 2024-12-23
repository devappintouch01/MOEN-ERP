//--------------------------- File อัพได้ไฟล์เดียว -------------------------------//
function AttachFileImage(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {

    $.ajax({
        url: `${baseURL}/AttachFile/RenderAttachFileImage`,
        type: 'post',
        data: { eleId: eleId, refId: refId, refGuidId: refGuidId, fileGuidId: fileGuidId, refTable: refTable, refCmp: refCmp, read: read },
        success: function (data) {
            $('#' + eleId).html(data);
        }
    });

}

function initFileImageDropArea(dropImgId, eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {
    //console.log(fileGuidId);
    $('div#' + dropImgId + ' .needsclick').dropzone({
        url: `${baseURL}/AttachFile/UplaodFileImage`,
        paramName: "file",
        maxFilesize: 20,
        acceptedFiles: "image/png,image/jpeg",
        uploadMultiple: false,
        clickable: true,
        createImageThumbnails: false,
        init: function () {
            this.on("error", function (file, message) {
                return Swal.fire({
                    title: "รองรับไฟล์ .pdf ขนาดไม่เกิน 30 MB",
                    icon: "error",
                    buttoUrls: "ปิด",
                });

            });
            this.on("sending", function (file, xhr, formData) {
                formData.append('refTable', refTable);
                formData.append('refId', refId);
                formData.append('refCmp', refCmp);
            });
        },
        complete: function (file) {
            // console.log(file);
            if (file.status != "error") {
                this.removeAllFiles();
                var resp = jQuery.parseJSON(file.xhr.response);
                // console.log(resp);
                if (file.status == "success" && resp.success == true) {
                    //var resData = JSON.stringify(resp);
                    console.log(resp);
                    console.log(resp.attach.rowGuid);
                    //console.log(resData.rowGuid);
                    fileGuidId += '||' + resp.attach.rowGuid;
                    AttachFileImage(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read);
                }
                else {
                    Swal.fire({
                        title: resp.remark,
                        icon: "error",
                        buttoUrls: "ปิด",
                    });
                }
            }
            else {
                this.removeAllFiles();

            }

        }
    });

}

function AttachFileImage(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {
    $.ajax({
        url: `${baseURL}/AttachFile/RenderAttachFileImage`,
        type: 'post',
        data: { eleId: eleId, refId: refId, refGuidId: refGuidId, fileGuidId: fileGuidId, refTable: refTable, refCmp: refCmp, read: read },
        success: function (data) {
            $('#' + eleId).html(data);
        }
    });

}

function deleteImage(fileGuid, eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {
    console.log(fileGuid);
    console.log(eleId);
    console.log(refId);
    console.log(refGuidId);
    console.log(fileGuidId);
    console.log(refTable);
    console.log(refCmp);
    console.log(read);
    $.post(`${baseURL}/AttachFile/DeleteFileImage?fileGuid=${fileGuid}`)
        .done(function (msg) {
            // $('#' + dropId).remove();
            AttachFileImage(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read);
        });
    hideWait();
}

//--------------------------- File อัพได้ไฟล์เดียว End. -------------------------------//




//--------------------------- File List -------------------------------//
function AttachFile(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read, list) {
    $.ajax({
        url: `${baseURL}/AttachFile/RenderAttachFileList`,
        type: 'post',
        data: { eleId: eleId, refId: refId, refGuidId: refGuidId, fileGuidId: fileGuidId, refTable: refTable, refCmp: refCmp, read: read, list: list },
        success: function (data) {
            $('#' + eleId).html(data);
        }
    });

}

function initFileDropArea(dropImgId, eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read, list) {
    //console.log(fileGuidId);
    $('div#' + dropImgId + ' .needsclick').dropzone({
        url: `${baseURL}/AttachFile/UplaodFile`,
        paramName: "file",
        maxFilesize: 30,
        acceptedFiles: "image/jpeg,image/png,application/pdf",
        uploadMultiple: false,
        clickable: true,
        createImageThumbnails: false,
        init: function () {
            this.on("error", function (file, message) {
                return Swal.fire({
                    title: "รองรับไฟล์ .pdf , .jpg , .png (ขนาดไม่เกิน 30 MB)",
                    icon: "error",
                    buttoUrls: "ปิด",
                });

            });
            this.on("sending", function (file, xhr, formData) {
                formData.append('refTable', refTable);
                formData.append('refId', refId);
                formData.append('refCmp', refCmp);
            });
        },
        complete: function (file) {
            // console.log(file);
            if (file.status != "error") {
                this.removeAllFiles();
                var resp = jQuery.parseJSON(file.xhr.response);
                // console.log(resp);
                if (file.status == "success" && resp.success == true) {
                    //var resData = JSON.stringify(resp);
                    console.log(resp);
                    console.log(resp.attach.rowGuid);
                    //console.log(resData.rowGuid);
                    fileGuidId += '||' + resp.attach.rowGuid;
                    AttachFile(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read, list);
                }
                else {
                    Swal.fire({
                        title: resp.remark,
                        icon: "error",
                        buttoUrls: "ปิด",
                    });
                }
            }
            else {
                this.removeAllFiles();

            }

        }
    });

}

//--------------------------- File End. -------------------------------//




//--------------------------- File PDF List -------------------------------//
function AttachFilePDFList(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {

    $.ajax({
        url: `${baseURL}/AttachFile/RenderAttachFilePDFList`,
        type: 'post',
        data: { eleId: eleId, refId: refId, refGuidId: refGuidId, fileGuidId: fileGuidId, refTable: refTable, refCmp: refCmp, read: read },
        success: function (data) {
            $('#' + eleId).html(data);
        }
    });

}

function initFilePDFListDropArea(dropImgId, eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {
    //console.log(fileGuidId);
    $('div#' + dropImgId + ' .needsclick').dropzone({
        url: `${baseURL}/AttachFile/UplaodFile`,
        paramName: "file",
        maxFilesize: 30,
        acceptedFiles: "application/pdf",
        uploadMultiple: false,
        clickable: true,
        createImageThumbnails: false,
        init: function () {
            this.on("error", function (file, message) {
                return Swal.fire({
                    title: "รองรับไฟล์ .pdf (ขนาดไม่เกิน 30 MB)",
                    icon: "error",
                    buttoUrls: "ปิด",
                });

            });
            this.on("sending", function (file, xhr, formData) {
                formData.append('refTable', refTable);
                formData.append('refId', refId);
                formData.append('refCmp', refCmp);
            });
        },
        complete: function (file) {
            // console.log(file);
            if (file.status != "error") {
                this.removeAllFiles();
                var resp = jQuery.parseJSON(file.xhr.response);
                // console.log(resp);
                if (file.status == "success" && resp.success == true) {
                    //var resData = JSON.stringify(resp);
                    console.log(resp);
                    console.log(resp.attach.rowGuid);
                    //console.log(resData.rowGuid);
                    fileGuidId += '||' + resp.attach.rowGuid;
                    AttachFilePDFList(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read);
                }
                else {
                    Swal.fire({
                        title: resp.remark,
                        icon: "error",
                        buttoUrls: "ปิด",
                    });
                }
            }
            else {
                this.removeAllFiles();

            }

        }
    });

}

//--------------------------- File PDF End. -------------------------------//



//--------------------------- File List Other Ms Word -------------------------------//

function AttachFileOtherMsWordList(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {

    $.ajax({
        url: `${baseURL}/AttachFile/RenderAttachFileOtherMsWordList`,
        type: 'post',
        data: { eleId: eleId, refId: refId, refGuidId: refGuidId, fileGuidId: fileGuidId, refTable: refTable, refCmp: refCmp, read: read },
        success: function (data) {
            $('#' + eleId).html(data);
        }
    });

}

function initFileOhterMsWordListDropArea(dropImgId, eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {
    //console.log(fileGuidId);
    $('div#' + dropImgId + ' .needsclick').dropzone({
        url: `${baseURL}/AttachFile/UplaodFile`,
        paramName: "file",
        maxFilesize: 30,
        acceptedFiles: "image/jpeg,image/png,application/pdf,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document",
        uploadMultiple: false,
        clickable: true,
        createImageThumbnails: false,
        init: function () {
            this.on("error", function (file, message) {
                return Swal.fire({
                    title: "รองรับไฟล์ .pdf , .jpg , .png, .doc, .docx (ขนาดไม่เกิน 30 MB)",
                    icon: "error",
                    buttoUrls: "ปิด",
                });

            });
            this.on("sending", function (file, xhr, formData) {
                formData.append('refTable', refTable);
                formData.append('refId', refId);
                formData.append('refCmp', refCmp);
            });
        },
        complete: function (file) {
            // console.log(file);
            if (file.status != "error") {
                this.removeAllFiles();
                var resp = jQuery.parseJSON(file.xhr.response);
                // console.log(resp);
                if (file.status == "success" && resp.success == true) {
                    //var resData = JSON.stringify(resp);
                    console.log(resp);
                    console.log(resp.attach.rowGuid);
                    //console.log(resData.rowGuid);
                    fileGuidId += '||' + resp.attach.rowGuid;
                    AttachFileOtherMsWordList(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read);
                }
                else {
                    Swal.fire({
                        title: resp.remark,
                        icon: "error",
                        buttoUrls: "ปิด",
                    });
                }
            }
            else {
                this.removeAllFiles();

            }

        }
    });

}

//--------------------------- File End. -------------------------------//


//--------------------------- Image List -------------------------------//
//-- eleId ==>> Id ของ Div
//-- refId ==>> Id ของ Reference
//-- refGuidId ==>> ชื่อ Propertie ของโมลเดลที่มารับ เป็น string[]
//-- fileGuidId ==>> string ของ Guid เอามาต่อกันคั่นด้วย ||
//-- refTable ==>> Reference 1
//-- refCmp ==>> Reference 2
//-- read ==>> ปิดเปิดการลบข้อมูล
function AttachImagesList(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {

    $.ajax({
        url: `${baseURL}/AttachFile/RenderAttachFileImageList`,
        type: 'post',
        data: { eleId: eleId, refId: refId, refGuidId: refGuidId, fileGuidId: fileGuidId, refTable: refTable, refCmp: refCmp, read: read },
        success: function (data) {
            $('#' + eleId).html(data);
        }
    });

}


function initImageDropArea(dropImgId, eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read) {
    console.log(fileGuidId);
    $('div#' + dropImgId + ' .placeholder').dropzone({
        url: `${baseURL}/AttachFile/UplaodFile`,
        paramName: "file",
        maxFilesize: 30,
        acceptedFiles: "image/*",
        uploadMultiple: false,
        clickable: true,
        createImageThumbnails: false,
        init: function () {
            this.on("error", function (file, message) {
                return Swal.fire({
                    title: "รองรับไฟล์ .pdf ขนาดไม่เกิน 30 MB",
                    icon: "error",
                    buttoUrls: "ปิด",
                });

            });
            this.on("sending", function (file, xhr, formData) {
                formData.append('refTable', refTable);
                formData.append('refId', refId);
                formData.append('refCmp', refCmp);
            });
        },
        complete: function (file) {
            // console.log(file);
            if (file.status != "error") {
                this.removeAllFiles();
                var resp = jQuery.parseJSON(file.xhr.response);
                // console.log(resp);
                if (file.status == "success" && resp.success == true) {
                    //var resData = JSON.stringify(resp);
                    console.log(resp);
                    console.log(resp.attach.rowGuid);
                    //console.log(resData.rowGuid);
                    fileGuidId += '||' + resp.attach.rowGuid;
                    AttachImagesList(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read);
                }
                else {
                    Swal.fire({
                        title: resp.remark,
                        icon: "error",
                        buttoUrls: "ปิด",
                    });
                }
            }
            else {
                this.removeAllFiles();

            }

        }
    });

}

function deleteImageList(dropId, fileGuid, eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read, list) {
    debugger;

    $.post(`${baseURL}/AttachFile/DeleteFile?fileGuid=${fileGuid}`)
        .done(function (msg) {
            //$('#' + dropId).remove();

            AttachFile(eleId, refId, refGuidId, fileGuidId, refTable, refCmp, read, list);


        });
    hideWait();
}

//--------------------------- Image End. -------------------------------//