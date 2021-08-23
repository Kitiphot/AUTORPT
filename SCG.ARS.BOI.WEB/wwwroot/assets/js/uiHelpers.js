uiHelpers = {
    dateFormat: {
        DayMonthYear: "DD/MM/YYYY",
        DayMonthYearWithTime: "DD/MM/YYYY HH:mm:ss",
        DayMonthYearWithTimeNoSec: "DD/MM/YYYY HH:mm",
        MonthShortNameYear: "MMM YYYY",
        DayMonthNameYear: "D MMMM YYYY",
        MonthName: "MMMM",
        Year: "YYYY",
        MonthNameYear: "MMMM YYYY",

        MonthShortNameYearForDatePicker: "M yyyy",

        DayMonthYearForDatePicker: "dd/mm/yyyy",
        DayForDatePicker: "dd",
    },
    momentThai: function () {
        moment.locale('th', {
            months: ["มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน",
                "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม",
                "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"]
        });
    },

    //format
    displayDate: function (date) {
        uiHelpers.momentThai();
        return date == null ? "" : moment(new Date(date)).format(uiHelpers.dateFormat.DayMonthYear);
    },
    displayDateTime: function (date) {
        uiHelpers.momentThai();
        return date == null ? "" : moment(new Date(date)).format(uiHelpers.dateFormat.DayMonthYearWithTime);
    },
    displayDateTimeNoSec: function (date) {
        uiHelpers.momentThai();
        return date == null ? "" : moment(new Date(date)).format(uiHelpers.dateFormat.DayMonthYearWithTimeNoSec);
    },
    displayMonthYear: function (date) {
        uiHelpers.momentThai();
        return date == null ? "" : moment(new Date(date)).format(uiHelpers.dateFormat.MonthShortNameYear);
    },
    displayFullDate: function (date) {
        uiHelpers.momentThai();
        return date == null ? "" : moment(new Date(date)).format(uiHelpers.dateFormat.DayMonthNameYear);
    },
    displayFullMonth: function (date) {
        uiHelpers.momentThai();
        return date == null ? "" : moment(new Date(date)).format(uiHelpers.dateFormat.MonthName);
    },
    displayFullYear: function (date) {
        uiHelpers.momentThai();
        return date == null ? "" : moment(new Date(date)).format(uiHelpers.dateFormat.Year);
    },
    displayFullMonthYear: function (date) {
        uiHelpers.momentThai();
        return date == null ? "" : moment(new Date(date)).format(uiHelpers.dateFormat.MonthNameYear);
    },
    displayInteger: function (data) {
        return data == null ? "-" : data.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,');
    },
    displayDecimal: function (data, precision) {
        return data == null ? "-" : data.toFixed(precision).toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,');
    },
    displayN1: function (data) {
        return uiHelpers.displayDecimal(data, 1);
    },
    displayN2: function (data) {
        return uiHelpers.displayDecimal(data, 2);
    },
    displayN3: function (data) {
        return uiHelpers.displayDecimal(data, 3);
    },

    //for datatable
    renderInteger: function (data, type, row, meta) {
        return uiHelpers.displayInteger(data);
    },
    renderPercent: function (data, type, row, meta) {
        return uiHelpers.displayN2(data) + '%';
    },

    renderN1: function (data, type, row, meta) {
        return uiHelpers.displayN1(data);
    },
    renderN2: function (data, type, row, meta) {
        return uiHelpers.displayN2(data);
    },
    renderDate: function (data, type, row, meta) {
        return uiHelpers.displayDate(data);
    },
    renderDateTime: function (data, type, row, meta) {
        return uiHelpers.displayDateTime(data);
    },
    renderDateTimeNoSec: function (data, type, row, meta) {
        return uiHelpers.displayDateTimeNoSec(data);
    },

    initMonthYearpicker: function (controlID) {
        return $(controlID).datepicker({
            format: uiHelpers.dateFormat.MonthShortNameYearForDatePicker,
            startView: "months",
            minViewMode: "months",
            autoclose: true,
        }).datepicker("setDate", new Date());
    },

    initDaypicker: function (controlID, startDate, endDate) {
        return $(controlID).datepicker({
            format: uiHelpers.dateFormat.DayForDatePicker,
            startView: "days",
            minViewMode: "days",
            startDate: startDate,
            endDate: endDate,
            autoclose: true,
        }).datepicker("setDate", new Date());
    },

    initDatepicker: function (controlID, startDate, endDate) {
        return $(controlID).datepicker({
            format: uiHelpers.dateFormat.DayMonthYearForDatePicker,
            startView: "days",
            minViewMode: "days",
            startDate: startDate,
            endDate: endDate,
            autoclose: true,
        }).datepicker("setDate", new Date());
    },

    resetCombo: function (controlID, placeholder, allowClear = true) {
        $(controlID).empty();

        $(controlID).select2({
            enableFiltering: true,
            placeholder: placeholder,
            allowClear: allowClear
        });
    },
    addComboOption: function (controlID, result) {
        var specialCombo = false;
        if (result.status || result.success) {
            if ($(controlID).attr('multiple') == null)
                $(controlID).append($('<option>'));
            $.each(result.data, function (index, item) {
                if (item.isSubItem) {
                    specialCombo = true;
                    $(controlID).append($('<option data-parent-key="' + item.parentKey + '" data-parent-text="' + item.parentText + '">').html('<span>&nbsp;&nbsp;&nbsp;' + item.dataDisplay + '</span>').attr('value', item.dataValue_Key));
                }
                else if (item.json) {
                    specialCombo = true;
                    $(controlID).append($('<option data-raw="' + item.json.replace(/"/g, '\'') + '">').text(item.dataDisplay).attr('value', item.dataValue_Key));
                }
                else
                    $(controlID).append($('<option>').text(item.dataDisplay).attr('value', item.dataValue_Key));
            });
        } else {
            toastr["error"](result.message);
        }
        return specialCombo;
    },
    initCombo: function (controlID, serviceURLOrData, criteria, placeholder, allowClear = true) {
        this.resetCombo(controlID, placeholder);
        if (Array.isArray(serviceURLOrData)) {
            var result = { success: true, data: serviceURLOrData };
            if (uiHelpers.addComboOption(controlID, result)) {
                $(controlID).select2("destroy");

                $(controlID).select2({
                    enableFiltering: true,
                    placeholder: placeholder,
                    allowClear: allowClear,
                    templateSelection: function formatState(state) {
                        var regionName = $(state.element).attr('data-parent-text');
                        if (regionName != null)
                            return regionName.replace('ภาค', '') + ' > ' + state.text.trim();
                        else
                            return state.text;
                    }
                });
            }
            return Promise.resolve();
        }
        else {
            return $.post(serviceURLOrData, criteria)
                .done(function (result) {
                    if (uiHelpers.addComboOption(controlID, result)) {
                        $(controlID).select2("destroy");

                        $(controlID).select2({
                            enableFiltering: true,
                            placeholder: placeholder,
                            allowClear: allowClear,
                            templateSelection: function formatState(state) {
                                var regionName = $(state.element).attr('data-parent-text');
                                if (regionName != null)
                                    return regionName.replace('ภาค', '') + ' > ' + state.text.trim();
                                else
                                    return state.text;
                            }
                        });
                    }
                })
                .fail(uiHelpers.postFailHandler);
        }
    },


    init_datepicker_criteria() {
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
    },

    getComboAjax: function (controlID, URL, placeholder, criteria) {
        $(controlID).select2({
            placeholder: placeholder,
            allowClear: true,
            //multiple: true,
            ajax: {
                url: URL,
                type: 'post',
                datatype: 'json',
                data: function (params) {
                    return {
                        customer: params.term, // search term
                        page: params.page
                    };
                },
                processResults: function (result, params) {
                    params.page = params.page || 1;
                    result.data = result.data.map(item => ({ id: item.dataValue_Key, text: item.dataDisplay }));
                    console.log(result);
                    return {
                        results: result.data,
                        pagination: {
                            more: (params.page * 10) < result.data_count
                        }
                    };
                },
            },
            minimumInputLength: 3
        });
        return Promise.resolve();
    },

    setSelectedCriteria: function (controlID, URL, criteria) {

        var select = $(controlID);

        if (select.length === 0)
            return;

        if (criteria != null && criteria != '' && criteria != []) {
            $.ajax({
                type: 'post',
                url: URL,
                dataType: 'json',
                data: {
                    customerCode: criteria
                }
            }).then(function (data) {

                $.each(data.data, function (index, value) {
                    var option = new Option(value.dataDisplay, value.dataValue_Key, true, true);
                    select.append(option).trigger('change.select2');
                    select.trigger({
                        type: 'select2:select',
                        params: {
                            data: value.dataValue_Key
                        }
                    });
                });

            });
        }
    },

    initCustomer: function (controlID, warehouse, placeholder = 'Select customer') {
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetCustomer", { selectwarehouse: warehouse }, placeholder);
        //var jqxhr = $.post("/Report/GetCustomer", { selectwarehouse: warehouse })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },
    initCustomerTransport: function (controlID, placeholder = 'Select customer', customer = []) {
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetCustomerTransport", { selectCustomer: customer }, placeholder);
        //var jqxhr = $.post("/Report/GetCustomer", { selectwarehouse: warehouse })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },

    initCustomerTransportAjax: function (controlID, placeholder = 'Select customer', customer = []) {
        this.resetCombo(controlID, placeholder);
        return this.getComboAjax(controlID, "/Report/GetCustomerTransport", placeholder, customer);
        //return this.initCombo(controlID, "/Report/GetCustomerTransport", { selectCustomer: customer }, placeholder);
        //var jqxhr = $.post("/Report/GetCustomer", { selectwarehouse: warehouse })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqx;
    },

    initBusiness: function (controlID, business_group = [], mat_freight = [], fleet = [], shipping_point = [], region = []) {
        var placeholder = "Select a Business";
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetBusiness", { selectBusiness: business_group, selectMatfreight: mat_freight, selectFleet: fleet, selectShippingpoint: shipping_point, selectRegion: region }, placeholder);
        //var jqxhr = $.post("/Report/GetBusiness", { selectBusiness: business_group })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },

    initFleet: function (controlID, fleet_id = [], fleet_name = [], business = [], mat_freight = [], shipping_point = [], region = []) {
        var placeholder = "Select a Fleet";
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetFleet", { selectFleet: fleet_id, selectBusiness: business, selectMatfreight: mat_freight, selectShippingpoint: shipping_point, selectRegion: region }, placeholder);
        //var jqxhr = $.post("/Report/GetFleet", { selectFleet: fleet_id })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },

    initShippingPoint: function (controlID, shipping_point_code = [], shipping_point_name = [], business = [], fleet = [], mat_freight = [], region = []) {
        var placeholder = "Select a Shipping point";
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetShippingPoint", { selectShippingpoint: shipping_point_code, selectBusiness: business, selectFleet: fleet, selectMatfreight: mat_freight, selectRegion: region }, placeholder);
        //var jqxhr = $.post("/Report/GetShippingPoint", { selectShippingPointCode: shipping_point_code })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },

    initShiptoRegion: function (controlID, region_code = [], region_name = [], business = [], fleet = [], mat_freight = [], shipping_point = [], placeholder = "Select a Shipto region") {
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetShiptoRegion", { selectRegion: region_code, selectBusiness: business, selectFleet: fleet, selectMatfreight: mat_freight, selectShippingpoint: shipping_point }, placeholder);
        //var jqxhr = $.post("/Report/GetShiptoRegion", { selectRegionCode: region_code })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },

    initMatfrg: function (controlID, mat_freight_code = [], mat_freight_name = [], business = [], fleet = [], shipping_point = [], region = []) {
        var placeholder = "Select a Mat freight";
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetMatfrg", { selectMatfreight: mat_freight_code, selectBusiness: business, selectFleet: fleet, selectShippingpoint: shipping_point, selectRegion: region }, placeholder);
        //var jqxhr = $.post("/Report/GetMatfrg", { selectShippingPointCode: shipping_point_code })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },

    initOrderType: function (controlID, order_type_name = []) {
        var placeholder = "Select a Order type";
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetOrderType", { selectOrderTypeName: order_type_name }, placeholder);
        //var jqxhr = $.post("/Report/GetOrderType", { selectOrderTypeName: order_type_name })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },


    initTruckType: function (controlID, equipment_type_code = []) {
        var placeholder = "Select a Truck type";
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetTruckType", { selectEquipmentTypeCode: equipment_type_code }, placeholder);
        //var jqxhr = $.post("/Report/GetTruckType", { selectEquipmentTypeCode: equipment_type_code })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },


    initPlannerName: function (controlID, planner_name = []) {
        var placeholder = "Select a Planner name";
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetPlannerName", { selectPlannerName: planner_name }, placeholder);
        //var jqxhr = $.post("/Report/GetPlannerName", { selectPlannerName: planner_name })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },

    initOrderPlannerName: function (controlID, planner_name = []) {
        var placeholder = "Select a Planner name";
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Report/GetOrderPlannerName", { selectPlannerName: planner_name }, placeholder);
        //var jqxhr = $.post("/Report/GetPlannerName", { selectPlannerName: planner_name })
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },


    initCarrier: function (controlID, placeholder = "Delivery By") {
        this.resetCombo(controlID, placeholder);
        return this.initCombo(controlID, "/Transportation/Carrier", null, placeholder);
        //var jqxhr = $.post("/Transportation/Carrier")
        //    .done(function (result) {
        //        uiHelpers.addComboOption(controlID, result);
        //    })
        //    .fail(uiHelpers.postFailHandler);
        //return jqxhr;
    },

    errorHandler: function (result) {
        if (result !== null && !result.success) {
            if (result.data != undefined) {
                toastr.error(result.data, null, { enableHtml: true });
            }
            return false;
        }
        return true;
    },

    postFailHandler: function (xhr, status, error) {
        if (status == 'abort') return;

        if (error == null || error == '') {
            if (xhr.status == '401')
                toastr.error('User has no permission to perform request operation.', null, { enableHtml: true });
            else
                toastr.error('Fail to retrieve data.' + xhr.status, null, { enableHtml: true });
        }
        else
            toastr.error(error, null, { enableHtml: true });
    },
    downloadPDF: function (canvasID, filename, options = null) {
        var defaultOptions = {
            orientation: 'landscape',
            unit: 'in',
            format: 'a4',
            putOnlyUsedFonts: true
        };
        options = { ...defaultOptions, ...options };
        var canvas = [];
        if (Array.isArray(canvasID)) {
            canvasID.forEach(function (cv, index, array) {
                canvas.push(document.querySelector(cv));
            });
        }
        else
            canvas = [document.querySelector(canvasID)];
        var _file = document.getElementById(filename);
        if (_file != null)
            filename = _file.innerText;
        uiHelpers._downloadPDF(canvas, filename, options);
    },
    _downloadPDF: function (canvas, filename, options = null) {
        var defaultOptions = {
            orientation: 'landscape',
            unit: 'in',
            format: 'a4',
            putOnlyUsedFonts: true
        };
        options = { ...defaultOptions, ...options };

        var dpi = 75, a4 = { width: 8.3, height: 11.7 }, padding = 30, report_title_top_padding = 40;
        //creates PDF from img
        var doc = new jsPDF(options);

        var max_width, max_height;
        if (options.orientation == 'landscape') {
            max_width = a4.height * dpi - padding;
            max_height = a4.width * dpi - padding;
        }
        else {
            max_width = a4.width * dpi - padding;
            max_height = a4.height * dpi - padding;
        }

        if (!Array.isArray(canvas)) {
            canvas = [canvas];
        }

        if (options != null && options.reportTitle != null) {
            try {
                doc.setFont('THSarabun');
                doc.text(padding / 2 / dpi, report_title_top_padding / 2 / dpi, options.reportTitle);
                //$(canvas.parentElement.parentElement.parentElement.parentElement.parentElement).find('.report-title').text());
            }
            catch (e) {
                console.log(e);
            }
        }

        var offset = 0;
        canvas.forEach(function (cv, index, array) {
            //create image from dummy canvas
            var img = cv.toDataURL("image/png", 1.0);
            var ratio = 1;
            //if (cv.width > max_width)
            ratio = cv.width / max_width;

            if (/*cv.height > max_height &&*/ cv.height / max_height > ratio)
                ratio = cv.height / max_height;

            if (options.orientation == 'landscape') {
                if (offset + (padding / 2 / dpi) + (cv.height / ratio / dpi) > a4.width) {
                    doc.addPage();
                    offset = 0;
                }
            }
            else {
                if (offset + (padding / 2 / dpi) + (cv.height / ratio / dpi) > a4.height) {
                    doc.addPage();
                    offset = 0;
                }
            }
            doc.addImage(img, 'PNG', padding / 2 / dpi, padding / 2 / dpi + offset, cv.width / ratio / dpi, cv.height / ratio / dpi);
            offset = offset + (padding / 2 / dpi) + (cv.height / ratio / dpi);
        });
        doc.save(filename);
    },
    setAsDefaultCriteria: function (screenID, index, callback) {
        var jqxhr = $.post('/Security/SetDefaultCriteria', { "screenId": screenID, "index": index });
        return jqxhr.done(function (result) {
            if (callback != null && typeof callback === "function")
                callback();
        })
            .fail(uiHelpers.postFailHandler);
    },
    removeCriteria: function (screenID, index, callback) {
        var jqxhr = $.post('/Security/DeleteCriteria', { "screenId": screenID, "index": index });
        return jqxhr.done(function (result) {
            if (callback != null && typeof callback === "function")
                callback();
        })
            .fail(uiHelpers.postFailHandler);
    },
    getCriteriaFromDB: function (screenID) {
        var jqxhr = $.post('/Security/ListSearchCriteria', { "screenId": screenID });
        return jqxhr.done(function (result) {
            var list = result.data;
            list.forEach(function (item) {
                item.criteria = JSON.parse(item.criteria);
            });
        });
    },
    getDefaultCriteriaFromDB: function (screenID) {
        var jqxhr = $.post('/Security/GetDefaultSearchCriteria', { "screenId": screenID });
        return jqxhr.done(function (result) {
            var item = result.data;
            if (item != null)
                item.criteria = JSON.parse(item.criteria);
        });
    },
    saveCriteriaToDB: function (list) {
        var jqxhr = $.post('/Security/SaveCriteria', { "allCriteria": list })
            .fail(uiHelpers.postFailHandler);
        return jqxhr;
    },
    saveCriteria: function (screenID, name, criteria, callback) {
        return uiHelpers.getCriteriaFromDB(screenID)
            .done(function (result) {
                var list = result.data;
                list.forEach(function (item) {
                    item.defaultCriteria = false;
                });
                list.push({ "screenId": screenID, "index": list.length + 1, "criteriaName": name, "criteria": criteria, "createdDate": new Date(), "defaultCriteria": true });
                if (list.length > 10) {
                    list.shift();
                }
                var cnt = 1;
                list.forEach(function (item) {
                    item.criteria = JSON.stringify(item.criteria);
                    item.index = cnt++;
                });
                uiHelpers.saveCriteriaToDB(list).always(() => {
                    if (callback != null && typeof callback === "function")
                        callback();
                });
            })
            .fail(uiHelpers.postFailHandler);
    },
    getDefaultCriteria: function (screenID) {
        return uiHelpers.getDefaultCriteriaFromDB(screenID);
    },
    initCriteria: function (screenID, button, setCriteriaFunction, criteriaFunction, searchFunction) {
        var ajax = uiHelpers.getCriteriaFromDB(screenID);
        ajax
            .done(function (result) {
                var list = result.data;
                $(button).empty();
                $(button).append('<div id="search-button" class="btn-group rounded-border dropup mt-4">' +
                    '<button type="button" class="btn btn-primary search-button">Submit</button>' +
                    '<button type="button" class="btn btn-primary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
                    '<span class="sr-only">Toggle Dropdown</span>' +
                    '</button>' +
                    '<div class="dropdown-menu dropdown-criteria">' +
                    '</div>' +
                    '</div>');

                if (searchFunction != null && typeof searchFunction === "function")
                    $(button + ' .search-button').on('click', searchFunction);

                $(button + ' .dropdown-menu').empty();
                var element = $('<a class="dropdown-item" href="#">Save criteria</a>');
                $(button + ' .dropdown-menu').append(element);
                element.on('click', function () {
                    var criteriaName = prompt("Please enter criteria alias name");
                    if (criteriaName == null) return;
                    if (criteriaName == '') {
                        toastr["warning"]('Criteria alias name is required');
                        return;
                    }
                    if (criteriaFunction != null && typeof criteriaFunction === "function") {
                        uiHelpers.saveCriteria(screenID, criteriaName, criteriaFunction(), function () {
                            uiHelpers.initCriteria(screenID, button, setCriteriaFunction, criteriaFunction, searchFunction);
                        });
                    }
                });

                var element = $('<div class="dropdown-divider"></div>');
                $(button + ' .dropdown-menu').append(element);

                list.forEach(function (item) {
                    var defaultElement;
                    if (item.defaultCriteria)
                        defaultElement = $('<i class="far fa-check-square default-criteria"></i>');
                    else
                        defaultElement = $('<i class="far fa-square default-criteria"></i>');
                    var linkElement = $('<a class="dropdown-item" href="#" style="display: flex; justify-content: space-between"></a>');
                    var deleteElement = $('<i class="far fa-trash-alt delete-criteria" title="Delete"></i>');
                    var criteriaNameElement = $('<span class="criteria-item">' + item.criteriaName + ' (' + uiHelpers.displayDateTimeNoSec(item.createdDate) + ')</span>');
                    var leftElement = $('<div></div>');
                    var rightElement = $('<div></div>');
                    leftElement.append(defaultElement);
                    leftElement.append('&nbsp;');
                    leftElement.append(criteriaNameElement);
                    rightElement.append('&nbsp;');
                    rightElement.append(deleteElement);

                    linkElement.append(leftElement);
                    linkElement.append(rightElement);
                    $(button + ' .dropdown-menu').append(linkElement);
                    defaultElement.on('click', function () {
                        if (setCriteriaFunction != null && typeof setCriteriaFunction === "function")
                            setCriteriaFunction(item);
                        $(button + ' .dropdown-menu').removeClass('fa-check-square');
                        $(button + ' .dropdown-menu').removeClass('fa-square');
                        $(button + ' .dropdown-menu').addClass('fa-square');
                        defaultElement.addClass('fa-check-square');
                        uiHelpers.setAsDefaultCriteria(screenID, item.index, function () {
                            uiHelpers.initCriteria(screenID, button, setCriteriaFunction, criteriaFunction, searchFunction);
                        });
                    });
                    criteriaNameElement.on('click', function () {
                        if (setCriteriaFunction != null && typeof setCriteriaFunction === "function")
                            setCriteriaFunction(item);
                        $(button + ' .dropdown-menu').removeClass('fa-check-square');
                        $(button + ' .dropdown-menu').removeClass('fa-square');
                        $(button + ' .dropdown-menu').addClass('fa-square');
                        defaultElement.addClass('fa-check-square');
                        uiHelpers.setAsDefaultCriteria(screenID, item.index, function () {
                            uiHelpers.initCriteria(screenID, button, setCriteriaFunction, criteriaFunction, searchFunction);
                        });
                    });
                    deleteElement.on('click', function () {
                        uiHelpers.removeCriteria(screenID, item.index, function () {
                            uiHelpers.initCriteria(screenID, button, setCriteriaFunction, criteriaFunction, searchFunction);
                        });
                    });
                });
            })
            .fail(uiHelpers.postFailHandler)
            .fail(function () {
                $(button).empty();
                $(button).append('<div id="search-button" class="btn-group rounded-border mt-4">' +
                    '<button type="button" class="btn btn-primary search-button">OK</button>' +
                    '<button type="button" class="btn btn-primary dropdown-toggle dropdown-toggle-split" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
                    '<span class="sr-only">Toggle Dropdown</span>' +
                    '</button>' +
                    '<div class="dropdown-menu dropdown-criteria">' +
                    '</div>' +
                    '</div>');

                if (searchFunction != null && typeof searchFunction === "function")
                    $(button + ' .search-button').on('click', searchFunction);
            });
        return ajax;
    }
}