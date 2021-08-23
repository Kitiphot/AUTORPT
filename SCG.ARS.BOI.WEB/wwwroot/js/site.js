// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $('.selectpicker').selectpicker();
});


var datepicker_ranges = {
    'Today': [moment().startOf('day'), moment().startOf('day')],
    'Yesterday': [moment().subtract(1, 'days').startOf('day'), moment().subtract(1, 'days').startOf('day')],
    'Last 7 Days': [moment().subtract(6, 'days').startOf('day'), moment().startOf('day')],
    'Last 30 Days': [moment().subtract(29, 'days').startOf('day'), moment().startOf('day')],
    'This Month': [moment().startOf('month'), moment().endOf('month')],
    'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
}
var datepicker_ranges2 = {
    'Today': [moment().startOf('day'), moment().startOf('day')],
    'Yesterday': [moment().subtract(1, 'days').startOf('day'), moment().subtract(1, 'days').startOf('day')],
    'Last 7 Days': [moment().subtract(6, 'days').startOf('day'), moment().startOf('day')],
    'Last 30 Days': [moment().subtract(29, 'days').startOf('day'), moment().startOf('day')],
    'This Month': [moment().startOf('month'), moment().endOf('month')],
    'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
}
var datepicker_ranges_week = {
    'Today': [moment().startOf('day'), moment().startOf('day')],
    'Yesterday': [moment().subtract(1, 'days').startOf('day'), moment().subtract(1, 'days').startOf('day')],
    'Last 7 Days': [moment().subtract(6, 'days').startOf('day'), moment().startOf('day')],
}

function CalculateTime(startTime, panel) {
    //Calculate the difference in milliseconds.
    var time = performance.now() - startTime;

    //Convert milliseconds to seconds.
    var seconds = time / 1000;

    //Round to 3 decimal places.
    seconds = seconds.toFixed(3);

    //Write the result to the HTML document.
    var result = 'AJAX request took ' + seconds + ' seconds to complete.';
    panel.html(result);

    //Or log it to the console.
    console.log(result);
}
function GetDateDisplay() {
    var tmpStartDate = $('#daterange-99').data('daterangepicker').startDate._d;
    var tmpEndDate = $('#daterange-99').data('daterangepicker').endDate._d;
    var StartDate = tmpStartDate.getDate() + "/" + (tmpStartDate.getMonth() + 1) + "/" + tmpStartDate.getFullYear();
    var EndDate = tmpEndDate.getDate() + "/" + (tmpEndDate.getMonth() + 1) + "/" + tmpEndDate.getFullYear();
    DateDis = {
        StartDate: StartDate,
        EndDate: EndDate
    }
    return DateDis;
}

function addDays(date, days) {
    const copy = new Date(Number(date))
    copy.setDate(date.getDate() + days)
    return copy
}

$.fn.dataTable.render.ellipsis = function (cutoff) {
    return function (data, type, row) {
        return type === 'display' && data != null && data.length > cutoff ?
            '<span title="' + data + '">' + data.substr(0, cutoff) + ' &hellip;</span>' : data; // &hellip; = '...'
    }
};