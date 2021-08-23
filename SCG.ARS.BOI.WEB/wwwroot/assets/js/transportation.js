function initialControl() {
    //set full date to report header
    if ($('#reportHeader') != null)
        $('#reportHeader').text(uiHelpers.displayFullDate(new Date()));

    //initial search criteria section
    return initialSearchCriteria();
}

function initialSearchCriteria() {
    var ajax = [];
    $('#CriteriaOveray').show();
    //ajax.push(uiHelpers.initCustomer('#cboCustomer', $('#cboWarehouse').val()));
    ajax.push(uiHelpers.initCustomerTransport('#cboCustomer'));
    ajax.push(uiHelpers.initBusiness('#cboBusiness'));
    ajax.push(uiHelpers.initFleet('#cboFleet'));
    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint'));
    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion'));
    ajax.push(uiHelpers.initMatfrg('#cboMatfrg'));
    ajax.push(uiHelpers.initOrderType('#cboOrderType'));
    ajax.push(uiHelpers.initTruckType('#cboTruckType'));
    ajax.push(uiHelpers.initPlannerName('#cboPlannerName'));
    uiHelpers.initMonthYearpicker('#monthpicker');
    var result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    return result;
}


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

function getSelectDate_Raw() {
    var selectDate = $('#monthpicker_Raw').datepicker('getDate');
    if (selectDate == null)
        selectDate = new Date();
    return selectDate;
}

function getCustomer() {
    if ($('#cboCustomer').val() == null || $('#cboCustomer').val() == '') {
        return [];
    }
    else {
        return [$('#cboCustomer').val()];
    }
}


function getCustomer_m() {
    if ($('#cboCustomer').val() == null || $('#cboCustomer').val() == '') {
        return [];
    }
    else {
        return $('#cboCustomer').val();
    }
}

function getBusiness() {
    if ($('#cboBusiness').val() == null || $('#cboBusiness').val() == '') {
        return [];
    }
    else {
        return [$('#cboBusiness').val()];
    }
}

function getBusiness_m() {
    if ($('#cboBusiness').val() == null || $('#cboBusiness').val() == '') {
        return [];
    }
    else {
        return $('#cboBusiness').val();
    }
}



function getFleet() {
    if ($('#cboFleet').val() == null || $('#cboFleet').val() == '') {
        return [];
    }
    else {
        return [$('#cboFleet').val()];
    }
}

function getFleet_m() {
    if ($('#cboFleet').val() == null || $('#cboFleet').val() == '') {
        return [];
    }
    else {
        return $('#cboFleet').val();
    }
}

function getShippingPoint() {
    if ($('#cboShippingPoint').val() == null || $('#cboShippingPoint').val() == '') {
        return [];
    }
    else {
        return [$('#cboShippingPoint').val()];
    }
}

function getShippingPoint_m() {
    if ($('#cboShippingPoint').val() == null || $('#cboShippingPoint').val() == '') {
        return [];
    }
    else {
        return $('#cboShippingPoint').val();
    }
}

function getShiptoRegion() {
    if ($('#cboShiptoRegion').val() == null || $('#cboShiptoRegion').val() == '') {
        return [];
    }
    else {
        return [$('#cboShiptoRegion').val()];
    }
}
function getShiptoRegion_m() {
    if ($('#cboShiptoRegion').val() == null || $('#cboShiptoRegion').val() == '') {
        return [];
    }
    else {
        return $('#cboShiptoRegion').val();
    }
}

function getMatfrg() {
    if ($('#cboMatfrg').val() == null || $('#cboMatfrg').val() == '') {
        return [];
    }
    else {
        return [$('#cboMatfrg').val()];
    }
}
function getMatfrg_m() {
    if ($('#cboMatfrg').val() == null || $('#cboMatfrg').val() == '') {
        return [];
    }
    else {
        return $('#cboMatfrg').val();
    }
}

function getOrderType() {
    if ($('#cboOrderType').val() == null || $('#cboOrderType').val() == '') {
        return [];
    }
    else {
        return [$('#cboOrderType').val()];
    }
}

function getOrderType_m() {
    if ($('#cboOrderType').val() == null || $('#cboOrderType').val() == '') {
        return [];
    }
    else {
        return $('#cboOrderType').val();
    }
}

function getTruckType() {
    if ($('#cboTruckType').val() == null || $('#cboTruckType').val() == '') {
        return [];
    }
    else {
        return [$('#cboTruckType').val()];
    }
}

function getTruckType_m() {
    if ($('#cboTruckType').val() == null || $('#cboTruckType').val() == '') {
        return [];
    }
    else {
        return $('#cboTruckType').val();
    }
}

function getPlannerName() {
    if ($('#cboPlannerName').val() == null || $('#cboPlannerName').val() == '') {
        return [];
    }
    else {
        return [$('#cboPlannerName').val()];
    }
}

function getPlannerName_m() {
    if ($('#cboPlannerName').val() == null || $('#cboPlannerName').val() == '') {
        return [];
    }
    else {
        return $('#cboPlannerName').val();
    }
}

function getCriteria(filter) {
    var selectedDate = getSelectDate();
    if (filter == null)
        filter = { day: null, month: null, filter_group: null, carrier: null };
    else
        filter = { day: null || filter.day, month: null || filter.month, filter_group: null || filter.filter_group, carrier: null || filter.carrier };


    var criteria = {
        day: filter.day,
        month: filter.month || selectedDate.getMonth() + 1,
        year: selectedDate.getFullYear(),
        business: getBusiness(),
        customer: getCustomer(),
        fleet: getFleet(),
        shippingPoint: getShippingPoint(),
        shipToRegion: getShiptoRegion(),
        orderType: getOrderType(),
        truckType: getTruckType(),
        plannerName: getPlannerName(),
        matGroup: getMatfrg(),
        carrier: filter.carrier,
        filter_group: filter.filter_group
    };

    return criteria;
}
function clearCriteriaData() {
    init_datepicker_criteria_one_month();
    uiHelpers.initMonthYearpicker('#monthpicker');
    uiHelpers.initMonthYearpicker('#monthpicker_waitinglist');
    $('#cboFleet_waitinglist').val(null).trigger('change.select2');
    $('#cboBusiness').val(null).trigger('change.select2');
    $('#cboCustomer').val(null).trigger('change.select2');
    $('#cboFleet').val(null).trigger('change.select2');
    $('#cboShippingPoint').val(null).trigger('change.select2');
    $('#cboShiptoRegion').val(null).trigger('change.select2');
    $('#cboMatfrg').val(null).trigger('change.select2');
    $('#cboOrderType').val(null).trigger('change.select2');
    $('#cboTruckType').val(null).trigger('change.select2');
    $('#cboPlannerName').val(null).trigger('change.select2');
    initialRelatedCriteria();
    //initialSearchCriteria();
    
}

function clearCriteriaData_Raw() {
    uiHelpers.initMonthYearpicker('#monthpicker_Raw');
    $('#cboBusiness_Raw').val(null).trigger('change.select2');
    $('#cboCustomer_Raw').val(null).trigger('change.select2');
    $('#cboFleet_Raw').val(null).trigger('change.select2');
    $('#cboShippingPoint_Raw').val(null).trigger('change.select2');
    $('#cboShiptoRegion_Raw').val(null).trigger('change.select2');
    $('#cboMatfrg_Raw').val(null).trigger('change.select2');
    $('#cboOrderType_Raw').val(null).trigger('change.select2');
    $('#cboTruckType_Raw').val(null).trigger('change.select2');
    $('#cboPlannerName_Raw').val(null).trigger('change.select2');
    initialRelatedCriteria_Raw();
    //initialSearchCriteria_Rawdata();
}

