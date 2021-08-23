function init_datepicker_criteria_one_month() {
    var start = moment().subtract(1, 'months');
    var end = moment();
    //console.log('start:' + start.format('DD/MM/YYYY') + '|end:' + end.format('DD/MM/YYYY'));
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

function getSelectDate() {
    var selectDate = $('#monthpicker').datepicker('getDate');
    if (selectDate == null)
        selectDate = new Date();
    return selectDate;
}

function getCustomer_dom() {
    if ($('#cboCustomer').val() == null || $('#cboCustomer').val() == '') {
        return [];
    }
    else {
        return $('#cboCustomer').val();
    }
}

function getBusiness_dom() {
    if ($('#cboBusiness').val() == null || $('#cboBusiness').val() == '') {
        return [];
    }
    else {
        return $('#cboBusiness').val();
    }
}

function getFleet_dom() {
    if ($('#cboFleet').val() == null || $('#cboFleet').val() == '') {
        return [];
    }
    else {
        return $('#cboFleet').val();
    }
}

function getShippingPoint_dom() {
    if ($('#cboShippingPoint').val() == null || $('#cboShippingPoint').val() == '') {
        return [];
    }
    else {
        return $('#cboShippingPoint').val();
    }
}

function getShiptoRegion_dom() {
    if ($('#cboShiptoRegion').val() == null || $('#cboShiptoRegion').val() == '') {
        return [];
    }
    else {
        return $('#cboShiptoRegion').val();
    }
}

function getMatfrg_dom() {
    if ($('#cboMatfrg').val() == null || $('#cboMatfrg').val() == '') {
        return [];
    }
    else {
        return $('#cboMatfrg').val();
    }
}

function getOrderType_dom() {
    if ($('#cboOrderType').val() == null || $('#cboOrderType').val() == '') {
        return [];
    }
    else {
        return $('#cboOrderType').val();
    }
}

function getTruckType_dom() {
    if ($('#cboTruckType').val() == null || $('#cboTruckType').val() == '') {
        return [];
    }
    else {
        return $('#cboTruckType').val();
    }
}

function getPlannerName_dom() {
    if ($('#cboPlannerName').val() == null || $('#cboPlannerName').val() == '') {
        return [];
    }
    else {
        return $('#cboPlannerName').val();
    }
}

function initCombo(controlID, serviceURLOrData, criteria, placeholder, allowClear = true) {
    // reduce calling
    if ($(controlID).length == 0)
        return;

    resetCombo(controlID, placeholder);
    if (Array.isArray(serviceURLOrData)) {
        var result = { success: true, data: serviceURLOrData };
        if (uiHelpers.addComboOption(controlID, result)) {
            $(controlID).select2("destroy");

            $(controlID).select2({
                enableFiltering: true,
                placeholder: '',
                allowClear: allowClear,
                //tags: true,
                tokenSeparators: [',', ' '],
                minimumResultsForSearch: 30
            });
        }
        return Promise.resolve();
    }
    else {
        return $.post(serviceURLOrData, criteria)
            .done(function (result) {
                //if (uiHelpers.addComboOption(controlID, result)) {
                //    $(controlID).select2("destroy");

                //    $(controlID).select2({
                //        enableFiltering: true,
                //        //placeholder: placeholder,
                //        allowClear: allowClear,
                //        //tags: true,
                //        tokenSeparators: [',', ' '],
                //        minimumResultsForSearch: 30
                //    });
                //}
                $(controlID).select2("destroy");
                let data = result.data.map(item => ({ id: item.dataValue_Key, text: item.dataDisplay }));

                $(controlID).select2({
                    data: data,
                    enableFiltering: true,
                    placeholder: '',
                    allowClear: allowClear,
                    //tags: true,
                    tokenSeparators: [',', ' '],
                    minimumInputLength: 3,
                    minimumResultsForSearch: 20
                });
            })
            .fail(uiHelpers.postFailHandler);
    }
}

function initCustomerTransport (controlID, placeholder = 'Select customer', customer = []) {
    resetCombo(controlID, placeholder);
    return initCombo(controlID, "/Report/GetCustomerTransport", { selectCustomer: customer }, placeholder);
}

function initMatfrg(controlID, mat_freight_code = [], mat_freight_name = [], business = [], fleet = [], shipping_point = [], region = []) {
    var placeholder = '';//"Select a Mat freight";
    resetCombo(controlID, placeholder);
    return initCombo(controlID, "/Report/GetMatfrg", { selectMatfreight: mat_freight_code, selectBusiness: business, selectFleet: fleet, selectShippingpoint: shipping_point, selectRegion: region }, placeholder);
}

function initShippingPoint(controlID, shipping_point_code = [], shipping_point_name = [], business = [], fleet = [], mat_freight = [], region = []) {
    var placeholder = '';//"Select a Shipping point";
    resetCombo(controlID, placeholder);
    return initCombo(controlID, "/Report/GetShippingPoint", { selectShippingpoint: shipping_point_code, selectBusiness: business, selectFleet: fleet, selectMatfreight: mat_freight, selectRegion: region }, placeholder);
}

function resetCombo(controlID, placeholder, allowClear = true) {
    $(controlID).empty();

    $(controlID).select2({
        enableFiltering: true,
        placeholder: placeholder,
        allowClear: allowClear,
        //tags: true,
        tokenSeparators: [',', ' ']
    });
}

function getParamMaster(schemaName, paramName) {
    if (schemaName == 'dom') {
        if (paramName.includes('cust')) {
            return 'customer';
        } else if (paramName.includes('mat') &&
            (
            paramName.includes('frt') || paramName.includes('freight') ||
            paramName.includes('grp') || paramName.includes('group')
            )
        ) {
            return 'matfreight';
        } else if (paramName.includes('ship') && paramName.includes('point')) {
            return 'shippingpoint';
        } else {
            return '';
        }
    } else if (schemaName == 'wh') {
        if (paramName.includes('cust')) {
            return 'customer_wh';
        } else if (paramName.includes('dc')) {
            return 'dc_wh'
        }
    }
        else {
        return '';
    }
}

function LoadColumnMappingViewMode(request = null) {
    $('#dvColumnsOverlay').show();

     $.post("/AutoReport/LoadTemplateColumnMapping", request)
        .done(function (result) {
            //console.log(result);
            if (result.status) {
                columnsModel.columns(result.data);
                sourceColumnsModel.columns([]);
                    if (dtEditColumns) {
                        //dtNewEditColumns.button();
                        //dtNewEditColumns.empty();
                    }
                    $('#dtColumns, #dtColumns_wrapper').show();
                    $('#dtNewEditColumns, #dtNewEditColumns_wrapper').hide();
                    if ($.fn.dataTable.isDataTable('#dtColumns')) {
                        let table = $('#dtColumns').DataTable();
                        table.destroy();
                    }
                    dtColumns = $('#dtColumns').DataTable({
                        searching: false,
                        paging: false,
                        ordering: false,
                        info: false,
                        data: result.data,
                        scrollX: '40vw',
                        scrollY: '60vh',
                        columnDefs: [
                            {
                                autoWidth: false,
                                width: 30,
                                orderable: false,
                                className: 'dt-head-center',
                                targets: '_all'
                            }
                        ],
                        columns: [
                            { data: null, visible: false },
                            { data: null, visible: false },
                            {
                                "data": "column_name", "name": "column_name", "title": "Column Name",
                                render: function (data, type, row, meta) {
                                    if (data) {
                                        return data;
                                    } else {
                                        return '<span class="text-muted">(empty)</span>';
                                    }
                                }
                            },
                            {
                                "data": "column_display", "name": "column_display", "title": "Rename",
                                //render: function (data, type, row, meta) {
                                //    return data ?? row.column_name;
                                //}
                            },
                            {
                                "data": "column_data_type", "name": "column_data_type", "title": "Type",
                                render: displayDataTypeFamiliarName
                            },
                            {
                                "data": "default_value", "name": "default_value", "title": "Default Value",
                            },
                            {
                                data: "footer", name: "footer", title: "Add Grand Total",
                                render: function (data, type, row, meta) {
                                    switch (data) {
                                        case "func.sum":
                                            return '<span class="mdi mdi-function-variant"> Sum</span>';
                                        case "func.count":
                                            return '<span class="mdi mdi-function-variant"> Count</span>';
                                        case "func.countdistinct":
                                            return '<span class="mdi mdi-function-variant"> Count (Distinct)</span>';
                                        default:
                                            return data;
                                    }
                                }
                            }
                        ],
                        destroy: true
                    });
                }

            //$("#addfooter").change(function () {
            //    if (this.checked) {
            //        var column = dtEditColumns.column($(this).attr('data-column'));

            //        column.visible(!column.visible());
            //    }
            //});
        })
        .fail(function (e) {
            console.log(e);
        })
        .always(function () {
            //console.log( "finished" );
            $('#dvColumnsOverlay').hide();
        });

} 

function LoadColumnMappingEditMode(request = null) {
    $('#dvColumnsOverlay').show();

    let allColumn = [];
    let param = {
        report: newTemplateModel.templates(),
        selectedColumns: [] // load all column (exclude none)
    };

    $.post("/AutoReport/LoadColumnSelection", param)
        .then(function (result) {
            //console.log(result);
            if (result.status) {
                allColumn = $.map(result.data, function (val, i) {
                    if (val.column_name == null)
                        return null; // remove this item

                    return { id: val.column_name, text: val.column_name, data_type: val.column_data_type };
                });
            }
            return $.post("/AutoReport/LoadTemplateColumnMapping", request)
        })
        .done(function (result) {
            //console.log(result);
            if (result.status) {
                columnsModel.columns(result.data);
                sourceColumnsModel.columns([]);
                if (dtColumns) {
                    //dtColumns.empty();
                }
                $('#dtColumns, #dtColumns_wrapper').hide();
                $('#dtNewEditColumns, #dtNewEditColumns_wrapper').show();
                dtEditColumns = $('#dtNewEditColumns').DataTable({
                    //searchHighlight: true, // require plug-in
                    dom: 'Bfrtip',
                    buttons: [
                        {
                            id: 'btnSaveColumns',
                            text: 'Save',
                            className: 'btn btn-primary',
                            action: function (e, dt, node, config) {
                                SaveAddNewColumns();
                            }
                        },
                        {
                            id: 'btnAddColumns',
                            text: 'Add Columns',
                            className: 'btn btn-primary',
                            action: function (e, dt, node, config) {
                                var report = newTemplateModel.templates();
                                var list = [];
                                //console.log(report);
                                //console.log(e);
                                //console.log(dt.rows().data()[0]);
                                $.each(dt.rows().data(), function (index, item) {
                                    if (item.column_name != null && item.column_name != '')
                                        list.push(item);
                                });
                                //console.log(list);
                                //console.log(node);
                                //console.log(config);
                                var request = {
                                    report: report,
                                    selectedColumns: list
                                }

                                LoadColumnSelection(request);

                                $("#modal-columns").modal({
                                    backdrop: 'static',
                                    keyboard: false
                                })
                            }
                        },
                        {
                            id: 'btnRemoveColumns',
                            text: 'Delete',
                            className: 'btn btn-primary',
                            action: function (e, dt, node, config) {
                                var data = [];
                                //var data = dtEditColumns.row($(this).parents('tr')).data();

                                dtEditColumns.$('input[type="checkbox"]').each(function () {
                                    // If checkbox doesn't exist in DOM
                                    //if (!$.contains(document, this)) {
                                    // If checkbox is checked
                                    if (this.checked) {
                                        data.push(dtEditColumns.row($(this).parents('tr')).data());
                                    }
                                    //}
                                });

                                if (data.length > 0) {
                                    //$("#modal-confirm-delete-column").modal();
                                    //$('#confirm-delete-column').html(data.map(item => item.column_name).join(', '));
                                    var result = confirm(`Want to delete column: ${data.map(item => item.column_name).join(', ')}?`);
                                    if (result) {
                                        RemoveTemplateColumnMapping(data);
                                    }
                                }
                            }
                        },
                    ],
                    scrollX: '40vw',
                    scrollY: '60vh',
                    searching: false,
                    paging: false,
                    ordering: false,
                    order: [],
                    info: false,
                    "rowReorder": {
                        //selector: 'tr',
                        //selector: 'td:first-child',
                        selector: 'td:nth-child(2)',
                        dataSrc: 'column_sorting',
                        update: false,
                        //editor: editor
                    },
                    //select: {
                    //    style: 'multi',
                    //    selector: 'td:last-child'
                    //},
                    data: result.data,
                    columnDefs: [
                        {
                            autoWidth: false,
                            orderable: false,
                            className: 'dt-head-center',
                            targets: '_all'
                        },
                    ],
                    columns: [
                        {
                            // check box delete
                            data: null, name: "", width: 20,
                            title: '<i class="icon-trash md-18"></i><input type="checkbox" name="select_all" value="1" id="dt-select-all" style="text-align:center">',
                            className: 'dt-head-center',
                            render: function (data, type, row, meta) {
                                return '<input type="checkbox" name="id[]" value="' + $('<div/>').text(data).html() + '">';
                            }
                        },
                        //{
                        //    "data": null, "name": "", "width": 20,
                        //    "render": function (data, type, row, meta) {
                        //        return '<a href="javascript:void(0);"><i class="icon-trash md-18" data-toggle="tooltip" data-placement="top" title="Remove"></i></a>';
                        //    }
                        //}
                        { "data": "column_sorting", "name": "column_sorting", "title": "", className: 'reorder' },
                        {
                            "data": "column_name", "name": "column_name", "title": "Column Name",
                            render: function (data, type, row, meta) {
                                if (allColumn == null || allColumn.length == 0) {
                                    return `<input type="text" class="form-control col-12" id="col_name_${meta.row}" placeholder="${row.column_name}" value="${(data ?? '')}" />`;
                                } else {
                                    let selectOpen = `<select class="form-control dt-select2" id="col_name_${meta.row}">`
                                    let selectClose = '</select>'
                                    let optionTag = `${allColumn.map(c => `<option data-datatype="${c.data_type}" value="${c.id}" ${data == c.text ? "selected" : ""}>${c.text}</option>`).join("")}`

                                    return selectOpen + '<option data-datatype="" value=""></option>' + optionTag + selectClose;
                                }
                            }
                        },
                        {
                            data: "column_display", name: "column_display", title: "Rename",
                            render: function (data, type, row, meta) {
                                return `<input type="text" class="form-control col-12" style="width:120px" id="label_${meta.row}" value="${(data ?? '')}" />`;
                            }
                        },
                        {
                            "data": "column_data_type", "name": "column_data_type", "title": "Type",
                            render: displayDataTypeFamiliarName
                        },
                        {
                            "data": "default_value", "name": "default_value", "title": "Default Value",
                            //visible: false,
                            render: function (data, type, row, meta) {
                                return `<input type="text" class="form-control col-12" style="width:120px" id="default_value_${meta.row}" ${row.column_name ? 'readonly' : ''} value="${(data ?? '')}" />`;
                            }
                        },
                        {
                            data: 'footer', "name": "function", "title": "Add Grand Total", visible: true,
                            render: function (data, type, row, meta) {
                                let html =
                                    `<select id="footer_row_${meta.row}" class="form-control dt-select2">` +
                                    `<option value="" ${data == null || data.trim() == "" ? 'selected="selected"' : ""}>---</option>` +
                                    '<optgroup label="Function">' +
                                    `<option value="func.sum" ${data == "func.sum" ? 'selected="selected"' : ""}>Sum</option>` +
                                    `<option value="func.count" ${data == "func.count" ? 'selected="selected"' : ""}>Count</option>` +
                                    `<option value="func.countdistinct" ${data == "func.countdistinct" ? 'selected="selected"' : ""}>Count (Distinct)</option>` +
                                    '</optgroup>' +
                                    '<optgroup label = "Text"> ' +
                                    ((data != null && !data.startsWith("func.")) ? `<option value="${data}" selected="selected">${data}</option>` : '') +
                                    '</optgroup>' +
                                    '</select > ';
                                return html;
                            }
                        },
                    ],
                    destroy: true,
                    drawCallback: function (settings) {
                        //initComplete: function () {
                        $('select[id^="footer_row_"].dt-select2').select2({
                            tags: true,
                            //allowClear: true,
                            //placeholder: ''
                        });

                        $('select[id ^="col_name_"].dt-select2').select2({
                            allowClear: true,
                            placeholder: ''
                        }).on('select2:select', function (e) {
                            let rowIndex = e.target.id.substr('col_name_'.length);
                            let datatype = e.params.data.element.dataset.datatype;
                            dtEditColumns.cell(rowIndex, 4).data(datatype);
                            $('#default_value_' + rowIndex).prop('readonly', true);
                        }).on('select2:unselect', function (e) {
                            let rowIndex = e.target.id.substr('col_name_'.length);
                            dtEditColumns.cell(rowIndex, 4).data(null);
                            $('#default_value_' + rowIndex).prop('readonly', false);
                        });;
                    }
                });

                $('#dt-select-all').on('click', function () {
                    // Get all rows with search applied
                    var rows = dtEditColumns.rows({ 'search': 'applied' }).nodes();
                    // Check/uncheck checkboxes for all rows in the table
                    $('input[type="checkbox"]', rows).prop('checked', this.checked);
                });

                dtEditColumns.on('row-reorder', function (e, diff, edit) {
                    //console.log(diff);
                    //console.log(edit);

                    for (var i = 0; i < diff.length; i++) {
                        var ele = diff[i];
                        var row = dtEditColumns.row(ele.node).data();
                        var pos = ele.newPosition + 1;
                        row.column_sorting = pos;
                        //$(ele.node).children(':first-child').html(pos);
                        $(ele.node).children(':nth-child(2)').html(pos);
                    }
                });

                $('#dtNewEditColumns tbody').on('click', 'tr', function (e) {
                    //var data = dtNewEditColumns.row(this).data();

                    //dtEditColumns.rows('.selected').nodes().to$().removeClass('selected');
                    //$(this).toggleClass('selected');
                });

                //$('#dtNewEditColumns tbody tr').on('click', 'i.icon-trash', function (e) {
                //    var data = dtEditColumns.row($(this).parents('tr')).data();
                //    //console.log(data);
                //    RemoveTemplateColumnMapping(data);
                //});

                $('#dtNewEditColumns tbody').on('change', 'input[type="checkbox"]', function (e) {
                    // If checkbox is not checked
                    if (!this.checked) {
                        var el = $('#dt-select-all').get(0);
                        // If "Select all" control is checked and has 'indeterminate' property
                        if (el && el.checked && ('indeterminate' in el)) {
                            // Set visual state of "Select all" control
                            // as 'indeterminate'
                            el.indeterminate = true;
                        }
                    }
                });
            }

            //$("#addfooter").change(function () {
            //    if (this.checked) {
            //        var column = dtEditColumns.column($(this).attr('data-column'));

            //        column.visible(!column.visible());
            //    }
            //});
        })
        .fail(function (e) {
            console.log(e);
        })
        .always(function () {
            //console.log( "finished" );
            $('#dvColumnsOverlay').hide();
        });

}

function LoadParameterMappingViewMode(request = null) {
    $('#dvParamsOverlay').show();
    var jqxhr = $.post("/AutoReport/LoadTemplateParameterMapping", request)
        .done(function (result) {
            //console.log(result);
            //console.log(mode);
            if (result.status) {
                paramsModel.parameters(result.data);
                sourceParamsModel.parameters([]);

                if (dtNewEditParams) {
                    //dtNewEditParams.empty();
                }
                $('#dtParams, #dtParams_wrapper').show();
                $('#dtNewEditParams, #dtNewEditParams_wrapper').hide();
                dtParams = $('#dtParams').DataTable({
                    searching: false,
                    paging: false,
                    ordering: false,
                    info: false,
                    data: result.data,
                    columnDefs: [
                        {
                            orderable: false,
                            autoWidth: false,
                            targets: '_all',
                        }
                    ],
                    columns: [
                        { "data": "parameter_name", "name": "parameter_name", "title": "ชื่อตัวแปร", "width": 30 },
                        {
                            "data": "data_type_name", "name": "data_type_name", "title": "ชนิดตัวแปร", "width": 30,
                            render: displayDataTypeFamiliarName
                        },
                        { "data": "parameter_default_value", "name": "parameter_default_value", "title": "ค่าตัวแปร", "autoWidth": false, "width": 30, "orderable": false },
                    ],
                    destroy: true
                });

                $('input[id ^="pRow_dt_"]').datepicker({
                    format: 'yyyy-mm-dd',
                    forceParse: false,
                    todayHighlight: true
                });
            }
        })
        .fail(function (e) {
            console.log(e);
        })
        .always(function () {
            //console.log( "finished" );
            $('#dvParamsOverlay').hide();
        });
}

function LoadParameterMappingEditMode(request = null) {
    $('#dvParamsOverlay').show();
    var jqxhr = $.post("/AutoReport/LoadTemplateParameterMapping", request)
        .then(function (result) {
            //console.log(result);
            //console.log(mode);
            if (result.status) {
                paramsModel.parameters(result.data);
                sourceParamsModel.parameters([]);
                if (dtParams) {
                    //dtParams.empty();
                }
                $('#dtParams, #dtParams_wrapper').hide();
                $('#dtNewEditParams, #dtNewEditParams_wrapper').show();
                dtNewEditParams = $('#dtNewEditParams').DataTable({
                    dom: 'Bfrtip',
                    buttons: [
                        {
                            id: 'btnSaveParams',
                            text: 'Save',
                            className: 'btn btn-primary',
                            action: function (e, dt, node, config) {
                                SaveParameters();
                            }
                        }],
                    searching: false,
                    paging: false,
                    ordering: false,
                    info: false,
                    data: result.data,
                    columnDefs: [
                        {
                            orderable: false,
                            targets: '_all',
                        }
                    ],
                    columns: [
                        { "data": "parameter_name", "name": "parameter_name", "title": "ชื่อ", "autoWidth": true, "width": 30 },
                        {
                            "data": "data_type_name", "name": "data_type_name", "title": "ชนิดข้อมูล", "autoWidth": true, "width": 30,
                            render: displayDataTypeFamiliarName
                        },
                        //{ "data": "parameter_type_name", "name": "parameter_type_name", "title": "ชนิดตัวแปร", "autoWidth": "auto", "orderable": false },
                        //{ "data": "parameter_default_value", "name": "parameter_default_value", "title": "ค่า", "autoWidth": false, "width": 30, "orderable": false },
                        {
                            "data": null, "name": "parameter_default_value", "title": "ค่าตัวแปร", "autoWidth": false, "width": 30,
                            "render": function (data, type, row, meta) {
                                let helpText, helpIcon;
                                if (row.data_type_name == "Timestamp" || row.data_type_name == "Date") {
                                    //return `<input type="text" class="form-control col-12" style="width:75% !important" id="pRow_dt_${meta.row}" value="${(data.parameter_default_value ?? '')}" />` + '&nbsp;&nbsp; <i class="icon-question md-18" data-toggle="tooltip" data-placement="top" title="' + "This field allow word: 'now', 'today', 'yesterday', 'dayminus3', 'dayminus7', 'firstdayofweek', 'lastdayofweek', 'firstdayofmonth', 'lastdayofmonth', 'firstdayoflastmonth', 'lastdayoflastmonth' and date format 'yyyy-mm-dd'" + '"></i>';

                                    helpText = "This field allow word: 'now', 'today', 'yesterday', 'dayminus3', 'dayminus7', 'dayminus15', 'firstdayofweek', 'lastdayofweek', 'firstdayofmonth', 'lastdayofmonth', 'firstdayoflastmonth', 'lastdayoflastmonth' and date format 'yyyy-mm-dd'";
                                    return `<input type="text" class="form-control col-12" style="width:75% !important" id="pRow_dt_${meta.row}" value="${(data.parameter_default_value ?? '')}" />` + '&nbsp;&nbsp; <a tabindex="0" role="button" data-toggle="popover"  data-placement="top" data-content="' + helpText + '"><i class="icon-question md-18"></i></a>';
/*
                                    return `
<div class="form-row">
    <div class="form-check col-md3 col-sm3">
        <input class="form-check-input" type="radio" name="datetype_${meta.row}" id="exampleRadios1" value="option1" checked />
        <label class="form-check-label" for="exampleRadios1">Date type 1</label >
    </div>
    <div class="form-group col-md4 col-sm5">
        <label class="form-check-label" for="day1">Date</label>
        <select id="day1">
            <option>1</option>
            <option>2</option>
            <option>...</option>
            <option>End of month</option>
        </select>
    </div>
    <div class="form-check">
        <input class="form-check-input" type="radio" name="month_${meta.row}" id="current-month" value="option1" checked />
        <label class="form-check-label" for="current-month">Current month</label >
    </div>
    <div class="form-check">
        <input class="form-check-input" type="radio" name="month_${meta.row}" id="last-month" value="option2" />
        <label class="form-check-label" for="last-month">Last month</label >
    </div>
</div>                                    
<div class="form-row">
    <div class="form-check col-md3 col-sm3"">
        <input class="form-check-input" type="radio" name="datetype_${meta.row}" id="exampleRadios2" value="option2" />
        <label class="form-check-label" for="exampleRadios1">Date type 2</label >
    </div>
    <div class="form-group col-md9 col-sm9"">
        <label class="form-check-label" for="day2"></label>
        <input type="text" id="day2" />
    </div>
</div>`;
//*/
                                }
                                else if (row.data_type_name == "Array" && row.parameter_udt_name == "_int4") {
                                    //return `<input type="text" class="form-control col-12" id="pRow_arr_int_${meta.row}" value="${(data.parameter_default_value ?? '')}" />` + '&nbsp;&nbsp; <i class="icon-question md-18" data-toggle="tooltip" data-placement="top" title="' + "This field allow multiple input with only number." + '"></i>';

                                    helpText = "This field allow multiple input with only number.";
                                    return `<input type="text" class="form-control col-12" id="pRow_arr_int_${meta.row}" value="${(data.parameter_default_value ?? '')}" />` + '&nbsp;&nbsp; <a tabindex="0" role="button" data-toggle="popover" data-placement="top" data-content="' + helpText + '"><i class="icon-question md-18"></i></a>';
                                }
                                else if (row.data_type_name == "Array") {
                                    let masterName = getParamMaster(row.schema_name, row.parameter_name);
                                    if (masterName == 'customer') {
                                        //return `<input type="text" class="form-control col-12 master-customer" id="pRow_arr_txt_${meta.row}" value="${(data.parameter_default_value ?? '')}" />` + '&nbsp;&nbsp; <i class="icon-question md-18" data-toggle="tooltip" data-placement="top" title="' + "This field allow multiple input text and number." + '"></i>';
                                        return `<select id="p_arr_txt_${meta.row}" class="select2-master select2-customer" multiple style="width:75%"> </select>`;
                                    } else if (masterName == 'matfreight') {
                                        return `<select id="p_arr_txt_${meta.row}" class="select2-master select2-matfrg" multiple style="width:75%"> </select>`;
                                    } else if (masterName == 'shippingpoint') {
                                        return `<select id="p_arr_txt_${meta.row}" class="select2-master select2-shipping-point" multiple style="width:75%"> </select>`;
                                    } else if (masterName == 'customer_wh') {
                                        return `<select id="p_arr_txt_${meta.row}" class="select2-master select2-customer-wh" multiple style="width:75%"> </select>`;
                                    } else if (masterName == 'dc_wh') {
                                        return `<select id="p_arr_txt_${meta.row}" class="select2-master select2-dc-wh" multiple style="width:75%"> </select>`;
                                    } else {
                                        //return `<input type="text" class="form-control col-12" id="pRow_arr_txt_${meta.row}" value="${(data.parameter_default_value ?? '')}" />` + '&nbsp;&nbsp; <i class="icon-question md-18" data-toggle="tooltip" data-placement="top" title="' + "This field allow multiple input text and number." + '"></i>';

                                        helpText = "This field allow multiple input text and number.";
                                        return `<input type="text" class="form-control col-12" id="pRow_arr_txt_${meta.row}" value="${(data.parameter_default_value ?? '')}" />` + '&nbsp;&nbsp; <a tabindex="0" role="button" data-toggle="popover" data-placement="top" data-content="' + helpText + '"><i class="icon-question md-18"></i></a>';
                                    }
                                } else {
                                    let masterName = getParamMaster(row.schema_name, row.parameter_name);
                                    if (masterName == 'customer') {
                                        return `<select id="p_txt_${meta.row}" class="select2-master select2-customer col-12" style="width:75%"> </select>`;
                                    } else if (masterName == 'matfreight') {
                                        return `<select id="p_txt_${meta.row}" class="select2-master select2-matfrg" style="width:75%"> </select>`;
                                    } else if (masterName == 'shippingpoint') {
                                        return `<select id="p_txt_${meta.row}" class="select2-master select2-shipping-point" style="width:75%"> </select>`;
                                    } else if (masterName == 'customer_wh') {
                                        return `<select id="p_txt_${meta.row}" class="select2-master select2-customer-wh" style="width:75%"> </select>`;
                                    } else if (masterName == 'dc_wh') {
                                        return `<select id="p_txt_${meta.row}" class="select2-master select2-dc-wh" style="width:75%"> </select>`;
                                    } else {
                                        //return `<input type="text" class="form-control col-12" id="pRow_${meta.row}" value="${(data.parameter_default_value ?? '')}" />`; + '&nbsp;&nbsp; <i class="icon-question md-18" data-toggle="tooltip" data-placement="top" title="' + "This field single input text and number." + '"></i>';

                                        helpText = "This field allow multiple input text and number.";
                                        return `<input type="text" class="form-control col-12" id="pRow_${meta.row}" value="${(data.parameter_default_value ?? '')}" />`; + '&nbsp;&nbsp; <a tabindex="0" role="button" data-toggle="popover" data-placement="top" data-content="' + helpText + '"><i class="icon-question md-18"></i></a>';
                                    }
                                }
                            }
                        }
                        //,
                        //{
                        //    "data": null, "name": "", "autoWidth": false, "width": 20,
                        //    "render": function (data, type, row, meta) {
                        //        if (row.data_type_name == "Timestamp" || row.data_type_name == "Date") {
                        //            //return '<i class="icon-question md-18" data-toggle="tooltip" data-placement="top" title="' + "This field allow word: 'now', 'today', 'yesterday', 'dayminus7', 'firstdayofweek', 'lastdayofweek', 'firstdayofmonth', 'lastdayofmonth', 'firstdayoflastmonth', 'lastdayoflastmonth' and date format 'yyyy-mm-dd'" + '"></i>';
                        //            return null;
                        //        }
                        //        else if (row.data_type_name == "Array" && row.parameter_udt_name == "_int4") {
                        //            return '<i class="icon-question md-18" data-toggle="tooltip" data-placement="top" title="' + "This field allow multiple input with only number." + '"></i>';
                        //        }
                        //        else if (row.data_type_name == "Array") {
                        //            return '<i class="icon-question md-18" data-toggle="tooltip" data-placement="top" title="' + "This field allow multiple input text and number." + '"></i>';
                        //        }
                        //        else {
                        //            return null;
                        //        }
                        //    }
                        //}

                    ],
                    destroy: true
                });

                // Update original input/select on change in child row
                $('#dtNewEditParams tbody').on('keyup change', 'input', function (e) {
                    var $el = $(this);
                    //console.log($el.val());
                    var data = dtNewEditParams.row($(this).parents('tr')).data();

                    if (data.parameter_udt_name == "_int4") {
                        event.preventDefault();
                        return;
                    }
                    data.parameter_default_value = $el.val();
                    //console.log(data);
                    //var rowIdx = $el.closest('ul').data('dtr-index');
                    //var colIdx = $el.closest('li').data('dtr-index');
                    //var cell = table.cell({ row: rowIdx, column: colIdx }).node();
                    //$('input, select, textarea', cell).val($el.val());
                    //if ($el.is(':checked')) {
                    //    $('input', cell).prop('checked', true);
                    //} else {
                    //    $('input', cell).removeProp('checked');
                    //}
                });

                $('#dtNewEditParams tbody').on('keypress', 'input', function (e) {
                    var keyCode = e.which ? e.which : e.keyCode

                    var data = dtNewEditParams.row($(this).parents('tr')).data();

                    if (data.parameter_udt_name == "_int4") {
                        // '0' to '9'
                        if (!(keyCode >= 48 && keyCode <= 57)) {
                            $(".error").css("display", "inline");
                            return false;
                        }
                    }
                });

                $('input[id ^="pRow_dt_"]').datepicker({
                    format: 'yyyy-mm-dd',
                    forceParse: false,
                    todayHighlight: true
                });

                //$('input[id ^="pRow_arr_int_"]').tagsinput({
                //    allowDuplicates: false,
                //    itemText: function (item) {
                //        console.log(item);
                //        return item.label;
                //    },
                //    pattern: /^\d+$/
                //});
                $('input[id ^="pRow_arr_"]').tagsinput({
                    confirmKeys: [13, 44]
                });
                $('input[id ^="pRow_arr_"]').tagsinput('items');

                $('input[id ^="pRow_arr_"]').on('itemAdded', function (event) {
                    //console.log(event.item);
                    //console.log(`val="${$(this).val()}"`);
                    //console.log($(this).tagsinput('items'));
                    //console.log(typeof ($(this).tagsinput('items')));
                    //console.log('test copy1:' + $('input[id ^="pRow_arr_"]').tagsinput('items'));
                    // when copy-pasting val() is not update
                    $(this).val($(this).tagsinput('items'));
                    console.log($(this).val());
                });

                //$('[data-toggle="tooltip"]').tooltip();
                $('[data-toggle="popover"]').popover();

                return initial_parameter(result);
            }
        })
        .done(function (result) {
            //set_parameter(result)
        })
        .fail(function (e) {
            console.log(e);
        })
        .always(function () {
            //console.log( "finished" );
            $('#dvParamsOverlay').hide();
        });
}

function initial_parameter(request) {
    //$('#dvParamsOverlay').show();
    //Matgroup ,customer ,shippingpoint
    if (request.data[0].schema_name == 'dom') {
        var ajax = [];
        ajax.push(uiHelpers.initCustomerTransportAjax('.select2-customer', ''), '');
        ajax.push(initMatfrg('.select2-matfrg'));
        ajax.push(initShippingPoint('.select2-shipping-point'));
        var result = Promise.all(ajax)
            .finally(() => {
            set_parameter(request);
            //$('#dvParamsOverlay').hide();
        });
        return result;
    }
    else if (request.data[0].schema_name == 'wh') {
        var ajax = [];
        ajax.push(initCustomer('.select2-customer-wh','CDC'));
        ajax.push(initDC('.select2-dc-wh','CDC'));
        var result = Promise.all(ajax)
            .finally(() => {
                set_parameter(request);
            });
        return result;
    }
}

function set_parameter(request) {
    for (var i = 0; i < request.data.length; i++) {
        $('.select2-master#p_arr_txt_' + i).not('.select2-customer')
            .val(request.data[i].parameter_default_value?.split(',')?.map(item => item.trim())).trigger('change');

        $('.select2-master#p_txt_' + i).not('.select2-customer')
            .val(request.data[i].parameter_default_value).trigger('change');

        var custCode = request.data[i].parameter_default_value?.split(',')?.map(item => item.trim());
        uiHelpers.setSelectedCriteria('.select2-customer#p_arr_txt_' + i, '/Report/GetCustomerTransport', custCode);
        uiHelpers.setSelectedCriteria('.select2-customer#p_txt_' + i, '/Report/GetCustomerTransport', custCode);
    }
}

function initCustomer(controlID, warehouse, placeholder = 'Select customer') {
    resetCombo(controlID, placeholder);
    return uiHelpers.initCombo(controlID, "/Report/GetCustomer", { selectwarehouse: warehouse }, placeholder);
}

function initDC(controlID, dcType, placeholder = 'Select Dc') {
    this.resetCombo(controlID, placeholder);
    return uiHelpers.initCombo(controlID, "/Warehouse/GetDC", { selectDcType: dcType }, placeholder);
}