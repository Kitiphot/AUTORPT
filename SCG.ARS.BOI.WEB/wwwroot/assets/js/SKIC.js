function getDateRangeCriteria(ctrl) {
    var startDate = ctrl.data('daterangepicker').startDate._d;
    var endDate = ctrl.data('daterangepicker').endDate._d;

    return {
        dateFrom: startDate.getFullYear() + "-" + (startDate.getMonth() + 1) + "-" + startDate.getDate(),
        dateTo: endDate.getFullYear() + "-" + (endDate.getMonth() + 1) + "-" + endDate.getDate()
    };
}

function getCriteriaParam01() {
    var drPicker = $('#daterange-99')
    var startDate = drPicker.data('daterangepicker').startDate._d;
    var endDate = drPicker.data('daterangepicker').endDate._d;

    return {
        dateFrom: startDate.getFullYear() + "-" + (startDate.getMonth() + 1) + "-" + startDate.getDate(),
        dateTo: endDate.getFullYear() + "-" + (endDate.getMonth() + 1) + "-" + endDate.getDate()
    };
}

function getCriteriaParam02() {
    var drPicker = $('#daterange-99')
    var startDate = drPicker.data('daterangepicker').startDate._d;
    var endDate = drPicker.data('daterangepicker').endDate._d;

    return {
        dateFrom: startDate.getFullYear() + "-" + (startDate.getMonth() + 1) + "-" + startDate.getDate(),
        dateTo: endDate.getFullYear() + "-" + (endDate.getMonth() + 1) + "-" + endDate.getDate(),
        round: $('#ddlRound').val() || 20
    };
}

function getCriteriaParam03() {
    var drPicker = $('#daterange-99')
    var startDate = drPicker.data('daterangepicker').startDate._d;
    var endDate = drPicker.data('daterangepicker').endDate._d;

    return {
        dateFrom: startDate.getFullYear() + "-" + (startDate.getMonth() + 1) + "-" + startDate.getDate(),
        dateTo: endDate.getFullYear() + "-" + (endDate.getMonth() + 1) + "-" + endDate.getDate(),
        custGroup: $('#ddlCustGroup').val() || 'CIP'
    };
}

function getCriteriaParam04() {
    let drPicker = $('#daterange-99');
    let startDate = drPicker.data('daterangepicker').startDate._d;
    let endDate = drPicker.data('daterangepicker').endDate._d;

    return {
        dateFrom: startDate.getFullYear() + "-" + (startDate.getMonth() + 1) + "-" + startDate.getDate(),
        dateTo: endDate.getFullYear() + "-" + (endDate.getMonth() + 1) + "-" + endDate.getDate(),
        shipTo: $('#ddlShipto').val(),
        carrier: $('#ddlCarrier').val()
    };
}

function init_datepicker(ctrl, dateRange) {
    init_datepicker(ctrl, dateRange, {});
}

function init_datepicker(ctrl, dateRange, opts) {
    if (typeof opts !== 'object' || opts === null)
        opts = {};

    var maxSpan = false;
    if (typeof opts.maxSpan === 'object')
        maxSpan = opts.maxSpan;

    if (typeof opts.dateLimit === 'object') //backwards compat
        maxSpan = opts.dateLimit;

    var start = moment();
    var end = moment();

    switch (dateRange.toUpperCase()) {
        case 'TODAY':
            start = moment();
            end = moment();
            break;
        case 'YESTERDAY':
            start = moment().subtract(1, 'days');
            end = moment().subtract(1, 'days');
            break;
        case 'LAST 7 DAYS':
            start = moment().subtract(6, 'days').startOf('day');
            end = moment().startOf('day');
            break;
        case 'LAST 30 DAYS':
            start = moment().subtract(29, 'days').startOf('day');
            end = moment().startOf('day');
            break;
        case 'THIS MONTH':
            start = moment().startOf('month');
            end = moment().endOf('month');
            break;
        case 'LAST MONTH':
            start = moment().subtract(1, 'month').startOf('month');
            end = moment().subtract(1, 'month').endOf('month');
            break;
        default:
            start = moment();
            end = moment();
    }

    function cb(start, end) {
        if (start.isSame(end, 'day')) {
            $(ctrl).html(start.format('MMM D, YYYY'));
        } else {
            $(ctrl).html(start.format('MMM D, YYYY') + ' - ' + end.format('MMM D, YYYY'));
        }
    }

    if (opts.startDate)
        start = moment([opts.startDate.getFullYear(), opts.startDate.getMonth(), opts.startDate.getDate()]);

    if (opts.endDate)
        end = moment([opts.endDate.getFullYear(), opts.endDate.getMonth(), opts.endDate.getDate()]);

    var isRtl = $('html').attr('dir') === 'rtl';
    $(ctrl).daterangepicker({
        startDate: start.startOf('day'),
        endDate: end.startOf('day'),
        ranges: {
            'Today': [moment().startOf('day'), moment().startOf('day')],
            'Yesterday': [moment().subtract(1, 'days').startOf('day'), moment().subtract(1, 'days').startOf('day')],
            'Last 7 Days': [moment().subtract(6, 'days').startOf('day'), moment().startOf('day')],
            'Last 30 Days': [moment().subtract(29, 'days').startOf('day'), moment().startOf('day')],
            'This Month': [moment().startOf('month'), moment().endOf('month')],
            'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
        },
        opens: (isRtl ? 'left' : 'right'),
        maxSpan: maxSpan
    }, cb);

    cb(start, end);
}