function initialRelatedCriteria() {
    var ajax = [];
    $('#CriteriaOveray').fadeIn('xslow');
    ajax.push(uiHelpers.initBusiness('#cboBusiness'));
    ajax.push(uiHelpers.initFleet('#cboFleet'));
    ajax.push(uiHelpers.initMatfrg('#cboMatfrg'));
    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint'));
    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion'));
    init_datepicker_criteria_one_month();
    var result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').fadeOut('xslow') });
    return result;
}

function initialRelatedCriteria_Raw() {
    var ajax = [];
    $('#CriteriaOveray_Raw').fadeIn('xslow');
    ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw'));
    ajax.push(uiHelpers.initFleet('#cboFleet_Raw'));
    ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw'));
    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw'));
    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw'));
    init_datepicker_criteria_one_month();
    var result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').fadeOut('xslow') });
    return result;
}

function generateSummary_SC(controlID, serviceUrl) {
    $(controlID + ' .section-loading').show();
    var jqxhr = $.post(serviceUrl, submitCriteria)
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                var day = 1;
                for (rec of result.data) {
                    $(controlID + ' .section-box-' + day++).text(uiHelpers.displayInteger(rec.total_dn));
                }
            }

        })
        .fail(uiHelpers.postFailHandler)
        .always(function (e) {
            $(controlID + ' .section-loading').hide();
        })
        ;
}


function generateSummary(controlID, serviceUrl) {
    $(controlID + ' .section-loading').show();
    var jqxhr = $.post(serviceUrl, getCriteria())
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                var day = 1;
                for (rec of result.data) {
                    $(controlID + ' .section-box-' + day++).text(uiHelpers.displayInteger(rec.total_dn));
                }
            }

        })
        .fail(uiHelpers.postFailHandler)
        .always(function (e) {
            $(controlID + ' .section-loading').hide();
        })
        ;
}
function generateSummaryShipment(controlID, serviceUrl) {
    $(controlID + ' .section-loading').show();
    var jqxhr = $.post(serviceUrl, getCriteria())
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                var day = 1;
                for (rec of result.data) {
                    $(controlID + ' .section-box-' + day++).text(uiHelpers.displayInteger(rec.count_order));
                }
            }

        })
        .fail(uiHelpers.postFailHandler)
        .always(function (e) {
            $(controlID + ' .section-loading').hide();
        })
        ;
}

function generateGraph_SC_CB(controlID, result, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    genTable(result.dataTable.header, result.dataTable.dataDetail, "#WaitingListMonthlyDataTable", "header_detail", "detail_summary", "สถานะ / วันที่", 4);
    if (uiHelpers.errorHandler(result.data)) {
        var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
        var yTicks = null;
        if (max_yaxis == null) {
            yTicks = {
                beginAtZero: true,
            };
        }
        else {
            yTicks = {
                beginAtZero: true,
                max: max_yaxis
            };
        }
        var myChart = new Chart(ctx, {
            onAnimationComplete: animationComplete,
            type: graph_type,
            data: result.data.data,
            options: {
                scales: {
                    xAxes: [{
                        ticks: {
                            autoSkip: false,
                            callback: function (value, index, values) {
                                return value.substring(0, 2);
                            }
                        },
                        stacked: true,
                        gridLines: {
                            display: false,
                        }
                        ,
                        scaleLabel: {
                            display: xLabel != null,
                            labelString: xLabel
                        },
                        maxBarThickness: 80
                    }],
                    yAxes: [{
                        ticks: {
                            autoSkip: false
                        },
                        stacked: true,
                        scaleLabel: {
                            display: yLabel != null,
                            labelString: yLabel
                        },
                        ticks: yTicks,
                        maxBarThickness: 80
                    }]
                },
                elements: {
                    line: {
                        fill: false
                    }
                },
                responsive: true,
                maintainAspectRatio: false,
                legend: {
                    position: legendPosition,
                    display: legendPosition != null
                },
                title: {
                    display: true,
                    text: graph_title
                },
                plugins: {
                    datalabels: {
                        display: false,
                    }
                }
            }
        });

        $(controlID + ' .report-graph').click(
            function (evt) {
                var activePoints = myChart.getElementAtEvent(evt);
                if (graph_click != null)
                    graph_click(activePoints[0]);
            }
        );
    }
}

function generateGraph_SC_CB_NT(controlID, result, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    //Submit Criteria , CallBack Axis ,No Table Generate
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    if (uiHelpers.errorHandler(result)) {
        var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
        var yTicks = null;
        if (max_yaxis == null) {
            yTicks = {
                beginAtZero: true,
            };
        }
        else {
            yTicks = {
                beginAtZero: true,
                max: max_yaxis
            };
        }
        var myChart = new Chart(ctx, {
            onAnimationComplete: animationComplete,
            type: graph_type,
            data: result.data,
            options: {
                scales: {
                    xAxes: [{
                        ticks: {
                            autoSkip: false,
                            callback: function (value, index, values) {
                                return value.substring(0, 2);
                            }
                        },
                        stacked: true,
                        gridLines: {
                            display: false,
                        }
                        ,
                        scaleLabel: {
                            display: xLabel != null,
                            labelString: xLabel
                        },
                        maxBarThickness: 80
                    }],
                    yAxes: [{
                        ticks: {
                            autoSkip: false
                        },
                        stacked: true,
                        scaleLabel: {
                            display: yLabel != null,
                            labelString: yLabel
                        },
                        ticks: yTicks,
                        maxBarThickness: 80
                    }]
                },
                elements: {
                    line: {
                        fill: false
                    }
                },
                responsive: true,
                maintainAspectRatio: false,
                legend: {
                    position: legendPosition,
                    display: legendPosition != null
                },
                title: {
                    display: true,
                    text: graph_title
                },
                plugins: {
                    datalabels: {
                        display: false,
                    }
                }
            }
        });

        $(controlID + ' .report-graph').click(
            function (evt) {
                var activePoints = myChart.getElementAtEvent(evt);
                if (graph_click != null)
                    graph_click(activePoints[0]);
            }
        );
    }
}

function generateGraph_SC_NT(controlID, result, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    //Submit Criteria , CallBack Axis ,No Table Generate
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    if (uiHelpers.errorHandler(result.data)) {
        var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
        var yTicks = null;
        if (max_yaxis == null) {
            yTicks = {
                beginAtZero: true,
            };
        }
        else {
            yTicks = {
                beginAtZero: true,
                max: max_yaxis
            };
        }
        var myChart = new Chart(ctx, {
            onAnimationComplete: animationComplete,
            type: graph_type,
            data: result.data.data,
            options: {
                scales: {
                    xAxes: [{
                        ticks: {
                            autoSkip: false
                        },
                        stacked: true,
                        gridLines: {
                            display: false,
                        }
                        ,
                        scaleLabel: {
                            display: xLabel != null,
                            labelString: xLabel
                        },
                        maxBarThickness: 80
                    }],
                    yAxes: [{
                        ticks: {
                            autoSkip: false
                        },
                        stacked: true,
                        scaleLabel: {
                            display: yLabel != null,
                            labelString: yLabel
                        },
                        ticks: yTicks,
                        maxBarThickness: 80
                    }]
                },
                elements: {
                    line: {
                        fill: false
                    }
                },
                responsive: true,
                maintainAspectRatio: false,
                legend: {
                    position: legendPosition,
                    display: legendPosition != null
                },
                title: {
                    display: true,
                    text: graph_title
                },
                plugins: {
                    datalabels: {
                        display: false,
                    }
                }
            }
        });

        $(controlID + ' .report-graph').click(
            function (evt) {
                var activePoints = myChart.getElementAtEvent(evt);
                if (graph_click != null)
                    graph_click(activePoints[0]);
            }
        );
    }
}

