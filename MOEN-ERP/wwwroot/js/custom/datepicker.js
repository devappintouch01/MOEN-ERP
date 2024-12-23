
const elements = document.querySelectorAll('.datetimepicker');

elements.forEach(x => {
    const td = new tempusDominus.TempusDominus(x, {
        localization: {
            locale: 'th',
            format: 'dd/MM/yyyy HH:mm',
        },
        display: {
            viewMode: "clock",
            components: {
                clock: false,
            },
            icons: {
                time: 'bi bi-clock',
                date: 'bi bi-calendar',
                up: 'bi bi-arrow-up',
                down: 'bi bi-arrow-down',
                previous: 'bi bi-chevron-left',
                next: 'bi bi-chevron-right',
                today: 'bi bi-calendar-check',
                clear: 'bi bi-trash',
                close: 'bi bi-x',
            },
            buttons: {
                today: true,
                clear: true,
                close: true,
            },
        },
        useCurrent: false,

    });

    //----datepicker disable keyboard input
    x.addEventListener("keydown", function (e) {
        e.preventDefault();
    });

});

const em = document.querySelectorAll('.timepicker');

em.forEach(x => {
    const td = new tempusDominus.TempusDominus(x, {
        localization: {
            locale: 'th',
            format: 'dd/MM/yyyy HH:mm',
        },
        display: {
            viewMode: 'clock',
            components: {
                decades: false,
                year: false,
                month: false,
                date: false,
                hours: true,
                minutes: true,
                seconds: false
            }
        },
        stepping: 30,
        useCurrent: false,

    });

});




function SetRealteDate(Date1, Date2) {

    const linkedPicker1Element = document.getElementById(Date1);
    const linkedPicker2Element = document.getElementById(Date2);
    const linked1 = new tempusDominus.TempusDominus(linkedPicker1Element, {
        localization: {
            locale: 'th',
            format: 'dd/MM/yyyy HH:mm',
        },
        display: {
            components: {
                clock: false,
            },
            icons: {
                time: 'bi bi-clock',
                date: 'bi bi-calendar',
                up: 'bi bi-arrow-up',
                down: 'bi bi-arrow-down',
                previous: 'bi bi-chevron-left',
                next: 'bi bi-chevron-right',
                today: 'bi bi-calendar-check',
                clear: 'bi bi-trash',
                close: 'bi bi-x',
            },
            buttons: {
                today: true,
                clear: true,
                close: true,
            },
        },

        useCurrent: false,
    });



    const linked2 = new tempusDominus.TempusDominus(document.getElementById(Date2), {
        localization: {
            locale: 'th',
            format: 'dd/MM/yyyy HH:mm',
        },
        display: {
            components: {
                clock: false,
            },
            icons: {
                time: 'bi bi-clock',
                date: 'bi bi-calendar',
                up: 'bi bi-arrow-up',
                down: 'bi bi-arrow-down',
                previous: 'bi bi-chevron-left',
                next: 'bi bi-chevron-right',
                today: 'bi bi-calendar-check',
                clear: 'bi bi-trash',
                close: 'bi bi-x',
            },
            buttons: {
                today: true,
                clear: true,
                close: true,
            },
        },
        useCurrent: false,
    });

    //using event listeners
    linkedPicker1Element.addEventListener("change.td", (e) => {
        linked2.updateOptions({
            restrictions: {
                minDate: e.detail.date,
            },
            useCurrent: true,
        });
    });

    //using subscribe method
    linkedPicker2Element.addEventListener("change.td", (e) => {
        linked1.updateOptions({
            restrictions: {
                maxDate: e.date,
            },
            useCurrent: true,
        });
    });

    //----datepicker disable keyboard input
    linkedPicker1Element.addEventListener("keydown", function (e) {
        e.preventDefault();
    });
    //----datepicker disable keyboard input
    linkedPicker2Element.addEventListener("keydown", function (e) {
        e.preventDefault();
    });

}



function SetRealteMinDate(Date1, Date2) {

    var currentDate = new tempusDominus.DateTime();

    currentDate.setHours(0);
    currentDate.setMinutes(0);
    currentDate.setSeconds(0);
    currentDate.setMilliseconds(0);
    // Subtract one day
    //currentDate.setDate(currentDate.getDate() - 1);

    //later.hours = 8;

    const linkedPicker1Element = document.getElementById(Date1);
    const linkedPicker2Element = document.getElementById(Date2);
    const linked1 = new tempusDominus.TempusDominus(linkedPicker1Element, {
        localization: {
            locale: 'th',
            format: 'dd/MM/yyyy HH:mm',
        },
        restrictions: {
            minDate: currentDate,
        },
        display: {
            components: {
                clock: false,
            },
            icons: {
                time: 'bi bi-clock',
                date: 'bi bi-calendar',
                up: 'bi bi-arrow-up',
                down: 'bi bi-arrow-down',
                previous: 'bi bi-chevron-left',
                next: 'bi bi-chevron-right',
                today: 'bi bi-calendar-check',
                clear: 'bi bi-trash',
                close: 'bi bi-x',
            },
            buttons: {
                today: true,
                clear: true,
                close: true,
            },
        },
        useCurrent: false,
    });



    const linked2 = new tempusDominus.TempusDominus(document.getElementById(Date2), {
        localization: {
            locale: 'th',
            format: 'dd/MM/yyyy HH:mm',
        },
        restrictions: {
            minDate: currentDate,
        },
        display: {
            components: {
                clock: false,
            },
            icons: {
                time: 'bi bi-clock',
                date: 'bi bi-calendar',
                up: 'bi bi-arrow-up',
                down: 'bi bi-arrow-down',
                previous: 'bi bi-chevron-left',
                next: 'bi bi-chevron-right',
                today: 'bi bi-calendar-check',
                clear: 'bi bi-trash',
                close: 'bi bi-x',
            },
            buttons: {
                today: true,
                clear: true,
                close: true,
            },
        },

        useCurrent: false,
    });

    //using event listeners
    linkedPicker1Element.addEventListener("change.td", (e) => {
        linked2.updateOptions({
            restrictions: {
                minDate: e.detail.date,
            },
            useCurrent: true,
        });
    });

    //using subscribe method
    linkedPicker2Element.addEventListener("change.td", (e) => {
        linked1.updateOptions({
            restrictions: {
                maxDate: e.date,
            },
            useCurrent: true,
        });
    });

    //----datepicker disable keyboard input
    linkedPicker1Element.addEventListener("keydown", function (e) {
        e.preventDefault();
    });
    //----datepicker disable keyboard input
    linkedPicker2Element.addEventListener("keydown", function (e) {
        e.preventDefault();
    });

}


