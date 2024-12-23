// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).on("keydown", "form", function (event) {
    return event.key != "Enter";
});


function showWait() {
    $('#global-loader').fadeIn();
}

function hideWait() {
    $('#global-loader').fadeOut();
}


function handlePaste(event) {
    // Get the pasted text from the clipboard
    const pastedText = event.clipboardData.getData('text');

    // Remove non-numeric characters and set the input value
    event.target.value = pastedText.replace(/[^0-9]/g, '');

    // Prevent the default paste behavior
    event.preventDefault();
}


function OnlyNumbers(evt, setAlert) {
    if (evt.charCode > 31 && (evt.charCode < 48 || evt.charCode > 57)) {
        //alert("Allow Only Numbers");

        if (setAlert == true) {
            Swal.fire({
                title: 'ระบุได้เฉพาะตัวเลข',
                icon: "info",
                buttoUrls: "ปิด",
            });
        }

        return false;
    }
}

function OnlyNumbersDot(evt, setAlert) {
    if (evt.charCode == 46)
        return true
    if (evt.charCode > 31 && (evt.charCode < 48 || evt.charCode > 57)) {
        //alert("Allow Only Numbers");

        if (setAlert == true) {
            Swal.fire({
                title: 'ระบุได้เฉพาะตัวเลข',
                icon: "info",
                buttoUrls: "ปิด",
            });
        }

        return false;
    }
}


function OnlyNumbersTime(evt, setAlert) {
    if (evt.charCode > 31 && (evt.charCode < 48 || evt.charCode > 58)) {
        //alert("Allow Only Numbers");

        if (setAlert == true) {
            swal({ title: 'ระบุได้เฉพาะตัวเลข', text: '', type: 'info', confirmButtonText: 'ตกลง' });
        }

        return false;
    }
}

$(function () {
    moment.locale('th');

    //$('#global-loader').fadeOut("slow", function () { });
});


function initVehicleDropdown(vehicleBrand, vehicleModel) {

    $(vehicleBrand).on("change", function () {
        const vehicleBrandId = $(vehicleBrand).val();
        listVehicleModel(vehicleBrandId);
    });

    const listVehicleModel = (_vehicleBrandId) => {

        $.get(`${baseURL}/shared/relatevehiclemodel?vehiclebrandid=${_vehicleBrandId}`)
            .then(res => setDropdownVehicleModel(vehicleModel, res, i => i.id, i => i.name, 0));
    }
}

function setDropdownVehicleModel(selectEl, items, valueSelector, labelSelector, initVal = null, insertBlank = true) {
    const el = (selectEl.jquery) ? selectEl : $(selectEl);
    items = items || [];
    el.empty();
    if (insertBlank)
        el.append($("<option value='0'>ทั้งหมด</option>"));
    items.forEach(i => {
        el.append($("<option>").val(valueSelector(i)).html(labelSelector(i)));
    })
    el.val(initVal);
}

//-- DriverForAssign
function inintDropdownDriverForAssign(travelFromDate, travelToDate, vehicleType, vehicle, driver) {

    $(travelFromDate).on("change", function () {
        const travelFromDateValue = $(travelFromDate).val();
        const travelToDateValue = $(travelToDate).val();
        listDriver(travelFromDateValue, travelToDateValue);
    });

    $(travelToDate).on("change", function () {
        const travelFromDateValue = $(travelFromDate).val();
        const travelToDateValue = $(travelToDate).val();
        listDriver(travelFromDateValue, travelToDateValue);
    });

    $(vehicleType).on("change", function () {
        const travelFromDateValue = $(travelFromDate).val();
        const travelToDateValue = $(travelToDate).val();
        listDriver(travelFromDateValue, travelToDateValue);
    });

    $(vehicle).on("change", function () {
        const travelFromDateValue = $(travelFromDate).val();
        const travelToDateValue = $(travelToDate).val();
        listDriver(travelFromDateValue, travelToDateValue);
    });

    const listDriver = (_travelFromDateValue, _travelToDateValue) => {

        $.get(`${baseURL}/shared/relatedriverforassign?travelfromdatevalue=${_travelFromDateValue}&traveltodatevalue=${_travelToDateValue}`)
            .then(res => {
                console.log(res);
                setDropdownDriverForAssign(driver, res, i => i.id, i => i.fullName, 0);
            }
            );
    }

}