function generateGraph_SC_NT_Y(controlID, result, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    //Submit Criteria , CallBack Axis ,No Table Generate ,Yearly
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    if (uiHelpers.errorHandler(result.data)) {
        var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
        var yTicks = null;
        if (max_yaxis == null) {
            yTicks = {
                beginAtZero: true,
            };
        }
        else {
            yTicks = {
                beginAtZero: true,
                max: max_yaxis
            };
        }
        var myChart = new Chart(ctx, {
            onAnimationComplete: animationComplete,
            type: graph_type,
            data: result.data.data,
            options: {
                scales: {
                    xAxes: [{
                        ticks: {
                            autoSkip: false
                        },
                        stacked: true,
                        gridLines: {
                            display: false,
                        }
                        ,
                        scaleLabel: {
                            display: xLabel != null,
                            labelString: xLabel
                        },
                        maxBarThickness: 80
                    }],
                    yAxes: [{
                        ticks: {
                            autoSkip: false
                        },
                        stacked: true,
                        scaleLabel: {
                            display: yLabel != null,
                            labelString: yLabel
                        },
                        ticks: yTicks,
                        maxBarThickness: 80
                    }]
                },
                elements: {
                    line: {
                        fill: false
                    }
                },
                responsive: true,
                maintainAspectRatio: false,
                legend: {
                    position: legendPosition,
                    display: legendPosition != null
                },
                title: {
                    display: true,
                    text: graph_title
                },
                plugins: {
                    datalabels: {
                        display: false,
                    }
                }
            }
        });

        $(controlID + ' .report-graph').click(
            function (evt) {
                var activePoints = myChart.getElementAtEvent(evt);
                if (graph_click != null)
                    graph_click(activePoints[0]);
            }
        );
    }
}

function generateGraph_SC(controlID, serviceUrl, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    $.post(serviceUrl, submitCriteria)
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
                if (result.countData != null) {
                    $(controlID + ' .report-container').width(200 + (25 * result.countData) + 'px');
                }
                var yTicks = null;
                if (max_yaxis == null) {
                    yTicks = {
                        beginAtZero: true,
                    };
                }
                else {
                    yTicks = {
                        beginAtZero: true,
                        max: max_yaxis
                    };
                }
                var myChart = new Chart(ctx, {
                    onAnimationComplete: animationComplete,
                    type: graph_type,
                    data: result.data,
                    options: {
                        scales: {
                            xAxes: [{
                                ticks: {
                                    autoSkip: false
                                },
                                stacked: true,
                                gridLines: {
                                    display: false,
                                }
                                ,
                                scaleLabel: {
                                    display: xLabel != null,
                                    labelString: xLabel
                                },
                                maxBarThickness: 80
                            }],
                            yAxes: [{
                                ticks: {
                                    autoSkip: false
                                },
                                stacked: true,
                                scaleLabel: {
                                    display: yLabel != null,
                                    labelString: yLabel
                                },
                                ticks: yTicks,
                                maxBarThickness: 80
                            }]
                        },
                        elements: {
                            line: {
                                fill: false
                            }
                        },
                        responsive: true,
                        maintainAspectRatio: false,
                        legend: {
                            position: legendPosition,
                            display: legendPosition != null
                        },
                        title: {
                            display: true,
                            text: graph_title
                        },
                        plugins: {
                            datalabels: {
                                display: false,
                            }
                        }
                    }
                });

                $(controlID + ' .report-graph').click(
                    function (evt) {
                        var activePoints = myChart.getElementAtEvent(evt);
                        if (graph_click != null)
                            graph_click(activePoints[0]);
                    }
                );
            }
        })
        .fail(uiHelpers.postFailHandler)
        .always(function (e) {
            $(controlID + ' .section-loading').hide();
        });
}

function generateGraph_SC_WT(controlID, result, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    //Submit Criteria With Table
    //$(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    genTableSummary(result.dataTable.header, result.dataTable.dataDetail, "#LoadMonthlyDataTable", "header_detail", "detail_summary", "Distance Group / Carrier Name", 1);
    $(controlID + ' .report-frame').css({ 'overflowX': 'hidden' });
    $(controlID + ' .report-container').width('100%');
    if (200 + (25 * result.countData) > $(window).width() * 0.8) {
        $(controlID + ' .report-container').width(200 + (25 * result.countData) + 'px');
        $(controlID + ' .report-frame').css({ 'overflowX': 'scroll' });
    }
    

    if (uiHelpers.errorHandler(result.data)) {
        var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
        var yTicks = null;
        if (max_yaxis == null) {
            yTicks = {
                beginAtZero: true,
            };
        }
        else {
            yTicks = {
                beginAtZero: true,
                max: max_yaxis
            };
        }
        var myChart = new Chart(ctx, {
            onAnimationComplete: animationComplete,
            type: graph_type,
            data: result.data.data,
            options: {
                scales: {
                    xAxes: [{
                        ticks: {
                            autoSkip: false
                        },
                        stacked: true,
                        gridLines: {
                            display: false,
                        }
                        ,
                        scaleLabel: {
                            display: xLabel != null,
                            labelString: xLabel
                        },
                        maxBarThickness: 80
                    }],
                    yAxes: [{
                        ticks: {
                            autoSkip: false
                        },
                        stacked: true,
                        scaleLabel: {
                            display: yLabel != null,
                            labelString: yLabel
                        },
                        ticks: yTicks,
                        maxBarThickness: 80
                    }]
                },
                elements: {
                    line: {
                        fill: false
                    }
                },
                responsive: true,
                maintainAspectRatio: false,
                legend: {
                    position: legendPosition,
                    display: legendPosition != null

                },
                title: {
                    display: true,
                    text: graph_title
                },
                plugins: {
                    datalabels: {
                        display: false,
                    }
                }
            }
        });

        $(controlID + ' .report-graph').click(
            function (evt) {
                var activePoints = myChart.getElementAtEvent(evt);
                if (graph_click != null)
                    graph_click(activePoints[0]);
            }
        );
    }
}



function generateGraph(controlID, serviceUrl, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    $.post(serviceUrl, getCriteria())
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
                if (result.data.countData != null) {
                    $(controlID + ' .report-container').height(150 + (20 * result.data.countData) + 'px');
                    //$(controlID + ' .report-frame').height(700 + 'px');
                    if (150 + (20 * result.data.countData) > $(window).height()*0.8) {
                        $(controlID + ' .report-frame').css({
                            height: '80vh',
                            overflowY: 'scroll'
                        });
                    }
                }
                var yTicks = null;
                if (max_yaxis == null) {
                    yTicks = {
                        beginAtZero: true,
                    };
                }
                else {
                    yTicks = {
                        beginAtZero: true,
                        max: max_yaxis
                    };
                }
                var myChart = new Chart(ctx, {
                    onAnimationComplete: animationComplete,
                    type: graph_type,
                    data: result.data,
                    options: {
                        scales: {
                            xAxes: [{
                                ticks: {
                                    autoSkip: false
                                },
                                stacked: true,
                                gridLines: {
                                    display: false,
                                }
                                ,
                                scaleLabel: {
                                    display: xLabel != null,
                                    labelString: xLabel
                                },
                                maxBarThickness: 80
                            }],
                            yAxes: [{
                                ticks: {
                                    autoSkip: false
                                },
                                stacked: true,
                                scaleLabel: {
                                    display: yLabel != null,
                                    labelString: yLabel
                                },
                                ticks: yTicks,
                                maxBarThickness: 80
                            }]
                        },
                        elements: {
                            line: {
                                fill: false
                            }
                        },
                        responsive: true,
                        maintainAspectRatio: false,
                        legend: {
                            position: legendPosition,
                            display: legendPosition != null
                        },
                        title: {
                            display: true,
                            text: graph_title
                        },
                        plugins: {
                            datalabels: {
                                display: false,
                            }
                        }
                    }
                });

                $(controlID + ' .report-graph').click(
                    function (evt) {
                        var activePoints = myChart.getElementAtEvent(evt);
                        if (graph_click != null)
                            graph_click(activePoints[0]);
                    }
                );
            }
        })
        .fail(uiHelpers.postFailHandler)
        .always(function (e) {
            $(controlID + ' .section-loading').hide();
        });
}

