$(function () { 

    //-------- Fix Class .js-table Default --------//
    $('.js-table').DataTable({
        //language: {
        //    search: "_INPUT_",
        //    searchPlaceholder: "ค้นหา",
        //    sInfoFiltered: "(กรองจากทั้งหมด _MAX_ รายการ)",
        //    zeroRecords: "ไม่พบข้อมูล",
        //    lengthMenu: "แสดง _MENU_ รายการ",
        //    info: "แสดง _START_ ถึง _END_ จากทั้งหมด _TOTAL_ รายการ",
        //    sInfoEmpty: "แสดง 0 ถึง 0 จากทั้งหมด 0 รายการ",
        //    paginate: {
        //        previous: "ก่อนหน้า",
        //        next: "ถัดไป"
        //    }
        //},
        //"lengthMenu": [[25, 50, 100], [25, 50, 100]],
        language: {
            url: `${baseURL}/js/th.json`,
        },
        "paging": true,
        "searching": false,
        "lengthChange": true,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        "responsive": true,
        responsive: {
            details: {
                display: $.fn.dataTable.Responsive.display.childRowImmediate,
                type: 'none',
                target: ''
            }
        },
        "pageLength": 10,
        deferLoading: 10,
        dom: '<"float-left"f>rt<"row"<"col-sm-4"i><"col-sm-4 text-center"l><"col-sm-4"p>>'
        //dom: "<'row'<'col-sm-4 col-md-4'i><'col-sm-4 text-center'l><'col-sm-4 col-md-4'p>>" +
        //    "<'row'<'col-sm-12'tr>>" +
        //    "<'row'<'col-sm-4 col-md-4'i><'col-sm-4 text-center'l><'col-sm-4'p>>",


    });
    //-------- Fix Class .js-table Default End. --------//

    //-------- Fix Class .js-table-search Default --------//
    $('.js-table-search').DataTable({
        //language: {
        //    search: "_INPUT_",
        //    searchPlaceholder: "ค้นหา",
        //    sInfoFiltered: "(กรองจากทั้งหมด _MAX_ รายการ)",
        //    zeroRecords: "ไม่พบข้อมูล",
        //    lengthMenu: "แสดง _MENU_ รายการ",
        //    info: "แสดง _START_ ถึง _END_ จากทั้งหมด _TOTAL_ รายการ",
        //    sInfoEmpty: "แสดง 0 ถึง 0 จากทั้งหมด 0 รายการ",
        //    paginate: {
        //        previous: "ก่อนหน้า",
        //        next: "ถัดไป"
        //    }
        //},
        //"lengthMenu": [[25, 50, 100], [25, 50, 100]],
        language: {
            url: `${baseURL}/js/th.json`,
        },
        "paging": true,
        "searching": true,
        "lengthChange": true,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        "responsive": true,
        responsive: {
            details: {
                display: $.fn.dataTable.Responsive.display.childRowImmediate,
                type: 'none',
                target: ''
            }
        },
        "pageLength": 10,
        deferLoading: 10,
        dom: '<"float-left"f>rt<"row"<"col-sm-4"i><"col-sm-4 text-center"l><"col-sm-4"p>>'
        //dom: "<'row'<'col-sm-4 col-md-4'i><'col-sm-4 text-center'l><'col-sm-4 col-md-4'p>>" +
        //    "<'row'<'col-sm-12'tr>>" +
        //    "<'row'<'col-sm-4 col-md-4'i><'col-sm-4 text-center'l><'col-sm-4'p>>",


    });
    //-------- Fix Class .js-table Default End. --------//

    //-------- Fix Class .js-table Default --------//
    $('.js-table-notorder').DataTable({
        language: {
            url: `${baseURL}/js/th.json`,
        },
        "paging": true,
        "searching": false,
        "lengthChange": true,
        "ordering": false,
        "info": true,
        "autoWidth": false,
        "responsive": true,
        responsive: {
            details: {
                display: $.fn.dataTable.Responsive.display.childRowImmediate,
                type: 'none',
                target: ''
            }
        },
        "pageLength": 10,
        deferLoading: 10,
        dom: '<"float-left"f>rt<"row"<"col-sm-4"i><"col-sm-4 text-center"l><"col-sm-4"p>>'
    });
    //-------- Fix Class .js-table Default End. --------//

});



function ReBindDataTable(tableName) {

    $(tableName).DataTable({
        language: {
            url: `${baseURL}/js/th.json`,
        },
        "paging": true,
        "searching": true,
        "lengthChange": true,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        "responsive": true,
        responsive: {
            details: {
                display: $.fn.dataTable.Responsive.display.childRowImmediate,
                type: 'none',
                target: ''
            }
        },
        "pageLength": 10,
        deferLoading: 10,
        dom: '<"float-left"f>rt<"row"<"col-sm-4"i><"col-sm-4 text-center"l><"col-sm-4"p>>'
        //dom: "<'row'<'col-sm-4 col-md-4'i><'col-sm-4 text-center'l><'col-sm-4 col-md-4'p>>" +
        //    "<'row'<'col-sm-12'tr>>" +
        //    "<'row'<'col-sm-4 col-md-4'i><'col-sm-4 text-center'l><'col-sm-4'p>>",


    });

}



function ReBindDataTableNoSearch(tableName) {

    $(tableName).DataTable({
        language: {
            url: `${baseURL}/js/th.json`,
        },
        "paging": true,
        "searching": false,
        "lengthChange": true,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        "responsive": true,
        responsive: {
            details: {
                display: $.fn.dataTable.Responsive.display.childRowImmediate,
                type: 'none',
                target: ''
            }
        },
        "pageLength": 10,
        deferLoading: 10,
        dom: '<"float-left"f>rt<"row"<"col-sm-4"i><"col-sm-4 text-center"l><"col-sm-4"p>>'
        //dom: "<'row'<'col-sm-4 col-md-4'i><'col-sm-4 text-center'l><'col-sm-4 col-md-4'p>>" +
        //    "<'row'<'col-sm-12'tr>>" +
        //    "<'row'<'col-sm-4 col-md-4'i><'col-sm-4 text-center'l><'col-sm-4'p>>",


    });

}