$(function () {


    // Define form element
    const form = document.getElementById('frmModalManageVehicleModel');

    var validator = FormValidation.formValidation(
        form,
        {
            fields: {
                'MasterVehicleModel.VehicleBrandId': {
                    validators: {
                        notEmpty: {
                            message: 'ระบุยี่ห้อยานพาหนะ'
                        },
                        callback: {
                            message: 'ระบุยี่ห้อยานพาหนะ',
                            callback: function (input) {
                                if (input.value == '0') {
                                    return false;
                                }
                            }
                        }
                    }
                },
                'MasterVehicleModel.Name': {
                    validators: {
                        notEmpty: {
                            message: 'ระบุรุ่นยานพาหนะ'
                        }
                    }
                },
            },

            plugins: {
                trigger: new FormValidation.plugins.Trigger(),
                bootstrap: new FormValidation.plugins.Bootstrap5({
                    rowSelector: '.fv-row',
                    eleInvalidClass: 'is-invalid',
                    eleValidClass: 'valid'
                })
            }
        }
    );

    // Revalidate Select2 input. For more info, plase visit the official plugin site: https://select2.org/
    $(form.querySelector('[name="MasterVehicleModel.VehicleBrandId"]')).on('change', function () {
        // Revalidate the field when an option is chosen
        validator.revalidateField('MasterVehicleModel.VehicleBrandId');
    });

    // Submit button handler
    const submitButton = document.getElementById('btnModalManageVehicleModelSubmit');
    submitButton.addEventListener('click', function (e) {
        // Prevent default button action
        e.preventDefault();

        // Validate form before submit
        if (validator) {
            validator.validate().then(function (status) {
                console.log('validated!');

                if (status == 'Valid') {
                    // Show loading indication
                    submitButton.setAttribute('data-kt-indicator', 'on');

                    // Disable button to avoid multiple click
                    submitButton.disabled = true;

                    // Remove loading indication
                    submitButton.removeAttribute('data-kt-indicator');

                    // Enable button
                    submitButton.disabled = false;


                    //--Save
                    form.submit(function () {
                        showWait();
                        $.post($(this).attr('action'), $(this).serialize(), function (res) {

                            hideWait();

                            if (res.type == "success") {

                                Swal.fire({ title: 'บันทึกข้อมูลสำเร็จ', text: '', icon: 'success', confirmButtonText: 'ตกลง', confirmButtonColor: '#3B9EF8', })
                                    .then((result) => {
                                        if (result.isConfirmed) {
                                            $('.modal').modal('hide') // closes all active pop ups.
                                            $('.modal-backdrop').remove() // removes the grey overlay.
                                            $('#frmSearchManageVehicleModel').submit();
                                        }
                                    });
                            }
                            else {
                                Swal.fire({ title: res.message, text: '', icon: 'error', confirmButtonText: 'ตกลง', confirmButtonColor: '#3B9EF8', });
                            }


                        }, 'json');
                        return false; // important to have this
                    });
                    //--Save End.

                }
            });
        }
    });

    //--
});