function generateGraphTransportSummary(controlID, serviceUrl, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    $.post(serviceUrl, getCriteria())
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
                var yTicks = null;
                if (max_yaxis == null) {
                    yTicks = {
                        beginAtZero: true,
                    };
                }
                else {
                    yTicks = {
                        beginAtZero: true,
                        max: max_yaxis
                    };
                }
                var myChart = new Chart(ctx, {
                    onAnimationComplete: animationComplete,
                    type: graph_type,
                    data: result.data,
                    options: {
                        scales: {
                            xAxes: [{
                                ticks: {
                                    autoSkip: false
                                },
                                stacked: true,
                                gridLines: {
                                    display: false,
                                }
                                ,
                                scaleLabel: {
                                    display: xLabel != null,
                                    labelString: xLabel
                                },
                                maxBarThickness: 80
                            }],
                            yAxes: [{
                                ticks: {
                                    autoSkip: false
                                },
                                stacked: true,
                                scaleLabel: {
                                    display: yLabel != null,
                                    labelString: yLabel
                                },
                                ticks: yTicks,
                                maxBarThickness: 80
                            }]
                        },
                        elements: {
                            line: {
                                fill: false
                            }
                        },
                        responsive: true,
                        maintainAspectRatio: false,
                        legend: {
                            position: legendPosition,
                            display: legendPosition != null
                        },
                        title: {
                            display: true,
                            text: graph_title
                        },
                        plugins: {
                            datalabels: {
                                display: false,
                            }
                        }
                    }
                });

                $(controlID + ' .report-graph').click(
                    function (evt) {
                        var activePoints = myChart.getElementAtEvent(evt);
                        if (graph_click != null)
                            graph_click(activePoints[0]);
                    }
                );
            }
        })
        .fail(uiHelpers.postFailHandler)
        .always(function (e) {
            $(controlID + ' .section-loading').hide();
        });
}

function generateGraphTransportMultiAxisSummary(controlID, serviceUrl, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, animationComplete, max_yaxis = null) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    $.post(serviceUrl, getCriteria())
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                var ctx = $(controlID + ' .report-graph')[0].getContext('2d');
                var yTicks = null;
                if (max_yaxis == null) {
                    yTicks = {
                        beginAtZero: true,
                    };
                }
                else {
                    yTicks = {
                        beginAtZero: true,
                        max: max_yaxis
                    };
                }
                var myChart = new Chart(ctx, {
                    onAnimationComplete: animationComplete,
                    type: graph_type,
                    data: result.data,
                    options: {
                        scales: {
                            xAxes: [{
                                ticks: {
                                    autoSkip: false
                                },
                                stacked: true,
                                gridLines: {
                                    display: false,
                                }
                                ,
                                scaleLabel: {
                                    display: xLabel != null,
                                    labelString: xLabel
                                },
                                maxBarThickness: 80
                            }],
                            yAxes:
                                [
                                    {
                                        gridLines: {
                                            display: true,
                                        },
                                        stacked: false,
                                        ticks: {
                                            beginAtZero: true,
                                            autoSkip: false
                                        },
                                        scaleLabel: {
                                            display: yLabel != null,
                                            labelString: yLabel
                                        },
                                        type: 'linear',
                                        id: 'left-axis',
                                        position: 'left',
                                        ticks: yTicks,
                                        maxBarThickness: 80
                                    },
                                    {
                                        gridLines: {
                                            display: false,
                                        },
                                        ticks: {
                                            beginAtZero: true,
                                            suggestedMax: 100
                                        },
                                        scaleLabel: {
                                            display: yLabel != null,
                                            labelString: yLabel
                                        },
                                        stacked: false,
                                        id: 'right-axis',
                                        position: 'right',
                                        ticks: yTicks,
                                        maxBarThickness: 80
                                    }
                                ]
                        },
                        elements: {
                            line: {
                                fill: false
                            }
                        },
                        responsive: true,
                        maintainAspectRatio: false,
                        legend: {
                            position: legendPosition,
                            display: legendPosition != null
                        },
                        title: {
                            display: true,
                            text: graph_title
                        },
                        plugins: {
                            datalabels: {
                                display: false,
                            }
                        }
                    }
                });

                $(controlID + ' .report-graph').click(
                    function (evt) {
                        var activePoints = myChart.getElementAtEvent(evt);
                        if (graph_click != null)
                            graph_click(activePoints[0]);
                    }
                );
            }
        })
        .fail(uiHelpers.postFailHandler)
        .always(function (e) {
            $(controlID + ' .section-loading').hide();
        });
}



function downloadPDF(controlID) {
    var newCanvas = $(controlID + ' .report-graph')[0];
    var filename = $(controlID + ' .report-filename').val();
    uiHelpers._downloadPDF(newCanvas, filename);
}