function MergeGridCells(table, columns) {
    var dimension_cells = new Array();
    var dimension_col = 0;
    //for (dimension_col = 0; dimension_col <= 2; dimension_col++) {
    for (dimension_col of columns) {
        // first_instance holds the first instance of identical td
        var first_instance = null;
        var rowspan = 1;
        // iterate through rows
        table.find('tr').each(function () {

            // find the td of the correct column (determined by the dimension_col set above)
            var dimension_td = $(this).find('td:nth-child(' + dimension_col + ')');


            if (first_instance === null) {
                // must be the first row
                first_instance = dimension_td;
            } else if (dimension_td.text() === first_instance.text()) {
                // the current td is identical to the previous
                // remove the current td
                // dimension_td.remove();
                dimension_td.attr('hidden', true);
                ++rowspan;
                // increment the rowspan attribute of the first instance
                first_instance.attr('rowspan', rowspan);
            } else {
                // this cell is different from the last
                first_instance = dimension_td;
                rowspan = 1;
            }
        });
    }
}

function createRoundDropDownList(ddlId) {
    var jqxhr = $.post("/Report/GetRoundDropDownList")
        .done(function (result) {
            var ddl = $('#' + ddlId)
            ddl.empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    ddl.append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });
                //ddl.val(20);
            } else {
                toastr["error"](result.message);
            }
        })
        .fail(function (e) {
            console.log(e);
        })
    return jqxhr;
}

function createCarrierDropDownList(ddlId, isMultiple = true) {
    var jqxhr = $.post("/Report/GetCarrierDropDownList")
        .done(function (result) {
            var ddl = $('#' + ddlId)
            ddl.empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    ddl.append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                if (isMultiple) {
                    ddl.select2({
                        enableFiltering: true,
                        placeholder: "Select All",
                        allowClear: true
                    });
                }
            } else {
                toastr["error"](result.message);
            }
        })
        .fail(function (e) {
            console.log(e);
        });

    return jqxhr;
}

function createFleetDropDownList(ddlId) {
    var jqxhr = $.post("/Report/GetFleetDropDownList")
        .done(function (result) {
            var ddl = $('#' + ddlId)
            ddl.empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    ddl.append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                ddl.select2({
                    enableFiltering: true,
                    placeholder: "Select All",
                    allowClear: true
                });
            } else {
                toastr["error"](result.message);
            }
        })
        .fail(function (e) {
            console.log(e);
        });

    return jqxhr;
}

function createTruckTypeDropDownList(ddlId) {
    var jqxhr = $.post("/Report/GetTruckTypeDropDownList")
        .done(function (result) {
            var ddl = $('#' + ddlId)
            ddl.empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    ddl.append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                ddl.select2({
                    enableFiltering: true,
                    placeholder: "Select All",
                    allowClear: true
                });
            } else {
                toastr["error"](result.message);
            }
        })
        .fail(function (e) {
            console.log(e);
        });

    return jqxhr;
}

function createSubTruckTypeDropDownList(ddlId, truckType) {
    var jqxhr = $.post("/Report/GetSubTruckTypeDropDownList", { truckType })
        .done(function (result) {
            var ddl = $('#' + ddlId);
            ddl.empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    ddl.append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                ddl.select2({
                    enableFiltering: true,
                    placeholder: "Select All",
                    allowClear: true
                });
            } else {
                toastr["error"](result.message);
            }
        })
        .fail(function (e) {
            console.log(e);
        });

    return jqxhr;
}

function createCIPShiptoDropDownList(ddlId) {
    var jqxhr = $.post("/Report/GetCIPShiptoDropDownList")
        .done(function (result) {
            var ddl = $('#' + ddlId)
            ddl.empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    ddl.append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                //ddl.select2({
                //    enableFiltering: true,
                //    placeholder: "Select All",
                //    allowClear: true
                //});
            } else {
                toastr["error"](result.message);
            }
        })
        .fail(function (e) {
            console.log(e);
        });

    return jqxhr;
}

function loadCriteria02_bak() {
    var loading = $('#criteria-loading-progress');
    loading.show();

    var dpicker = $('#daterange-99')
    //init_datepicker(dpicker, 'yesterday', { maxSpan: { months: 1, days: -1 } });

    var jqxhr = createRoundDropDownList('ddlRound')
        .done(function () {
            var ddl = $('#ddlRound')
            $.post("/Report/GetPKGLastWorkingRound")
                .done(function (result) {
                    //dpicker.data('daterangepicker').setStartDate(moment(result.last_date));
                    //dpicker.data('daterangepicker').setEndDate(moment(result.last_date));
                    var last_date = new Date(Date.parse(result.last_date));
                    init_datepicker(dpicker, 'This Month', { maxSpan: { months: 1, days: -1 }, startDate: last_date, endDate: last_date });
                    ddl.val(result.last_round);
                })
                .fail(function () {
                    init_datepicker(dpicker, 'Yesterday', { maxSpan: { months: 1, days: -1 } });
                    ddl.val(20);
                })
                .always(function () {
                    loading.hide();
                });
        })
        .fail(function () {
            console.log('fail');
        });

    return jqxhr;
}
// date range, round
function loadCriteria02() {
    var loading = $('#criteria-loading-progress');
    loading.show();

    var dpicker = $('#daterange-99');
    var ddl = $('#ddlRound');

    var promise = createRoundDropDownList('ddlRound')
        .then(() =>
             $.post("/Report/GetPKGLastWorkingRound")
        )
        .then(function (result) {
            let last_date = new Date(Date.parse(result.last_date));
            init_datepicker(dpicker, 'Yesterday', { maxSpan: { months: 1, days: -1 }, startDate: last_date, endDate: last_date });
            ddl.val(result.last_round);
            loading.hide();
        }).catch(function () {
            // when fail, use yesterday 20:00
            init_datepicker(dpicker, 'Yesterday', { maxSpan: { months: 1, days: -1 } });
            ddl.val(20);
            loading.hide();
        });

    return promise;
}
