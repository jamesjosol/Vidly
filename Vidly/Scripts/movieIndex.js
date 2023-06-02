$(document).ready(function () {
    var table = $("#movies").DataTable({
        ajax: {
            url: "/api/movies",
            dataSrc: ""
        },
        columns: [
            {
                data: "name",
                render: function (data, type, movie) {
                    return "<a href='/movies/details/" + movie.id + "' class='text-decoration-none'>" + movie.name + "</a>";
                }
            },
            {
                data: "genre.name"
            },
            {
                data: "id",
                render: function (data, type, movie) {
                    //return "<a href='/movies/edit/" + data + "' class='text-decoration-none btn btn-primary mx-2'><i class='far fa-pen-to-square'></i></a> " +
                    //    "<button class='btn btn-danger js-delete' data-movie-id=" + data + "><i class='fas fa-trash-alt'></i></button>";
                    return "<div class='flBtnCntr'>" +
                            "<button class='flBtnBox big'><i class='fas fa-gear'></i></button>" +
                            "<div class='flBtns'>" +
                                "<a href='/movies/edit/" + data + "' class='flBtnBox small text-decoration-none btn btn-primary mx-2'><i class='far fa-pen-to-square'></i></a>" +
                                "<button class='flBtnBox small btn btn-danger js-delete' data-movie-id=" + data + "><i class='fas fa-trash-alt'></i></button>" +
                            "</div>" +
                            "</div>";
                },
                className: 'tdFixedWidth'
            }
        ]
    });


    $("#movies").on("click", ".js-delete", function () {

        var button = $(this);
        var row = button.closest('tr');
        var anchor = row.find('a');
        var name = anchor.text();

        bootbox.confirm({
            message: '<div class="text-center"><p class=""><i style="font-size: 4em;" class="fa fa-circle-exclamation text-danger"></i></p> <h5 style="margin-top:-2%; color: rgb(46, 46, 46)">Delete Movie</h5><p class="container">Are you sure you want to delete ' + name + '?</p></div>',
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
                        url: "/api/movies/" + button.attr("data-movie-id"),
                        method: "DELETE",
                        success: function () {
                            const toast = new bootstrap.Toast($('#liveToast'));
                            $('.toast-body').text('Movie ' + name + ' has been deleted.');
                            toast.show()

                            table.row(button.parents("tr")).remove().draw();
                        },
                        error: function (xhr, status, error) {
                            console.log("failed Error: " + xhr.status + " message: " + error);
                        }
                    });
                }
            }
        });

        $(".modal-footer").css("border-top", "none");
    });
});