function generateTable(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getCriteria(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'excel'
                        ],
                        //fixedHeader: true,
                        scrollX: true,
                        ordering: false,
                        responsive: true,
                        scrollY:'40vh',
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
                            'copy', 'excel'
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

function generateTable_order(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getCriteria_order(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'excel'
                        ],
                        //fixedHeader: true,
                        scrollX: true,
                        ordering: false,
                        responsive: true,
                        scrollY: '40vh',
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
                            'copy', 'excel'
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

function generateTable_request(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getCriteria_request(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'excel'
                        ],
                        //fixedHeader: true,
                        scrollX: true,
                        ordering: false,
                        responsive: true,
                        scrollY: '40vh',
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
                            'copy', 'excel'
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


function generateTable_SC(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getCriteria_Raw())
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'excel'
                        ],
                        //fixedHeader: true,
                        scrollX: true,
                        ordering: false,
                        responsive: true,
                        pageLength: 10,
                        scrollY:'40vh',
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
                            'copy', 'excel'
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


function generateTableWithoutPaging(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getCriteria(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'excel'
                        ],
                        fixedHeader: true,
                        scrollY: '60vh',
                        scrollX: true,
                        ordering: false,
                        responsive: true,
                        paging: false,
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
                            'copy', 'excel'
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

function generateTableLead(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').fadeIn('xslow');
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getCriteria_Raw(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'excel'
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
                            'copy', 'excel'
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
            $(controlID + ' .section-loading').fadeOut('xslow');
        });
    return jqxhr;
}

function generateTableLeadModal_SC(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getSubmitCriteria(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'excel'
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
                            'copy', 'excel'
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
    var jqxhr = $.post(serviceUrl, getCriteria(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        dom: 'lTf<"html5buttons"B > gtip',
                        buttons: [
                            'copy', 'excel'
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
                            'copy', 'excel'
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

function generateTableGraph(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, getCriteria(filter))
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
                    $(controlID + ' .section-table-render').DataTable({
                        sDom: 'lrtip',
                        fixedHeader: true,
                        scrollX: true,
                        ordering: true,
                        responsive: true,
                        pageLength: 10,
                        filter: true,
                        searchable: false,
                        bInfo: false,
                        Info: false,
                        lengthChange: false,
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
                            'copy', 'excel'
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

function generateTableWithData(controlID, result, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    if (uiHelpers.errorHandler(result)) {
        if (!$.fn.DataTable.isDataTable(controlID + ' .section-table-render')) {
            $(controlID + ' .section-table-render').DataTable({
                dom: 'lTf<"html5buttons"B > gtip',
                buttons: [
                    'copy', 'excel'
                ],
                fixedHeader: true,
                scrollX: true,
                ordering: false,
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
                    'copy', 'excel'
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
    $(controlID + ' .section-loading').hide();
}

function searchSummary(aging) {
    $('#modals-transaction').modal('show');
    var filter = { aging: aging }
    genTableModal(filter);
}

    //$('#cboBusiness').on("select2:clear", function (element, checked) {
    //    //if (flagClear == false) {
    //    console.log('Clear Business');
    //    CriteriaObj.business.value = getBusiness_m();
    //    CriteriaObj.business.flag = true;
    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    //let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    //let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    //let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    //let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    //let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

    //    //$('#cboFleet').val(fleet).trigger('change.select2');
    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], CriteriaObj.matfrg.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    //}
    //});

    //$('#cboFleet').on("select2:clear", function (element, checked) {
    //    console.log('Clear Fleet');
    //    CriteriaObj.fleet.value = getFleet_m();
    //    CriteriaObj.fleet.flag = true;
    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], CriteriaObj.matfrg.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //});

    //$('#cboMatfrg').on("select2:clear", function (element, checked) {
    //    console.log('Clear Matfrg');
    //    //matfrg = getMatfrg();
    //    CriteriaObj.matfrg.value = getMatfrg_m();
    //    CriteriaObj.matfrg.flag = true;
    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);
    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], CriteriaObj.matfrg.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //});

    //$('#cboShippingPoint').on("select2:clear", function (element, checked) {
    //    console.log('Clear ShippingPoint');
    //    //matfrg = getMatfrg();
    //    CriteriaObj.shippingpoint.value = getShippingPoint_m();
    //    CriteriaObj.shippingpoint.flag = true;
    //    //shippingpoint = getShippingPoint();
    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);
    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], CriteriaObj.matfrg.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //    //flagClear = true;
    //});

    //$('#cboShiptoRegion').on("select2:clear", function (element, checked) {
    //    console.log('Clear ShipToRegion');
    //    //shiptoregion = getShiptoRegion();
    //    CriteriaObj.shiptoregion.value = getShiptoRegion_m();
    //    CriteriaObj.shiptoregion.flag = true;
    //    //flagClear = true;
    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);
    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], CriteriaObj.matfrg.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.shippingpoint.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shiptoregion.value).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //});




    ////=============
    //// On Change
    ////=============




    //$('#cboBusiness').on("change", function (element, checked) {
    //    if (CriteriaObj.business.flag == true) {
    //        if (CriteriaObj.business.count == 0) {
    //            CriteriaObj.business.flag = false;
    //        }
    //        CriteriaObj.business.count--;
    //        element.preventDefault();
    //        return;
    //    }

    //    console.log('Change Business Flag:' + CriteriaObj.business.flag);
    //    CriteriaObj.business.value = getBusiness_m();
    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

    //    //ajax.push(uiHelpers.initBusiness('#cboBusiness', [], selectMatfreight, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, selectShippingpoint, selectRegion).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, selectRegion).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });

    //    CriteriaObj.business.count = $('#cboBusiness').select2('data').length;
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //});
    ////}

    //$('#cboFleet').on("change", function (element, checked) {

    //    if (CriteriaObj.fleet.flag == true) {

    //        if (CriteriaObj.fleet.count == 0) {
    //            CriteriaObj.fleet.flag = false;
    //        }
    //        CriteriaObj.fleet.count--;
    //        element.preventDefault();
    //        return;
    //    }

    //    console.log('Change Fleet Flag:' + CriteriaObj.fleet.flag);
    //    CriteriaObj.fleet.value = getFleet_m();

    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], selectMatfreight, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    //ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, selectShippingpoint, selectRegion).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, selectRegion).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));

    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    CriteriaObj.fleet.count = $('#cboFleet').select2('data').length;
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //});

    //$('#cboMatfrg').on("change", function (element, checked) {
    //    if (CriteriaObj.matfrg.flag == true) {
    //        if (CriteriaObj.matfrg.count == 0) {
    //            CriteriaObj.matfrg.flag = false;
    //        }
    //        CriteriaObj.matfrg.count--;
    //        element.preventDefault();
    //        return;
    //    }
    //    console.log('Change Matfrg Flag:' + CriteriaObj.matfrg.flag);
    //    CriteriaObj.fleet.value = getMatfrg_m();

    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], selectMatfreight, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, selectShippingpoint, selectRegion).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    //ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, selectRegion).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //    CriteriaObj.matfrg.count = $('#cboMatfrg').select2('data').length;
    //});

    //$('#cboShippingPoint').on("change", function (element, checked) {
    //    if (CriteriaObj.shippingpoint.flag == true) {
    //        if (CriteriaObj.shippingpoint.count == 0) {
    //            CriteriaObj.shippingpoint.flag = false;
    //        }
    //        CriteriaObj.shippingpoint.count--;
    //        element.preventDefault();
    //        return;
    //    }
    //    console.log('Change ShippingPoint Flag:' + CriteriaObj.shippingpoint.flag);
    //    CriteriaObj.shippingpoint.value = getShippingPoint_m();

    //    //shippingpoint = getShippingPoint();

    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], selectMatfreight, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, selectShippingpoint, selectRegion).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    //ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, selectRegion).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //    CriteriaObj.shippingpoint.count = $('#cboShippingPoint').select2('data').length;
    //});

    //$('#cboShiptoRegion').on("change", function (element, checked) {
    //    if (CriteriaObj.shiptoregion.flag == true) {
    //        if (CriteriaObj.shiptoregion.count == 0) {
    //            CriteriaObj.shiptoregion.flag = false;
    //        }
    //        CriteriaObj.shiptoregion.count--;
    //        element.preventDefault();
    //        return;
    //    }
    //    console.log('Change ShipToRegion Flag:' + CriteriaObj.shiptoregion.flag);
    //    CriteriaObj.shiptoregion.value = getShiptoRegion_m();

    //    let ajax = [];
    //    $('#CriteriaOveray').show();
    //    let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
    //    let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
    //    let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
    //    let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
    //    let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);
    //    ajax.push(uiHelpers.initBusiness('#cboBusiness', [], selectMatfreight, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, selectShippingpoint, selectRegion).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
    //    ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, selectRegion).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
    //    //ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
    //    let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
    //    //alert($('#cboBusiness').select2('data').map(x => x.id));
    //    CriteriaObj.shiptoregion.count = $('#cboShiptoRegion').select2('data').length;
    //});


