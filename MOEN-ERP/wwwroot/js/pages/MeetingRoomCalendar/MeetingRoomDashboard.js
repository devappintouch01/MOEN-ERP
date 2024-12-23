//function showDetail() {
//    $('#divCalendar').hide();
//    $('#divDetail').show();
//}


function GenTimline(dateStart) {
    var calendarEl1 = document.getElementById('calendar1');
    var calendar1 = new FullCalendar.Calendar(calendarEl1, {
        schedulerLicenseKey: '0556526910-fcs-1680575437',
        timeZone: 'UTC',
        locale: 'th',
        initialView: 'resourceTimelineDay',
        aspectRatio: 1.8,
        expandRows: false,
        handleWindowResize: true,
        windowResizeDelay: 100,
        editable: false,
        headerToolbar: false,
        displayEventTime: true,
        displayEventEnd: true,
        resourceAreaHeaderContent: 'ห้องประชุม',
        eventMouseEnter: function (arg) {
            //console.log(arg);
            formatArgs({
                id: arg.event.id,
                title: arg.event.title,
                description: arg.event.extendedProps.description,
                bookerName: arg.event.extendedProps.bookerName,
                topic: arg.event.extendedProps.topic,
                bookerOrgName: arg.event.extendedProps.bookerOrgName,
                bookerPhone: arg.event.extendedProps.bookerPhone,
                location: arg.event.extendedProps.location,
                startStr: arg.event.startStr,
                endStr: arg.event.allDay == false ? arg.event.endStr : moment(arg.event.endStr).add(-1, 'day'),
                meetingRoomName: arg.event.extendedProps.meetingRoomName,
                allDay: arg.event.allDay,
                realUserName: arg.event.extendedProps.realUserName
            });

            // Show popover preview
            initPopovers(arg.el);
        },
        eventMouseLeave: function (info) {
            hidePopovers();
        },
        views: {
            resourceTimelineDay: {
                slotDuration: "00:30:00",
                slotMinTime: "00:00",
                slotMaxTime: "24:00",
                //titleFormat: { day: '2-digit', month: 'short' },
                slotLabelFormat: [
                    { weekday: 'long' },
                    //{ hour: 'numeric', minute: '2-digit', omitZeroMinute: true, meridiem: 'short' },
                    //   // { hour: "2-digit", minute:"", meridiem },
                    { hour: "2-digit", minute: "2-digit" },

                ],
            },
        },
        eventTimeFormat: { // like '14:30:00'
            hour: '2-digit',
            minute: '2-digit',
            meridiem: false
        },
        resources: {
            url: `${baseURL}/MeetingRoomCalendar/GetEventsTimelineResourcesMeetingRoom?dateStart=${dateStart}`,
            method: 'POST',
        },
        events: {
            url: `${baseURL}/MeetingRoomCalendar/GetEventsTimelineMeetingRoom?dateStart=${dateStart}`,
            method: 'POST',
        },
    });
    calendar1.render();
    calendar1.gotoDate(datestart);

}

$(function () {


    //-- Room
    var calendarEl = document.getElementById('calendarRoom');
    var calendar = new FullCalendar.Calendar(calendarEl, {
        schedulerLicenseKey: '0556526910-fcs-1680575437',
        timeZone: 'Asia/Bangkok',
        locale: 'th',
        contentHeight: 'auto',
        initialView: 'dayGridMonth',
        disableDragging: true,
        displayEventTime: true,
        displayEventEnd: true,
        buttonText: {
            month: 'เดือน',
            day: 'วัน',
            week: 'สัปดาห์',
            today: 'วันนี้',
            prevYear: 'ปีก่อนหน้า',
            nextYear: 'ปีถัดไป'
        },
        headerToolbar: {
            start: 'prev,next today',
            center: 'title',
            end: 'dayGridMonth,timeGridWeek,timeGridDay',
        },
        eventMouseEnter: function (arg) {
            formatArgs({
                id: arg.event.id,
                title: arg.event.title,
                description: arg.event.extendedProps.description,
                bookerName: arg.event.extendedProps.bookerName,
                topic: arg.event.extendedProps.topic,
                bookerOrgName: arg.event.extendedProps.bookerOrgName,
                bookerPhone: arg.event.extendedProps.bookerPhone,
                location: arg.event.extendedProps.location,
                startStr: arg.event.startStr,
                endStr: arg.event.allDay == false ? arg.event.endStr : moment(arg.event.endStr).add(-1, 'day'),
                meetingRoomName: arg.event.extendedProps.meetingRoomName,
                allDay: arg.event.allDay,
                realUserName: arg.event.extendedProps.realUserName
            });

            //console.log(arg.event);
            // Show popover preview
            initPopovers(arg.el);
        },
        eventMouseLeave: function (info) {
            hidePopovers();
        },
        events: {
            url: `${baseURL}/MeetingRoomCalendar/GetEventsMeetingRoom`,
            method: 'GET',
            failure: function () {
                // Handle error here
            },
            color: 'blue', // Event color
            textColor: 'white' // Text color of the event
        },
        eventTimeFormat: { // like '14:30:00'
            hour: '2-digit',
            minute: '2-digit',
            meridiem: false
        },
        select: function (arg) {
            formatArgs({
                startStr: arg.startStr,
                endStr: arg.allDay == false ? arg.endStr : moment(arg.endStr).add(-1, 'day'),
                allDay: arg.allDay
            });
            moment.locale('th');
            const startDate = data.allDay ? toBuddhistYear(moment(data.startDate), 'LL') : toBuddhistYear(moment(data.startDate), 'LL');
            if (startDate != NaN) {
                $("#ModalTitile").text("ตารางเวลาการจองห้องประชุม วันที่ " + startDate)

            }

            $('#exampleModal').modal('show');
            datestart = arg.start;
            setTimeout(function () {
                GenTimline(arg.startStr);
            }, 300);



        },
        editable: true,
        selectable: true,
        firstDay: 1,
        navLinks: true, // can click day/week names to navigate views
        businessHours: true, // display business hours
        editable: false,
        selectMirror: false,
        longPressDelay: 0,
        selectLongPressDelay: 0,
        eventLongPressDelay: 0,
    });

    calendar.render();
    //-- Room



});



