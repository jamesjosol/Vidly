
$(document).ready(function () {
    var table = $("#customers").DataTable({
    ajax: {
        url: "/api/customers",
        dataSrc: ""
    },
    columns: [
        {
            data: "name",
            render: function (data, type, customer) {
                                return "<a href='/customers/details/" + customer.id + "' class='text-decoration-none'>" + customer.name + "</a>";
            }
        },
        {
            data: "membershipType.name"
        },
        {
            data: "id",
            render: function (data, type, customer) {
            return "<a href='/customers/edit/" + data + "' class='text-decoration-none btn btn-primary mx-2'><i class='far fa-pen-to-square'></i></a> " +
            "<button class='btn btn-danger js-delete' data-customer-id=" + data + "><i class='fas fa-trash-alt'></i></button>";
        },
        className: 'text-center'
        }
    ]
    });


$("#customers").on("click", ".js-delete", function () {

    var button = $(this);
    var row = button.closest('tr');
    var anchor = row.find('a');
    var name = anchor.text();

    bootbox.confirm({
        message: '<div class="text-center"><p class=""><i style="font-size: 4em;" class="fa fa-circle-exclamation text-danger"></i></p> <h5 style="margin-top:-2%; color: rgb(46, 46, 46)">Delete Customer</h5><p class="container">Are you sure you want to delete ' + name + '?</p></div>',
        buttons: {
            cancel: {
            label: '<i class="fa fa-times"></i> Cancel'
        },
        confirm: {
            label: '<i class="fa fa-check"></i> OK'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: "/api/customers/" + button.attr("data-customer-id"),
                    method: "DELETE",
                    success: function () {
                        const toast = new bootstrap.Toast($('#liveToast'));
                        $('.toast-body').text('Customer ' + name + ' has been deleted.');
                        toast.show()

                        table.row(button.parents("tr")).remove().draw();
                    }
                });
            }
        }
    });

    var column = table.column(1);
    column.addClass('text-center');
    $(".modal-footer").css("border-top", "none");
    });
});