function comboOnchange() {

    var CriteriaObj = {
        business: {
            value: [],
            flag: false,
            count: 0
        },
        fleet: {
            value: [],
            flag: false,
            count: 0
        },
        matfrg: {
            value: [],
            flag: false,
            count: 0
        },
        shippingpoint: {
            value: [],
            flag: false,
            count: 0
        },
        shiptoregion: {
            value: [],
            flag: false,
            count: 0
        }
    };


    $('#cboBusiness').on("select2:clear", function (element, checked) {
        //if (flagClear == false) {
        console.log('Clear Business');
        CriteriaObj.business.value = getBusiness_m();
        CriteriaObj.business.flag = true;
        let ajax = [];
        $('#CriteriaOveray').show();
        //let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
        //let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
        //let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
        //let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
        //let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

        //$('#cboFleet').val(fleet).trigger('change.select2');

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        //}
    });

    $('#cboFleet').on("select2:clear", function (element, checked) {
        console.log('Clear Fleet');
        CriteriaObj.fleet.value = getFleet_m();
        CriteriaObj.fleet.flag = true;
        let ajax = [];
        $('#CriteriaOveray').show();

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
    });

    $('#cboMatfrg').on("select2:clear", function (element, checked) {
        console.log('Clear Matfrg');
        //matfrg = getMatfrg();
        CriteriaObj.matfrg.value = getMatfrg_m();
        CriteriaObj.matfrg.flag = true;
        let ajax = [];
        $('#CriteriaOveray').show();

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
    });

    $('#cboShippingPoint').on("select2:clear", function (element, checked) {
        console.log('Clear ShippingPoint');
        //matfrg = getMatfrg();
        CriteriaObj.shippingpoint.value = getShippingPoint_m();
        CriteriaObj.shippingpoint.flag = true;
        //shippingpoint = getShippingPoint();
        let ajax = [];
        $('#CriteriaOveray').show();

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
        //flagClear = true;
    });

    $('#cboShiptoRegion').on("select2:clear", function (element, checked) {
        console.log('Clear ShipToRegion');
        //shiptoregion = getShiptoRegion();
        CriteriaObj.shiptoregion.value = getShiptoRegion_m();
        CriteriaObj.shiptoregion.flag = true;
        //flagClear = true;
        let ajax = [];
        $('#CriteriaOveray').show();

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], CriteriaObj.business.value, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], CriteriaObj.business.value, CriteriaObj.matfrg.value, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], CriteriaObj.business.value, CriteriaObj.fleet.value, CriteriaObj.matfrg.value, CriteriaObj.shippingpoint.value).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
    });




    //=============
    // On Change
    //=============




    $('#cboBusiness').on("change", function (element, checked) {
        if (CriteriaObj.business.flag == true) {
            if (CriteriaObj.business.count == 0) {
                CriteriaObj.business.flag = false;
            }
            CriteriaObj.business.count--;
            element.preventDefault();
            return;
        }

        //console.log('Change Business Flag:' + CriteriaObj.business.flag);
        CriteriaObj.business.value = getBusiness_m();
        let ajax = [];
        $('#CriteriaOveray').show();
        let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

        $('#cboMatfrg').empty();
        $('#cboFleet').empty();
        $('#cboShippingPoint').empty();
        $('#cboShiptoRegion').empty();
        
        //ajax.push(uiHelpers.initBusiness('#cboBusiness', [], selectMatfreight, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });

        CriteriaObj.business.count = $('#cboBusiness').select2('data').length;
        //alert($('#cboBusiness').select2('data').map(x => x.id));
    });
    //}


    $('#cboMatfrg').on("change", function (element, checked) {
        if (CriteriaObj.matfrg.flag == true) {
            if (CriteriaObj.matfrg.count == 0) {
                CriteriaObj.matfrg.flag = false;
            }
            CriteriaObj.matfrg.count--;
            element.preventDefault();
            return;
        }
        console.log('Change Matfrg Flag:' + CriteriaObj.matfrg.flag);
        CriteriaObj.matfrg.value = getMatfrg_m();

        let ajax = [];
        $('#CriteriaOveray').show();
        let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

        $('#cboBusiness').empty();
        $('#cboFleet').empty();
        $('#cboShippingPoint').empty();
        $('#cboShiptoRegion').empty();

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        //ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
        CriteriaObj.matfrg.count = $('#cboMatfrg').select2('data').length;
    });

    $('#cboFleet').on("change", function (element, checked) {

        if (CriteriaObj.fleet.flag == true) {

            if (CriteriaObj.fleet.count == 0) {
                CriteriaObj.fleet.flag = false;
            }
            CriteriaObj.fleet.count--;
            element.preventDefault();
            return;
        }

        console.log('Change Fleet Flag:' + CriteriaObj.fleet.flag);
        CriteriaObj.fleet.value = getFleet_m();

        let ajax = [];
        $('#CriteriaOveray').show();

        let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

        $('#cboBusiness').empty();
        $('#cboMatfrg').empty();
        $('#cboShippingPoint').empty();
        $('#cboShiptoRegion').empty();

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        //ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        CriteriaObj.fleet.count = $('#cboFleet').select2('data').length;
        //alert($('#cboBusiness').select2('data').map(x => x.id));
    });


    $('#cboShippingPoint').on("change", function (element, checked) {
        if (CriteriaObj.shippingpoint.flag == true) {
            if (CriteriaObj.shippingpoint.count == 0) {
                CriteriaObj.shippingpoint.flag = false;
            }
            CriteriaObj.shippingpoint.count--;
            element.preventDefault();
            return;
        }
        console.log('Change ShippingPoint Flag:' + CriteriaObj.shippingpoint.flag);
        CriteriaObj.shippingpoint.value = getShippingPoint_m();

        //shippingpoint = getShippingPoint();

        let ajax = [];
        $('#CriteriaOveray').show();
        let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

        $('#cboBusiness').empty();
        $('#cboMatfrg').empty();
        $('#cboFleet').empty();
        $('#cboShiptoRegion').empty();

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        //ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
        CriteriaObj.shippingpoint.count = $('#cboShippingPoint').select2('data').length;
    });

    $('#cboShiptoRegion').on("change", function (element, checked) {
        if (CriteriaObj.shiptoregion.flag == true) {
            if (CriteriaObj.shiptoregion.count == 0) {
                CriteriaObj.shiptoregion.flag = false;
            }
            CriteriaObj.shiptoregion.count--;
            element.preventDefault();
            return;
        }
        console.log('Change ShipToRegion Flag:' + CriteriaObj.shiptoregion.flag);
        CriteriaObj.shiptoregion.value = getShiptoRegion_m();

        let ajax = [];
        $('#CriteriaOveray').show();
        let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

        $('#cboBusiness').empty();
        $('#cboMatfrg').empty();
        $('#cboFleet').empty();
        $('#cboShippingPoint').empty();

        ajax.push(uiHelpers.initBusiness('#cboBusiness', [], [], [], [], []).always(() => { $('#cboBusiness').val(CriteriaObj.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet').val(CriteriaObj.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint').val(CriteriaObj.shippingpoint.value).trigger('change.select2'); }));
        //ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
        CriteriaObj.shiptoregion.count = $('#cboShiptoRegion').select2('data').length;
    });
}

var formatCurrency = function (amount) {
    if (!amount) {
        return "0";
    }
    amount += '';
    x = amount.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1)) {
        x1 = x1.replace(rgx, '$1' + ',' + '$2');
    }
    return "" + x1 + x2;
}

function getSubmitDate() {
    return moment(submitCriteria.orderStartDate, 'YYYY/MM/DD')._d;
}
function clearCriteria() {
    clearCriteriaData();
    submitCriteria = null;
}
function clearCriteria_Raw() {
    clearCriteriaData_Raw();
}
function clearBeforeBind() {
    $('#cboBusiness').val(null).trigger('change.select2');
    $('#cboMatfrg').val(null).trigger('change.select2');
    $('#cboFleet').val(null).trigger('change.select2');
    $('#cboShippingPoint').val(null).trigger('change.select2');
    $('#cboShiptoRegion').val(null).trigger('change.select2');
}


