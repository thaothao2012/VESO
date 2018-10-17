var account = {
    init: function () {

        account.deleteRow();
    },
    deleteRow: function () {
        $('.btn-delete').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);

            var id = btn.data('id');

            bootbox.confirm({
                message: 'Bạn muốn xóa công nợ này?',
                size: 'small',
                title: 'Thông báo',
                callback: function (result) {
                    if (result) {
                        $.ajax({
                            type: "POST",
                            url: '/Admin/CongNo/Delete',
                            data: { id: id },
                            dataType: 'json',
                            success: function (respone) {
                                if (respone === true) {
                                    $('#row_' + id).remove();
                                }
                            },
                            failure: function (respone) {
                                alert('failure');
                            },
                            error: function (respone) {
                                alert('error');
                            }
                        });
                    }
                }
            });
        });
    }
};

account.init();