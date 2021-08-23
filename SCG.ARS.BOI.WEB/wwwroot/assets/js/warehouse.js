function initialControl() {
    //set full date to report header
    if ($('#reportHeader') != null)
        $('#reportHeader').text(uiHelpers.displayFullDate(new Date()));

    //initial search criteria section
    return initialSearchCriteria();
}

function GenerateDatatable(data, columns) {
    table = $('#dtList').DataTable({
        dom: 'lTf<"html5buttons"B > gtip',
        buttons: [
            'copy', 'excel'
            //, 'csv', 'excel', 'pdf', 'print'
        ],
        scrollX: true,
        scrollY:'40vh',
        "bSort": true,
        pageLength: 10,
        filter: true, // this is for disable filter (search box)
        "orderMulti": true, // for disable multiple column at once
        data: data,
        columns: columns,
        autoWidth: false

    });

}

function getMonthName(index) {
    var month = new Array();
    month[0] = "มกราคม";
    month[1] = "กุมภาพันธ์";
    month[2] = "มีนาคม";
    month[3] = "เมษายน";
    month[4] = "พฤษภาคม";
    month[5] = "มิถุนายน";
    month[6] = "กรกฎาคม";
    month[7] = "สิงหาคม";
    month[8] = "กันยายน";
    month[9] = "ตุลาคม";
    month[10] = "พฤศจิกายน";
    month[11] = "ธันวาคม";
    return month[index - 1];
}

function GetCustomer(warehouse, selected_dc) {
    var jqxhr = $.post("/Warehouse/GetCustomer", { selectwarehouse: warehouse, selectDc: selected_dc })
        .done(function (result) {

            $('#cboCustomer').empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    $('#cboCustomer').append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                $('#cboCustomer').select2({
                    enableFiltering: true,
                    placeholder: "Customer",
                    allowClear: true
                });

            } else {
                toastr["error"](result.message);
            }

        })
        .fail(function (e) {
            console.log(e);
        })
    return jqxhr;
}

function GetCustomer_Raw(controlID,warehouse, selected_dc) {
    var jqxhr = $.post("/Warehouse/GetCustomer", { selectwarehouse: warehouse, selectDc: selected_dc })
        .done(function (result) {

            $(controlID).empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    $(controlID).append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                $(controlID).select2({
                    enableFiltering: true,
                    placeholder: "Customer",
                    allowClear: true
                });

            } else {
                toastr["error"](result.message);
            }

        })
        .fail(function (e) {
            console.log(e);
        })
    return jqxhr;
}

function GetProductGroup(controlID, warehouse, placeholder = 'Productgroup') {
    uiHelpers.resetCombo(controlID, placeholder);
    return uiHelpers.initCombo(controlID, "/Warehouse/GetProductGroup", { selectwarehouse: warehouse }, placeholder);
}


function GetCustomerESC(warehouse, selected_dc) {
    var jqxhr = $.post("/Warehouse/GetCustomerESC", { selectwarehouse: warehouse, selectDc: selected_dc })
        .done(function (result) {

            $('#cboCustomer').empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    $('#cboCustomer').append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                $('#cboCustomer').select2({
                    enableFiltering: true,
                    placeholder: "Customer",
                    allowClear: true
                });

            } else {
                toastr["error"](result.message);
            }

        })
        .fail(function (e) {
            console.log(e);
        })
    return jqxhr;
}

function GetDC(dcType) {
    //console.log(request);
    var jqxhr = $.post("/Warehouse/GetDC", { selectDcType: dcType })
        .done(function (result) {
            //console.log(result);
            $('#cboDC').empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    $('#cboDC').append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                $('#cboDC').select2({
                    enableFiltering: true,
                    placeholder: "Distribution Center",
                    allowClear: true
                });

            } else {
                toastr["error"](result.message);
            }

        })
        .fail(function (e) {
            console.log(e);
        })
    return jqxhr;
}

function GetDC_Raw(controlID,dcType) {
    //console.log(request);
    var jqxhr = $.post("/Warehouse/GetDC", { selectDcType: dcType })
        .done(function (result) {
            //console.log(result);
            $(controlID).empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    $(controlID).append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                $(controlID).select2({
                    enableFiltering: true,
                    placeholder: "Distribution Center",
                    allowClear: true
                });

            } else {
                toastr["error"](result.message);
            }

        })
        .fail(function (e) {
            console.log(e);
        })
    return jqxhr;
}

