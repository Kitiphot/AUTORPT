function initialControl() {
    //set full date to report header
    if ($('#reportHeader') != null)
        $('#reportHeader').text(uiHelpers.displayFullDate(new Date()));

    //initial search criteria section
    return initialSearchCriteria();
}

function GenerateDatatable(data, columns) {
    //table = $("#dtList").DataTable().destroy();
    table = $('#dtList').DataTable({
        dom: 'lTf<"html5buttons"B > gtip',
        buttons: [
            //'copy', 'csv', 'excel', 'pdf', 'print'
            'copy', 'excel'
        ],
        fixedHeader: true,
        scrollX: true,
        ordering: true,
        responsive: true,
        pageLength: 10,
        filter: true, // this is for disable filter (search box)
        //"orderMulti": false, // for disable multiple column at once
        data: data,
        columns: columns
    });

}

function init_datepicker() {
    var start = moment().startOf('month');
    var end = moment().endOf('month');

    function cb(start, end) {
        if (start.isSame(end)) {
            $('#daterange-tr01').html(uiHelpers.displayDate(start));
        } else {
            $('#daterange-tr01').html(uiHelpers.displayDate(start) + '-' + uiHelpers.displayDate(end));
        }
    }

    $('#daterange-tr01').daterangepicker({
        startDate: start,
        endDate: end,
        locale: {
            format: uiHelpers.dateFormat.DayMonthYear
        },
        ranges: datepicker_ranges_week,
        maxSpan: {
            'months': 1,
            'days':-1
        }
    }, cb);

    cb(start, end);
}

function isEmpty(obj) {
    for (var key in obj) {
        if (obj.hasOwnProperty(key))
            return false;
    }
    return true;
}

function internalDate(selectDate) {
    if (!selectDate) {
        selectDate = now();
    }
    var d = new Date(selectDate),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2)
        month = '0' + month;
    if (day.length < 2)
        day = '0' + day;
    return [year, month, day].join('-');
}

function SearchCriteria(criteria) {
    var request = getRequest();
    request.selectCriteria = criteria;
    DrawTableDetail(request);
    //drawChart(request);
}

function drawTable(request, loadPanel, column, postCall) {
    $(loadPanel).show();
    var jqxhr = $.post(postCall, request)
        .done(function (result) {
            if (table == null) {
                GenerateDatatable(result.data, column);
            }
            else {
                table.clear();
                $.each(result.data, function (idx, obj) {
                    table.row.add(result.data[idx]);
                });
                table.draw();
            }
        })
        .fail(function (e) {
            console.log(e);
        }).always(function () {
            $(loadPanel).hide();
        });
}

function generateGraph(controlID, serviceUrl, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, request, animationComplete, max_yaxis = null) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    //$(controlID + ' .report-container').append('<canvas id="chart" class="report-graph"></canvas>');
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    $.post(serviceUrl, request)
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                console.log('result');
                console.log(result);
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
                                        return value.substring(0,2);
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
                                stacked: true,
                                ticks: yTicks,
                                type: 'linear',
                                scaleLabel: {
                                    display: yLabel != null,
                                    labelString: yLabel
                                }
                                
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
                            text: graph_title,
                            fontSize: 16
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

function generateGraphNotStack(controlID, serviceUrl, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, request, animationComplete, max_yaxis = null) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .report-graph').remove();
    $(controlID + ' .report-title').text(report_title);
    $(controlID + ' .report-filename').val(graph_title.replace(/ /g, '_').replace(/:/g, ''));
    $(controlID + ' .report-container').append('<canvas class="report-graph"></canvas>');
    $.post(serviceUrl, request)
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
                        plugins: {
                            datalabels: {
                                color: 'black',
                                display: function (context) {
                                    return context.dataset.data[context.dataIndex] + '%';
                                },
                                font: {
                                    weight: 'bold'
                                },
                                formatter: function (value, context) {
                                    return value.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
                                }
                            }
                        },
                        scales: {
                            xAxes: [{
                                ticks: {
                                    autoSkip: false,
                                    callback: function (value, index, values) {
                                        return value.substring(0, 2);
                                    }
                                },
                                stacked: false,
                                gridLines: {
                                    display: false,
                                }
                                ,
                                scaleLabel: {
                                    display: xLabel != null,
                                    labelString: xLabel
                                }
                            }],
                            yAxes: [{
                                stacked: false,
                                ticks: yTicks,
                                type: 'linear',
                                scaleLabel: {
                                    display: yLabel != null,
                                    labelString: yLabel
                                }

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
                            text: graph_title,
                            fontSize: 16
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

function generateGraphKPI(controlID, result, graph_type, xLabel, yLabel, graph_title, report_title, legendPosition, graph_click, request, animationComplete, max_yaxis = null) {
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
                        }
                    }],
                    yAxes: [{
                        stacked: true,
                        ticks: yTicks,
                        type: 'linear',
                        scaleLabel: {
                            display: yLabel != null,
                            labelString: yLabel
                        }

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
                    text: graph_title,
                    fontSize: 16
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

function setBox(url) {
    showSummary();
    var jqxhr = $.post(url, getRequest())
        .done(function (result) {
            if (uiHelpers.errorHandler(result)) {
                var data = result.data;
                vm.setsummary(data);
            }
        })
        .fail(function (e) {
            console.log(e);
        }).always(function () {
            hideSummary();
        });
    return jqxhr;
}

function showSummary(){
    $('#Allsummary .section-loading').show();
}
function hideSummary() {
    $('#Allsummary .section-loading').hide();
}

function GetService() {
    var jqxhr = $.post("/ILB/GetServiceGroup")
        .done(function (result) {

            $('#cboService').empty();
            if (result.status) {
                $.each(result.data, function (index, item) {
                    $('#cboService').append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
                });

                $('#cboService').select2({
                    enableFiltering: true,
                    placeholder: "Business Unit",
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

function getRequest() {
    var serviceGroup = $('#cboService').select2('data').map(x => x.id);
    var startDate = new Date($('#daterange-tr01').data('daterangepicker').startDate._d);
    var endDate = new Date($('#daterange-tr01').data('daterangepicker').endDate._d);
    var selectCriteria = null;
    //var serviceGroup = document.getElementById('cboServiceGroup').value;
    var criteria = {
        selectStartDate: internalDate(startDate),
        selectEndDate: internalDate(endDate),
        selectServiceGroup: serviceGroup,
        selectCriteria: selectCriteria
    };
    return criteria;
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

function generateTable(controlID, serviceUrl, filter, title, column, created_row_callback, column_def = []) {
    $(controlID + ' .section-loading').show();
    $(controlID + ' .section-title').text(title);
    var jqxhr = $.post(serviceUrl, filter)
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
        })
        .fail(uiHelpers.postFailHandler)
        .always(function () {
            $(controlID + ' .section-loading').hide();
        });
    return jqxhr;
}