function setDropdownDriverForAssign(selectEl, items, valueSelector, labelSelector, initVal = null, insertBlank = true) {
    const el = (selectEl.jquery) ? selectEl : $(selectEl);
    items = items || [];
    el.empty();
    if (insertBlank)
        el.append($("<option value='0'>กรุณาเลืิอก</option>"));
    items.forEach(i => {
        el.append($("<option>").val(valueSelector(i)).html(labelSelector(i)));
    })
    el.val(initVal);
}

//--DriverForAssign End.

//-- VehicleForAssign

function inintDropdownVehicleForAssign(travelFromDate, travelToDate, vehicleType, vehicle) {

    $(travelFromDate).on("change", function () {
        const travelFromDateValue = $(travelFromDate).val();
        const travelToDateValue = $(travelToDate).val();
        const vehicleTypeValue = $(vehicleType).val();
        listVehicle(travelFromDateValue, travelToDateValue, vehicleTypeValue);
    });

    $(travelToDate).on("change", function () {
        const travelFromDateValue = $(travelFromDate).val();
        const travelToDateValue = $(travelToDate).val();
        const vehicleTypeValue = $(vehicleType).val();
        listVehicle(travelFromDateValue, travelToDateValue, vehicleTypeValue);
    });

    $(vehicleType).on("change", function () {
        const travelFromDateValue = $(travelFromDate).val();
        const travelToDateValue = $(travelToDate).val();
        const vehicleTypeValue = $(vehicleType).val();
        listVehicle(travelFromDateValue, travelToDateValue, vehicleTypeValue);
    });

    const listVehicle = (_travelFromDateValue, _travelToDateValue, _vehicleTypeValue) => {

        $.get(`${baseURL}/shared/relatevehicleforassign?travelfromdatevalue=${_travelFromDateValue}&traveltodatevalue=${_travelToDateValue}&vehicletypevalue=${_vehicleTypeValue}`)
            .then(res => {
                console.log(res);
                setDropdownVehicleForAssign(vehicle, res, i => i.id, i => i.vehicleRegistration, 0);
            }
            );
    }

}

function setDropdownVehicleForAssign(selectEl, items, valueSelector, labelSelector, initVal = null, insertBlank = true) {
    const el = (selectEl.jquery) ? selectEl : $(selectEl);
    items = items || [];
    el.empty();
    if (insertBlank)
        el.append($("<option value='0'>กรุณาเลืิอก</option>"));
    items.forEach(i => {
        el.append($("<option>").val(valueSelector(i)).html(labelSelector(i)));
    })
    el.val(initVal);
}

//-- VehicleForAssign End.




//-- LicenseForVideoConferenceBooking

function inintDropdownLicenseForVideoConferenceBooking(useFromDate, useToDate, useFromDateTime, useToDateTime, conferenceId, license) {

    $(useFromDate).on("change", function () {
        const useDateValue = $(useFromDate).val();
        const useToDateValue = $(useToDate).val();
        const useDateTimeValue = $(useFromDateTime).val();
        const useToDateTimeValue = $(useToDateTime).val();
        const conferenceIdValue = $(conferenceId).val();
        listLicense(useDateValue, useToDateValue, useDateTimeValue, useToDateTimeValue, conferenceIdValue);
    });

    $(useToDate).on("change", function () {
        const useDateValue = $(useFromDate).val();
        const useToDateValue = $(useToDate).val();
        const useDateTimeValue = $(useFromDateTime).val();
        const useToDateTimeValue = $(useToDateTime).val();
        const conferenceIdValue = $(conferenceId).val();
        listLicense(useDateValue, useToDateValue, useDateTimeValue, useToDateTimeValue, conferenceIdValue);
    });

    $(useFromDateTime).on("change", function () {
        const useDateValue = $(useFromDate).val();
        const useToDateValue = $(useToDate).val();
        const useDateTimeValue = $(useFromDateTime).val();
        const useToDateTimeValue = $(useToDateTime).val();
        const conferenceIdValue = $(conferenceId).val();
        listLicense(useDateValue, useToDateValue, useDateTimeValue, useToDateTimeValue, conferenceIdValue);
    });

    $(useToDateTime).on("change", function () {
        const useDateValue = $(useFromDate).val();
        const useToDateValue = $(useToDate).val();
        const useDateTimeValue = $(useFromDateTime).val();
        const useToDateTimeValue = $(useToDateTime).val();
        const conferenceIdValue = $(conferenceId).val();
        listLicense(useDateValue, useToDateValue, useDateTimeValue, useToDateTimeValue, conferenceIdValue);
    });

    $(conferenceId).on("change", function () {
        const useDateValue = $(useFromDate).val();
        const useToDateValue = $(useToDate).val();
        const useDateTimeValue = $(useFromDateTime).val();
        const useToDateTimeValue = $(useToDateTime).val();
        const conferenceIdValue = $(conferenceId).val();
        listLicense(useDateValue, useToDateValue, useDateTimeValue, useToDateTimeValue, conferenceIdValue);
    });

    const listLicense = (_useFromDateValue, _useToDateValue, _useFromDateTimeValue, _useToDateTimeValue, _conferenceIdValue) => {

        $.get(`${baseURL}/shared/relatelicenseforvideoconferencebooking?usefromdatevalue=${_useFromDateValue}&usetodatevalue=${_useToDateValue}&usefromdatetimevalue=${_useFromDateTimeValue}&usetodatetimevalue=${_useToDateTimeValue}&conferenceidvalue=${_conferenceIdValue}`)
            .then(res => {
                //console.log(res);
                setDropdownLicenseForVideoConferenceBooking(license, res, i => i.licenseId, i => i.licenseName, 0);
            }
            );
    }

}

