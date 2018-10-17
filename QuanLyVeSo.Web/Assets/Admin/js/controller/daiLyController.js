var account = {
    init: function () {
        account.changeStatus();
        account.deleteRow();
    },
    changeStatus: function () {
        $('.btn-change-status').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);

            var id = btn.data('id');

            bootbox.confirm({
                message: btn.text() === 'Khóa' ? 'Bạn muốn kích hoạt đại lý này?' : 'Bạn muốn khóa đại lý này?',
                size: 'small',
                title: 'Thông báo',
                callback: function (result) {
                    if (result) {
                        $.ajax({
                            type: "POST",
                            url: '/Admin/DaiLy/ChangeStatus',
                            data: { id: id },
                            dataType: 'json',
                            success: function (respone) {
                                if (respone === true) {
                                    btn.attr('class', 'label label-success');
                                    btn.text('Kích hoạt');
                                } else {
                                    btn.attr('class', 'label label-danger');
                                    btn.text('Khóa');
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
    },
    deleteRow: function () {
        $('.btn-delete').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);

            var id = btn.data('id');

            bootbox.confirm({
                message: 'Bạn muốn xóa đại lý này?',
                size: 'small',
                title: 'Thông báo',
                callback: function (result) {
                    if (result) {
                        $.ajax({
                            type: "POST",
                            url: '/Admin/DaiLy/Delete',
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


















