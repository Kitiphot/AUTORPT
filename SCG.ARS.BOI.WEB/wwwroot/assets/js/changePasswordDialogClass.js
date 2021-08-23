
class ChangePasswordDialogClass {
    constructor(controlID, changePasswordURL, changePasswordComplete_callback = null, setPassword = false) {
        this._element = $(controlID)[0];
        this.controlID = controlID;
        this.changePasswordComplete_callback = changePasswordComplete_callback;
        this.setPassword = setPassword;
        this.changePasswordURL = changePasswordURL;
        $(controlID + ' .btn-primary').on('click', this, function (e) {
            e.data.changePass();
        });
        $(controlID + ' .modal').on('hidden.bs.modal', function (e) {
            if ($(controlID + ' .modal').prop('force-change-password')) {
                $(controlID + ' .modal').modal('show');
            }
        })
    }

    // Functions
    openChangePass(username, forceChange = false) {
        $(this.controlID + ' .modal').prop('force-change-password', forceChange)
        $(this.controlID + ' .OldPassword').removeClass('is-invalid');
        $(this.controlID + ' .NewPassword').removeClass('is-invalid');
        $(this.controlID + ' .ConfirmNewPassword').removeClass('is-invalid');
        $(this.controlID + ' .OldPassword').prop('usr', username)
        $(this.controlID + ' .OldPassword').val('');
        $(this.controlID + ' .NewPassword').val('');
        $(this.controlID + ' .ConfirmNewPassword').val('');
        $(this.controlID + ' .section-loading').hide();
        $(this.controlID + ' .modal').modal('show');

        if (this.setPassword) {
            $(this.controlID + ' .modal-title').text('Set Password');
            $(this.controlID + ' .label-OldPassword').hide();
            $(this.controlID + ' .OldPassword').hide();
            $(this.controlID + ' .OldPassword-icon').hide();
        }
        else {
            $(this.controlID + ' .modal-title').text('Change Password');
            $(this.controlID + ' .label-OldPassword').show();
            $(this.controlID + ' .OldPassword').show();
            $(this.controlID + ' .OldPassword-icon').show();
        }

        if (forceChange) {
            $(this.controlID + ' .btn-secondary').hide();
        }
        else {
            $(this.controlID + ' .btn-secondary').show();
        }
    }

    getPasswordModel() {
        return {
            "Username": $(this.controlID + ' .OldPassword').prop('usr'),
            "OldPassword": $(this.controlID + ' .OldPassword').val(),
            "NewPassword": $(this.controlID + ' .NewPassword').val(),
            "SetPassword": this.setPassword,
        }
    }
    validatePassword() {
        var result = true;
        $(this.controlID + ' .NewPassword').removeClass('is-invalid');
        $(this.controlID + ' .ConfirmNewPassword').removeClass('is-invalid');
        
        if ($(this.controlID + ' .OldPassword').val() == '' && !this.setPassword) {
            $(this.controlID + ' .OldPassword').addClass('is-invalid');
            result = false;
        }
        if ($(this.controlID + ' .NewPassword').val() == '') {
            $(this.controlID + ' .NewPassword').addClass('is-invalid');
            result = false;
        }
        if ($(this.controlID + ' .ConfirmNewPassword').val() == '') {
            $(this.controlID + ' .ConfirmNewPassword').addClass('is-invalid');
            result = false;
        }

        if (!result) {
            toastr["error"]('Please input mandatory field.');
        }

        if ($(this.controlID + ' .NewPassword').val() != $(this.controlID + ' .ConfirmNewPassword').val()) {
            $(this.controlID + ' .NewPassword').addClass('is-invalid');
            $(this.controlID + ' .ConfirmNewPassword').addClass('is-invalid');
            toastr["error"]('Those passwords didn\'t match. Try again.');
            result = false;
        }
        return result;
    }

    changePass() {
        if (this.validatePassword()) {
            $(this.controlID + ' .section-loading').show();
            self = this;
            var jqxhr = $.post(self.changePasswordURL, this.getPasswordModel())
                .done(function (result) {
                    if (uiHelpers.errorHandler(result)) {
                        toastr["success"]('Change password complete.');
                        if ($(self.controlID + ' .modal').prop('force-change-password')) {
                            $(self.controlID + ' .modal').prop('force-change-password', false);
                        }
                        $(self.controlID + ' .modal').modal('hide');
                        if (self.changePasswordComplete_callback != null && typeof changePasswordComplete_callback === "function")
                            self.changePasswordComplete_callback();
                    }
                })
                .fail(uiHelpers.postFailHandler)
                .always(function () {
                    $(self.controlID + ' .section-loading').hide();
                });
        }
        else {
        }
    }
}