function setDropdownLicenseForVideoConferenceBooking(selectEl, items, valueSelector, labelSelector, initVal = null, insertBlank = true) {
    const el = (selectEl.jquery) ? selectEl : $(selectEl);
    items = items || [];
    el.empty();
    if (insertBlank)
        el.append($("<option value='0'>กรุณาเลืิอก</option>"));
    items.forEach(i => {
        el.append($("<option>").val(valueSelector(i)).html(labelSelector(i)));
    })
    el.val(initVal);
}

//-- LicenseForVideoConferenceBooking End.


//function inintDropdownVehicleTypeForAssign(vehicleType, vehicle, vehicleBookingId) {
//    $(vehicleType).on("change", function () {
//        const vehicleTypeId = $(vehicleType).val();
//        listVehicle(vehicleBookingId,vehicleTypeId);
//    });

//    const listVehicle = (_vehicleBookingId,_vehicleTypeId) => {

//        $.get(`${baseURL}/shared/relatevehicleforassign?vehiclebookingid=${_vehicleBookingId}&vehicletypeid=${_vehicleTypeId}`)
//            .then(res => setDropdownVehicleForAssign(vehicle, res, i => i.id, i => i.vehicleRegistration,0));
//    }
//}

//function setDropdownVehicleForAssign(selectEl, items, valueSelector, labelSelector, initVal = null, insertBlank = true) {
//    const el = (selectEl.jquery) ? selectEl : $(selectEl);
//    items = items || [];
//    el.empty();
//    if (insertBlank)
//        el.append($("<option value='0'>กรุณาเลืิอก</option>"));
//    items.forEach(i => {
//        el.append($("<option>").val(valueSelector(i)).html(labelSelector(i)));
//    })
//    el.val(initVal);
//}



function SetRealteConferenceApplicationAndLicense(conference, license) {
    $(conference).on("change", function () {
        const conferenceId = $(conference).val();
        listLicense(conferenceId);
    });

    const listLicense = (_conferenceId) => {

        $.get(`${baseURL}/shared/relateConferenceLicense?conferenceId=${_conferenceId}`)
            .then(res => setDropdownConferenceLicense(license, res, i => i.id, i => i.licenseName, 0));
    }
}

function setDropdownConferenceLicense(selectEl, items, valueSelector, labelSelector, initVal = null, insertBlank = true) {
    const el = (selectEl.jquery) ? selectEl : $(selectEl);
    items = items || [];
    el.empty();
    if (insertBlank)
        el.append($("<option value='0'>กรุณาเลืิอก</option>"));
    items.forEach(i => {
        el.append($("<option>").val(valueSelector(i)).html(labelSelector(i)));
    })
    el.val(initVal);
}

//function countMaxLangth(_input, _label, _langth) {
//    var maxLength = _langth;
//    $(_input).keyup(function () {
//        var textlen = maxLength - $(this).val().length;
//        $(_label).text(textlen + "/" + _langth);
//    });
//}

toastr.options = {

    "closeButton": true,
    "debug": false,
    "newestOnTop": false,
    "progressBar": false,
    "positionClass": "toast-container p-3 top-0 start-50 translate-middle-x",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "2000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
};