function GetDCESC(dcType) {
    //console.log(request);
    var jqxhr = $.post("/Warehouse/GetDCESC", { selectDcType: dcType })
        .done(function (result) {
            //console.log(result);
            $('#cboDC').empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    $('#cboDC').append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                $('#cboDC').select2({
                    enableFiltering: true,
                    placeholder: "Distribution Center",
                    allowClear: true
                });

            } else {
                toastr["error"](result.message);
            }

        })
        .fail(function (e) {
            console.log(e);
        })
    return jqxhr;
}

function init_datepicker_criteria() {
    var start = moment();
    var end = moment();

    $('#daterange-99').daterangepicker({
        startDate: start,
        endDate: end,
        locale: {
            format: uiHelpers.dateFormat.DayMonthYear
        },
        ranges: datepicker_ranges,
        opens: (isRtl ? 'left' : 'right')
    });
}

function init_datepicker_week_criteria() {
    var start = moment();
    var end = moment();

    $('#daterange-99').daterangepicker({
        startDate: start,
        endDate: end,
        locale: {
            format: uiHelpers.dateFormat.DayMonthYear
        },
        ranges: datepicker_ranges_week,
        opens: (isRtl ? 'left' : 'right'),
        maxSpan: {
            'days': 6
        }
    });
}


function init_datepicker_twin_criteria() {
    var start = moment();
    var end = moment();

    $('#daterange-01').daterangepicker({
        startDate: start,
        endDate: end,
        locale: {
            format: uiHelpers.dateFormat.DayMonthYear
        },
        ranges: datepicker_ranges,
        opens: (isRtl ? 'left' : 'right')
    });

    $('#daterange-02').daterangepicker({
        startDate: start,
        endDate: end,
        locale: {
            format: uiHelpers.dateFormat.DayMonthYear
        },
        ranges: datepicker_ranges,
        opens: (isRtl ? 'left' : 'right')
    });
}

function generateTableLeadModal_SR(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getSubmitRequest(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy','excel'
                        ],
                        //fixedHeader: true,
                        scrollX: true,
                        scrollY: '40vh',
                        ordering: true,
                        responsive: true,
                        pageLength: 10,
                        filter: true,
                        data: result.data,
                        columns: column,
                        //createdRow: created_row_callback,
                        columnDefs: column_def
                    });
                }
                else {
                    var table = $(controlID + ' .section-table-render').DataTable();
                    table.clear();
                    $.each(result.data, function (idx, obj) {
                        table.row.add(result.data[idx]);
                    });
                    table.draw();
                }
            }
            else {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    //create empty table
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'csv', 'excel', 'pdf', 'print'
                        ],
                        fixedHeader: true,
                        scrollX: true,
                        ordering: false,
                        responsive: true,
                        pageLength: 10,
                        filter: true,
                        columns: column
                    });
                }
                else {
                    //empty 
                    var table = $(controlID + ' .section-table-render').DataTable();
                    table.clear();
                    table.draw();
                }
            }
            $(controlID + ' .section-table-render').DataTable().columns.adjust().draw();
        })
        .fail(uiHelpers.postFailHandler)
        .always(function () {
            $(controlID + ' .section-loading').hide();
        });
    return jqxhr;
}


function generateTableLeadModal(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getRequest(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'csv', 'excel', 'pdf', 'print'
                        ],
                        fixedHeader: true,
                        scrollX: true,
                        scrollY: '40vh',
                        ordering: true,
                        responsive: true,
                        pageLength: 10,
                        filter: true,
                        data: result.data,
                        columns: column,
                        createdRow: created_row_callback,
                        columnDefs: column_def
                    });
                }
                else {
                    var table = $(controlID + ' .section-table-render').DataTable();
                    table.clear();
                    $.each(result.data, function (idx, obj) {
                        table.row.add(result.data[idx]);
                    });
                    table.draw();
                }
            }
            else {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    //create empty table
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'csv', 'excel', 'pdf', 'print'
                        ],
                        fixedHeader: true,
                        scrollX: true,
                        ordering: false,
                        responsive: true,
                        pageLength: 10,
                        filter: true,
                        columns: column
                    });
                }
                else {
                    //empty 
                    var table = $(controlID + ' .section-table-render').DataTable();
                    table.clear();
                    table.draw();
                }
            }
            $(controlID + ' .section-table-render').DataTable().columns.adjust().draw();
        })
        .fail(uiHelpers.postFailHandler)
        .always(function () {
            $(controlID + ' .section-loading').hide();
        });
    return jqxhr;
}