const initPopovers = (element) => {
    //console.log(element);
    //console.log(data);
    //hidePopovers();
    moment.locale('th');
    // Generate popover content
    const startDate = data.allDay ? toBuddhistYear(moment(data.startDate), 'LL') : toBuddhistYear(moment(data.startDate), 'LL');
    const endDate = data.allDay ? toBuddhistYear(moment(data.endDate), 'LL') : toBuddhistYear(moment(data.endDate), 'LL');
    var popoverHtml = '';
    if (startDate != undefined && endDate != 'Invalid date') {
        //popoverHtml = '<div class="fs-7"><span class="fw-bold">ผู้จอง:</span> นายทดสอบระบบ</div><div class="fs-7"><span class="fw-bold">หัวข้อ:</span> ประชุม</div> </div><div class="fs-7"><span class="fw-bold">หน่วยงาน:</span> ตัวอย่างหน่วยงาน</div> </div><div class="fs-7"><span class="fw-bold">วันที่เริ่มต้น:</span> ' + startDate + '</div><div class="fs-7 mb-4"><span class="fw-bold">วันที่สิ้นสุด:</span> ' + endDate;
        popoverHtml = '<div class="fs-7"><span class="fw-bold">เรื่อง/คณะที่ประชุม:</span> ' + data.topic + '</div>' +
            '<div class="fs-7"><span class="fw-bold">ผู้ประสงค์ใช้ห้องประชุม:</span> ' + data.realUserName + '</div>' +
            '<div class="fs-7"><span class="fw-bold">เบอร์โทรศัพท์:</span> ' + data.bookerPhone + '</div>' +
            '<div class="fs-7"><span class="fw-bold">หน่วยงาน:</span> ' + data.bookerOrgName + '</div>' +
            '<div class="fs-7"><span class="fw-bold">ประเภท:</span> ' + data.eventName + '</div>' +
            '<div class="fs-7"><span class="fw-bold">ห้องประชุม:</span> ' + data.meetingRoomName + '</div>';
            
            

    }
    else {
        //popoverHtml = '<div class="fw-bolder mb-2">' + data.eventName + '</div><div class="fs-7"><span class="fw-bold">วันที่เริ่มต้น:</span> ' + startDate + '</div><div class="fs-7 mb-4"><span class="fw-bold">วันที่สิ้นสุด:</span> ' + startDate;
        popoverHtml = '<div class="fs-7"><span class="fw-bold">เรื่อง/คณะที่ประชุม:</span> ' + data.topic + '</div>' +
            '<div class="fs-7"><span class="fw-bold">ผู้ประสงค์ใช้ห้องประชุม:</span> ' + data.realUserName + '</div>' +
            '<div class="fs-7"><span class="fw-bold">เบอร์โทรศัพท์:</span> ' + data.bookerPhone + '</div>' +
            '<div class="fs-7"><span class="fw-bold">หน่วยงาน:</span> ' + data.bookerOrgName + '</div>' +
            '<div class="fs-7"><span class="fw-bold">ประเภท:</span> ' + data.eventName + '</div>' +
            '<div class="fs-7"><span class="fw-bold">ห้องประชุม:</span> ' + data.meetingRoomName + '</div>';

    }

    // Popover options
    var options = {
        container: 'body',
        trigger: 'manual',
        boundary: 'window',
        placement: 'auto',
        dismiss: true,
        html: true,
        title: 'รายละเอียด',
        content: popoverHtml,
    }

    // Initialize popover
    popover = KTApp.initBootstrapPopover(element, options);

    // Show popover
    popover.show();

    //// Update popover state
    //popoverState = true;
    //setTimeout(function () {
    //    hidePopovers();
    //}, 3000);

}


// Hide active popovers
const hidePopovers = () => {
    if (popover) {
        popover.dispose();
        //popoverState = false;

    }
}

// Format FullCalendar reponses
const formatArgs = (res) => {
    data.id = res.id;
    data.eventName = res.title;
    data.bookerName = res.bookerName;
    data.topic = res.topic;
    data.bookerOrgName = res.bookerOrgName;
    data.bookerPhone = res.bookerPhone;
    data.bookingPurpose = res.bookingPurpose;
    data.driverName = res.driverName;
    data.driverPhone = res.driverPhone;
    data.eventDescription = res.eventDescription;
    data.eventLocation = res.eventLocation;
    data.startDate = res.startStr;
    data.endDate = res.endStr;
    data.meetingRoomName = res.meetingRoomName;
    data.allDay = res.allDay;
    data.realUserName = res.realUserName;
}

var data = {
    id: '',
    eventName: '',
    bookerName: '',
    topic: '',
    bookerOrgName: '',
    bookerPhone: '',
    bookingPurpose: '',
    driverName: '',
    driverPhone: '',
    eventDescription: '',
    eventLocation: '',
    startDate: '',
    endDate: '',
    meetingRoomName: '',
    allDay: false,
    realUserName: ''
};


var datestart;
var popover;
var popoverState = false;


function toBuddhistYear(moment, format) {
    var christianYear = moment.format('YYYY');
    var buddhishYear = (parseInt(christianYear) + 543).toString();
    return moment
        .format(format.replace('YYYY', buddhishYear).replace('YY', buddhishYear.substring(2, 4)))
        .replace(christianYear, buddhishYear)
}