function SetBetweenDate(Id, DateForm, DateTo) {

    const minDate = new Date(DateForm);
    minDate.setFullYear(minDate.getFullYear() - 543);

    var min = new tempusDominus.DateTime();
    min.setHours(0);
    min.setMinutes(0);
    min.setSeconds(0);
    min.setMilliseconds(0);
    min.setFullYear(minDate.getFullYear());
    min.setMonth(minDate.getMonth());
    min.setDate(minDate.getDate());


    const maxDate = new Date(DateTo);
    maxDate.setFullYear(maxDate.getFullYear() - 543);

    var max = new tempusDominus.DateTime();
    max.setHours(0);
    max.setMinutes(0);
    max.setSeconds(0);
    max.setMilliseconds(0);
    max.setFullYear(maxDate.getFullYear());
    max.setMonth(maxDate.getMonth());
    max.setDate(maxDate.getDate());

    const linkedPickerElement = document.getElementById(Id);
    const linked = new tempusDominus.TempusDominus(linkedPickerElement, {
        localization: {
            locale: 'th',
            format: 'dd/MM/yyyy HH:mm',
        },
        restrictions: {
            maxDate: max,
            minDate: min,
        },
        display: {
            components: {
                clock: false,
            },
            icons: {
                time: 'bi bi-clock',
                date: 'bi bi-calendar',
                up: 'bi bi-arrow-up',
                down: 'bi bi-arrow-down',
                previous: 'bi bi-chevron-left',
                next: 'bi bi-chevron-right',
                today: 'bi bi-calendar-check',
                clear: 'bi bi-trash',
                close: 'bi bi-x',
            },
            buttons: {
                today: true,
                clear: true,
                close: true,
            },
        },
        useCurrent: false,
    });


    //----datepicker disable keyboard input
    linkedPickerElement.addEventListener("keydown", function (e) {
        e.preventDefault();
    });

}

function SetInputDate(InputDate) {
    const linkedPicker1Element = document.getElementById(InputDate);
    const td = new tempusDominus.TempusDominus(linkedPicker1Element, {
        localization: {
            format: 'dd/MM/yyyy',
            locale: 'th',
        },
        display: {
            components: {
                clock: false,
            },
            icons: {
                time: 'bi bi-clock',
                date: 'bi bi-calendar',
                up: 'bi bi-arrow-up',
                down: 'bi bi-arrow-down',
                previous: 'bi bi-chevron-left',
                next: 'bi bi-chevron-right',
                today: 'bi bi-calendar-check',
                clear: 'bi bi-trash',
                close: 'bi bi-x',
            },
            buttons: {
                today: true,
                clear: true,
                close: true,
            },
        },

        useCurrent: false,
    });

    //----datepicker disable keyboard input
    linkedPicker1Element.addEventListener("keydown", function (e) {
        e.preventDefault();
    });

}

function SetInputTime(InputDate) {
    const linkedPicker1Element = document.getElementById(InputDate);
    const td = new tempusDominus.TempusDominus(linkedPicker1Element, {
        localization: {
            locale: 'th',
            format: 'dd/MM/yyyy HH:mm',
        },
        display: {
            viewMode: 'clock',
            components: {
                decades: false,
                year: false,
                month: false,
                date: false,
                hours: true,
                minutes: true,
                seconds: false
            }
        },
        stepping: 30,
        useCurrent: false,

    });

}


//function RecreateTempusDominusDatepicker(inputId) {
//    const inputElement = document.getElementById(inputId);

//    if (inputElement) {
//        // ลบองค์ประกอบที่เกี่ยวข้องกับ Tempus Dominus Datepicker
//        const parent = inputElement.parentNode;
//        parent.removeChild(inputElement);

//        // สร้าง Input Element ใหม่และกำหนด ID และค่าอื่น ๆ ตามที่คุณต้องการ
//        const newInputElement = document.createElement('input');
//        newInputElement.id = inputId;
//        // ตั้งค่าอื่น ๆ ตามที่คุณต้องการ

//        // เพิ่ม Input Element ใหม่ลงใน DOM
//        parent.appendChild(newInputElement);

//        // สร้าง Tempus Dominus Datepicker ใหม่
//        new tempusDominus.TempusDominus(newInputElement, {
//            // การกำหนดค่า Datepicker ใหม่ที่คุณต้องการ
//        });
//    }
//}