//===================
//===================
// Onchange Rawdata
//===================
//===================


function comboOnchange_Rawdata() {

    var CriteriaObj_Raw = {
        business: {
            value: [],
            flag: false,
            count: 0
        },
        fleet: {
            value: [],
            flag: false,
            count: 0
        },
        matfrg: {
            value: [],
            flag: false,
            count: 0
        },
        shippingpoint: {
            value: [],
            flag: false,
            count: 0
        },
        shiptoregion: {
            value: [],
            flag: false,
            count: 0
        }
    };


    $('#cboBusiness_Raw').on("select2:clear", function (element, checked) {
        //if (flagClear == false) {
        console.log('Clear Business Raw');
        CriteriaObj_Raw.business.value = getCombo_Raw('#cboBusiness_Raw');
        CriteriaObj_Raw.business.flag = true;
        let ajax = [];
        $('#CriteriaOveray_Raw').show();
        //let selectBusiness = $('#cboBusiness').select2('data').map(x => x.id);
        //let selectFleet = $('#cboFleet').select2('data').map(x => x.id);
        //let selectMatfreight = $('#cboMatfrg').select2('data').map(x => x.id);
        //let selectShippingpoint = $('#cboShippingPoint').select2('data').map(x => x.id);
        //let selectRegion = $('#cboShiptoRegion').select2('data').map(x => x.id);

        //$('#cboFleet').val(fleet).trigger('change.select2');

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], CriteriaObj_Raw.business.value, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.matfrg.value, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, CriteriaObj_Raw.shippingpoint.value).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
        //}
    });

    $('#cboFleet_Raw').on("select2:clear", function (element, checked) {
        console.log('Clear Fleet');
        CriteriaObj_Raw.fleet.value = getCombo_Raw('#cboFleet_Raw');
        CriteriaObj_Raw.fleet.flag = true;
        let ajax = [];
        $('#CriteriaOveray_Raw').show();

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], CriteriaObj_Raw.business.value, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.matfrg.value, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, CriteriaObj_Raw.shippingpoint.value).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
    });

    $('#cboMatfrg_Raw').on("select2:clear", function (element, checked) {
        console.log('Clear Matfrg');
        //matfrg = getMatfrg();
        CriteriaObj_Raw.matfrg.value = getCombo_Raw('#cboMatfrg_Raw');
        CriteriaObj_Raw.matfrg.flag = true;
        let ajax = [];
        $('#CriteriaOveray_Raw').show();

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], CriteriaObj_Raw.business.value, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.matfrg.value, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, CriteriaObj_Raw.shippingpoint.value).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
    });

    $('#cboShippingPoint_Raw').on("select2:clear", function (element, checked) {
        console.log('Clear ShippingPoint');
        //matfrg = getMatfrg();
        CriteriaObj_Raw.shippingpoint.value = getCombo_Raw('#cboShippingPoint_Raw');
        CriteriaObj_Raw.shippingpoint.flag = true;
        //shippingpoint = getShippingPoint();
        let ajax = [];
        $('#CriteriaOveray_Raw').show();

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], CriteriaObj_Raw.business.value, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.matfrg.value, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, CriteriaObj_Raw.shippingpoint.value).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
        //flagClear = true;
    });

    $('#cboShiptoRegion_Raw').on("select2:clear", function (element, checked) {
        console.log('Clear ShipToRegion');
        //shiptoregion = getShiptoRegion();
        CriteriaObj_Raw.shiptoregion.value = getCombo_Raw('#cboShiptoRegion_Raw');
        CriteriaObj_Raw.shiptoregion.flag = true;
        //flagClear = true;
        let ajax = [];
        $('#CriteriaOveray_Raw').show();

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], CriteriaObj_Raw.business.value, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.matfrg.value, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], CriteriaObj_Raw.business.value, CriteriaObj_Raw.fleet.value, CriteriaObj_Raw.matfrg.value, CriteriaObj_Raw.shippingpoint.value).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
    });




    //=============
    // On Change
    //=============




    $('#cboBusiness_Raw').on("change", function (element, checked) {
        if (CriteriaObj_Raw.business.flag == true) {
            if (CriteriaObj_Raw.business.count == 0) {
                CriteriaObj_Raw.business.flag = false;
            }
            CriteriaObj_Raw.business.count--;
            element.preventDefault();
            return;
        }

        //console.log('Change Business Flag:' + CriteriaObj_Raw.business.flag);
        CriteriaObj_Raw.business.value = getCombo_Raw('#cboBusiness_Raw');
        let ajax = [];
        $('#CriteriaOveray_Raw').show();
        let selectBusiness = $('#cboBusiness_Raw').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet_Raw').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg_Raw').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint_Raw').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion_Raw').select2('data').map(x => x.id);

        $('#cboMatfrg_Raw').empty();
        $('#cboFleet_Raw').empty();
        $('#cboShippingPoint_Raw').empty();
        $('#cboShiptoRegion_Raw').empty();

        //ajax.push(uiHelpers.initBusiness('#cboBusiness', [], selectMatfreight, selectFleet, selectShippingpoint, selectRegion).always(() => { $('#cboBusiness').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });

        CriteriaObj_Raw.business.count = $('#cboBusiness_Raw').select2('data').length;
        //alert($('#cboBusiness').select2('data').map(x => x.id));
    });
    //}


    $('#cboMatfrg_Raw').on("change", function (element, checked) {
        if (CriteriaObj_Raw.matfrg.flag == true) {
            if (CriteriaObj_Raw.matfrg.count == 0) {
                CriteriaObj_Raw.matfrg.flag = false;
            }
            CriteriaObj_Raw.matfrg.count--;
            element.preventDefault();
            return;
        }
        console.log('Change Matfrg Flag:' + CriteriaObj_Raw.matfrg.flag);
        CriteriaObj_Raw.matfrg.value = getCombo_Raw('#cboMatfrg_Raw');

        let ajax = [];
        $('#CriteriaOveray_Raw').show();
        let selectBusiness = $('#cboBusiness_Raw').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet_Raw').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg_Raw').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint_Raw').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion_Raw').select2('data').map(x => x.id);

        $('#cboBusiness_Raw').empty();
        $('#cboFleet_Raw').empty();
        $('#cboShippingPoint_Raw').empty();
        $('#cboShiptoRegion_Raw').empty();

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        //ajax.push(uiHelpers.initMatfrg('#cboMatfrg', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
        CriteriaObj_Raw.matfrg.count = $('#cboMatfrg_Raw').select2('data').length;
    });

    $('#cboFleet_Raw').on("change", function (element, checked) {

        if (CriteriaObj_Raw.fleet.flag == true) {

            if (CriteriaObj_Raw.fleet.count == 0) {
                CriteriaObj_Raw.fleet.flag = false;
            }
            CriteriaObj_Raw.fleet.count--;
            element.preventDefault();
            return;
        }

        console.log('Change Fleet Flag:' + CriteriaObj_Raw.fleet.flag);
        CriteriaObj_Raw.fleet.value = getCombo_Raw('#cboFleet_Raw');

        let ajax = [];
        $('#CriteriaOveray_Raw').show();

        let selectBusiness = $('#cboBusiness_Raw').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet_Raw').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg_Raw').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint_Raw').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion_Raw').select2('data').map(x => x.id);

        $('#cboBusiness_Raw').empty();
        $('#cboMatfrg_Raw').empty();
        $('#cboShippingPoint_Raw').empty();
        $('#cboShiptoRegion_Raw').empty();

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        //ajax.push(uiHelpers.initFleet('#cboFleet', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
        CriteriaObj_Raw.fleet.count = $('#cboFleet_Raw').select2('data').length;
        //alert($('#cboBusiness').select2('data').map(x => x.id));
    });


    $('#cboShippingPoint_Raw').on("change", function (element, checked) {
        if (CriteriaObj_Raw.shippingpoint.flag == true) {
            if (CriteriaObj_Raw.shippingpoint.count == 0) {
                CriteriaObj_Raw.shippingpoint.flag = false;
            }
            CriteriaObj_Raw.shippingpoint.count--;
            element.preventDefault();
            return;
        }
        console.log('Change ShippingPoint Flag:' + CriteriaObj_Raw.shippingpoint.flag);
        CriteriaObj_Raw.shippingpoint.value = getCombo_Raw('#cboShippingPoint_Raw');

        //shippingpoint = getShippingPoint();

        let ajax = [];
        $('#CriteriaOveray_Raw').show();
        let selectBusiness = $('#cboBusiness_Raw').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet_Raw').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg_Raw').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint_Raw').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion_Raw').select2('data').map(x => x.id);

        $('#cboBusiness_Raw').empty();
        $('#cboMatfrg_Raw').empty();
        $('#cboFleet_Raw').empty();
        $('#cboShiptoRegion_Raw').empty();

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        //ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); })); 
        ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion_Raw', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion_Raw').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
        CriteriaObj_Raw.shippingpoint.count = $('#cboShippingPoint_Raw').select2('data').length;
    });

    $('#cboShiptoRegion_Raw').on("change", function (element, checked) {
        if (CriteriaObj_Raw.shiptoregion.flag == true) {
            if (CriteriaObj_Raw.shiptoregion.count == 0) {
                CriteriaObj_Raw.shiptoregion.flag = false;
            }
            CriteriaObj_Raw.shiptoregion.count--;
            element.preventDefault();
            return;
        }
        console.log('Change ShipToRegion Flag:' + CriteriaObj_Raw.shiptoregion.flag);
        CriteriaObj_Raw.shiptoregion.value = getCombo_Raw('#cboShiptoRegion_Raw');

        let ajax = [];
        $('#CriteriaOveray_Raw').show();
        let selectBusiness = $('#cboBusiness_Raw').select2('data').map(x => x.id);
        let selectFleet = $('#cboFleet_Raw').select2('data').map(x => x.id);
        let selectMatfreight = $('#cboMatfrg_Raw').select2('data').map(x => x.id);
        let selectShippingpoint = $('#cboShippingPoint_Raw').select2('data').map(x => x.id);
        let selectRegion = $('#cboShiptoRegion_Raw').select2('data').map(x => x.id);

        $('#cboBusiness_Raw').empty();
        $('#cboMatfrg_Raw').empty();
        $('#cboFleet_Raw').empty();
        $('#cboShippingPoint_Raw').empty();

        ajax.push(uiHelpers.initBusiness('#cboBusiness_Raw', [], [], [], [], []).always(() => { $('#cboBusiness_Raw').val(CriteriaObj_Raw.business.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initMatfrg('#cboMatfrg_Raw', [], [], selectBusiness, [], [], []).always(() => { $('#cboMatfrg_Raw').val(CriteriaObj_Raw.matfrg.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initFleet('#cboFleet_Raw', [], [], selectBusiness, selectMatfreight, [], []).always(() => { $('#cboFleet_Raw').val(CriteriaObj_Raw.fleet.value).trigger('change.select2'); }));
        ajax.push(uiHelpers.initShippingPoint('#cboShippingPoint_Raw', [], [], selectBusiness, selectFleet, selectMatfreight, []).always(() => { $('#cboShippingPoint_Raw').val(CriteriaObj_Raw.shippingpoint.value).trigger('change.select2'); }));
        //ajax.push(uiHelpers.initShiptoRegion('#cboShiptoRegion', [], [], selectBusiness, selectFleet, selectMatfreight, selectShippingpoint).always(() => { $('#cboShiptoRegion').val(CriteriaObj_Raw.shiptoregion.value).trigger('change.select2'); }));
        let result = Promise.all(ajax).finally(() => { $('#CriteriaOveray_Raw').hide(); });
        //alert($('#cboBusiness').select2('data').map(x => x.id));
        CriteriaObj_Raw.shiptoregion.count = $('#cboShiptoRegion').select2('data').length;
    });
}

var formatCurrency = function (amount) {
    if (!amount) {
        return "0";
    }
    amount += '';
    x = amount.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1)) {
        x1 = x1.replace(rgx, '$1' + ',' + '$2');
    }
    return "" + x1 + x2;
}

function getSubmitDate() {
    return moment(submitCriteria.orderStartDate, 'YYYY/MM/DD')._d;
}
function clearCriteria() {
    clearCriteriaData();
    submitCriteria = null;
}
function clearBeforeBind() {
    $('#cboBusiness').val(null).trigger('change.select2');
    $('#cboMatfrg').val(null).trigger('change.select2');
    $('#cboFleet').val(null).trigger('change.select2');
    $('#cboShippingPoint').val(null).trigger('change.select2');
    $('#cboShiptoRegion').val(null).trigger('change.select2');
}

function getCriteria_Raw(filter) {

    var date = moment(getSelectDate_Raw());
    var startDate;
    var endDate;
    if (date != null) {
        //var tmpStartDate = date.startOf('month').format('YYYY/MM/DD');
        //var tmpEndDate = date.endDate._d;
        startDate = date.startOf('month').format('YYYY/MM/DD');
        endDate = date.endOf('month').format('YYYY/MM/DD');
    }

    if (filter == null)
        filter = {
            day: null, month: null, filter_group: null, carrier: null, product_group: null, aging: null, plannerName: getCombo_Raw('#cboPlannerName_Raw'),
            orderStartDate: startDate, orderEndDate: endDate
        };
    else {
        filter = {
            day: null || filter.day, month: null || filter.month, filter_group: null || filter.filter_group, carrier: null || filter.carrier,
            product_group: null || filter.product_group, aging_lpc: null || filter.aging_lpc, plannerName: null || filter.plannerName,
            status: null || filter.status, orderStartDate: null || filter.orderStartDate,
            orderEndDate: null || filter.orderEndDate
        };
    }

    var criteria = {
        orderStartDate: filter.orderStartDate,
        orderEndDate: filter.orderEndDate,
        business: getCombo_Raw('#cboBusiness_Raw'),
        fleet: getCombo_Raw('#cboFleet_Raw'),
        customer: getCombo_Raw('#cboCustomer_Raw'),
        shippingPoint: getCombo_Raw('#cboShippingPoint_Raw'),
        shipToRegion: getCombo_Raw('#cboShiptoRegion_Raw'),
        orderType: getCombo_Raw('#cboOrderType_Raw'),
        truckType: getCombo_Raw('#cboTruckType_Raw'),
        plannerName: getCombo_Raw('#cboPlannerName_Raw'),
        matGroup: getCombo_Raw('#cboMatfrg_Raw'),
        status: filter.status,
        carrier: filter.carrier,
        aging_lpc: filter.aging_lpc,
        product_group: filter.product_group,
        filter_group: filter.filter_group
    };
    console.log(criteria);

    return criteria;
}

function getCombo_Raw(controlID) {
    if ($(controlID).val() == null || $(controlID).val() == '') {
        return [];
    }
    else {
        return $(controlID).val();
    }
}
