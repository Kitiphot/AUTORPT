
class PermissionDialogClass {
    constructor(controlID, getPermissionURL, setPermissionURL, changePasswordComplete_callback = null) {
        this._element = $(controlID)[0];
        this.controlID = controlID;
        this.changePasswordComplete_callback = changePasswordComplete_callback;
        this.getPermissionURL = getPermissionURL;
        this.setPermissionURL = setPermissionURL;
        $(controlID + ' .btn-primary').on('click', this, function (e) {
            e.data.setPermission();
            return false;
        });
    }

    displayPermission(permission) {
        return permission.substring(3, permission.length);
    }

    getScreenCode(route) {
        return route.substring(route.lastIndexOf('/') + 1, route.length);
    }

    isCheckIcon(allow) {
        if (allow)
            return 'fa-check-square';
        else
            return 'fa-square';
    }
    openPermission(key) {
        var self = this;

        $(self.controlID + ' .section-loading').show();
        $(self.controlID + ' .permission-container').empty();
        $(self.controlID + ' .permission-container').prop('data-key', key);
        $(self.controlID + ' .modal').modal('show');

        var jqxhr = $.post(self.getPermissionURL, { "key": key })
            .done(function (result) {
                if (uiHelpers.errorHandler(result)) {
                    //generate permission tree
                    result.data.forEach(function (item, index, array) {
                        var itemElement = $('<li></li>');
                        //fake tree
                        itemElement.addClass('permission-item');
                        itemElement.addClass('padding-lvl-' + item.depth);

                        itemElement.prop('title', item.menuPath);
                        itemElement.prop('data-permission', item.menuName.toLowerCase());
                        //itemElement.prop('data-permission-path', item.menuPath.toLowerCase());
                        itemElement.attr('data-permission-path', item.menuPath.toLowerCase());

                        if (item.menuRoute != null && item.permission != null) {
                            var allow = '0';
                            if (item.allow)
                                allow = '1';

                            itemElement.addClass('permission-item-with-claim');
                            itemElement.prop('data-permission-claim-type', item.permission);
                            itemElement.prop('data-permission-claim-value', item.menuCode);
                            itemElement.prop('data-permission-allow', allow);

                            //check box
                            itemElement.append('<i class="far ' + self.isCheckIcon(item.allow) + '"></i>');
                            //permission name
                            itemElement.append(self.displayPermission(item.permission));
                        }
                        else {

                            itemElement.append('<i class="far fa-square"></i>');
                            itemElement.append(item.menuName);
                        }

                        $(self.controlID + ' .permission-container').append(itemElement);
                    });
                }
            })
            .fail(uiHelpers.postFailHandler)
            .always(function () {
                $(self.controlID + ' .tree-container').find('.permission-item').each(function (idx, element) {
                    $(element).on('click', function () {
                        self.toggleCheckBox(element);
                    });
                });
                self.setAllCheckbox();
                $(self.controlID + ' .section-loading').hide();
            });

        $(self.controlID + ' .permission-filter').unbind();
        $(self.controlID + ' .permission-filter').on('input', function () {
            if ($(self.controlID + ' .permission-filter').val() == '' || $(self.controlID + ' .permission-filter').val() == null) {
                $(self.controlID + ' .tree-container').find('.permission-item').show();
            }
            else {
                $(self.controlID + ' .tree-container').find('.permission-item').hide();
                $(self.controlID + ' .tree-container').find('.permission-item[data-permission-path*="' + $(self.controlID + ' .permission-filter').val().toLowerCase() + '"]').show();
            }
        });
    }

    setAllCheckbox() {
        var self = this;
        var allNode = $(self.controlID + ' .permission-item-with-claim');
        allNode.each(function (idx, child) {
            self.setParentCheckbox(child);
        });
    }

    setParentCheckbox(childElement) {
        var self = this;
        var currentPath = $(childElement).attr('data-permission-path');
        while (currentPath != null) {
            if (currentPath != null && currentPath != '') {
                var isAllCheck = true;
                $(self.controlID + ' .permission-item-with-claim[data-permission-path*="' + currentPath + '"]').each(function (idx, child) {
                    var childItem = $(child).find('.far');
                    if (childItem.hasClass('fa-square')) {
                        isAllCheck = false;
                    }
                });
                var parentItems = $(self.controlID + ' .permission-item[data-permission-path="' + currentPath + '"]');
                parentItems.each(function (idx, parentElement) {
                    var parentItem = $(parentElement);
                    if (!parentItem.hasClass('permission-item-with-claim')) {
                        self.setCheckboxStatus(parentItem.find('.far'), isAllCheck);
                    }
                });
            }
            if (currentPath.includes(' > '))
                currentPath = currentPath.substring(0, currentPath.lastIndexOf(' > '));
            else
                currentPath = null;
        }
    }

    toggleCheckBox(element) {
        var self = this;
        var doCheck = $(element).find('.fa-square').length == 1;
        //cascade check child node
        var parentPath = $(element).attr('data-permission-path');
        var currentPath = parentPath;
        var thisItem = $(element).find('.far');
        self.setCheckboxStatus(thisItem, doCheck);
        if (!$(element).hasClass('permission-item-with-claim')) {
            $(self.controlID + ' .permission-item[data-permission-path*="' + $(element).attr('data-permission-path') + '"]').each(function (idx, child) {
                var childItem = $(child).find('.far');
                self.setCheckboxStatus(childItem, doCheck);
            });
        }
        self.setParentCheckbox(element);
    }

    setCheckboxStatus(item, status) {
        if (status) {
            if (item.hasClass('fa-square')) {
                item.removeClass('fa-square');
                item.addClass('fa-check-square');
            }
        }
        else {
            if (item.hasClass('fa-check-square')) {
                item.addClass('fa-square');
                item.removeClass('fa-check-square');
            }
        }
    }

    setPermission() {
        self = this;
        $(self.controlID + ' .section-loading').show();
        var permission = {
            "key": $(self.controlID + ' .permission-container').prop('data-key'),
            "permissions": []
        };
        $('.permission-item-with-claim').each(function (idx, permElement) {
            var permItem = $(permElement);
            var isAllow = permItem.find('.fa-check-square').length;
            if (permItem.prop('data-permission-allow') != isAllow) {
                permission.permissions.push({
                    "claimType": permItem.prop('data-permission-claim-type'),
                    "claimValue": permItem.prop('data-permission-claim-value'),
                    "isAllow": isAllow
                });
            }
        });
        //no change
        if (permission.permissions.length == 0) {
            $(self.controlID + ' .modal').modal('hide');
            $(self.controlID + ' .section-loading').hide();
            toastr["success"]('Set permission complete.');
            if (self.changePasswordComplete_callback != null && typeof self.changePasswordComplete_callback === "function")
                self.changePasswordComplete_callback();
            return;
        }
        var jqxhr = $.post(self.setPermissionURL, permission)
            .done(function (result) {
                if (uiHelpers.errorHandler(result)) {
                    toastr["success"]('Set permission complete.');
                    if (self.changePasswordComplete_callback != null && typeof self.changePasswordComplete_callback === "function")
                        self.changePasswordComplete_callback();
                }
            })
            .fail(uiHelpers.postFailHandler)
            .always(function () {
                $(self.controlID + ' .modal').modal('hide');
                $(self.controlID + ' .section-loading').hide();
            });
    }
}