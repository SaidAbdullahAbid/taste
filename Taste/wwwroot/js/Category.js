var dataTable;
$(document).ready(function(){
    LoadList();
})
function LoadList() {
    dataTable = $("#Dt_load").DataTable({
        "ajax": {
            "url": "/api/Category",
            "type": "GET",
            "datatype" : "json"
        },
        "columns": [
            {"data" : "name", "width" : "40%"},
            {"data" : "displayOrder", "width" : "40%"},
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
						<a href = "/Admin/Category/Upsert?id=${data} " class= "btn btn-success">
							<i class="fas fa-edit"></i>
							Update
							</a>
						<a  class= "btn btn-danger" onClick=onDelete('api/Category/'+${data})>
							<i class="fas fa-trash-alt"></i>
							Delete
						</a>

					</div>`;
                }, "width" : "30%"
            },
        ],
        "language": {
            "emptyTable" : "Sorry, there is no data to display"
        },
        "width" : "100%"
    })
}
function onDelete(urlString) {
    
    swal({
        title: "Are you sure want to delete?",
        text: "You will not able to retore this data again",
        icon: "warning",
        dangerMode: true,
        buttons: true 
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: "/" + urlString,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr["error"](data.message);
                        toastr.options = {
                            "closeButton": false,
                            "debug": true,
                            "newestOnTop": true,
                            "progressBar": true,
                            "positionClass": "toast-top-right",
                            "preventDuplicates": true,
                            "showDuration": "300",
                            "hideDuration": "1000",
                            "timeOut": "5000",
                            "extendedTimeOut": "1000",
                            "showEasing": "swing",
                            "hideEasing": "linear",
                            "showMethod": "fadeIn",
                            "hideMethod": "fadeOut"
                        }
                    }
            }
            })
        }
    });
}