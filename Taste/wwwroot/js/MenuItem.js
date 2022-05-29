var dataTable;
$(document).ready(function(){
    LoadList();
})
function LoadList() {
    console.log("Alred");
    dataTable = $("#Dt_load").DataTable({
        "ajax": {
            "url": "/api/menuItem",
            "type": "GET",
            "datatype" : "json"
        },
        "columns": [
            {"data" : "name", "width" : "20%"},
            {"data" : "price", "width" : "15%"},
            {"data" : "category.name", "width" : "15%"},
            { "data": "foodType.name", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
						<a href = "/Admin/menuItem/Upsert?id=${data} " class= "btn btn-success">
							<i class="fas fa-edit"></i>
							Update
							</a>
						<a  class= "btn btn-danger" onClick=onDelete('api/menuItem/'+${data})>
							<i class="fas fa-trash-alt"></i>
							Delete
						</a>

					</div>`;
                }, "width" : "35%"
         },
        ],
        "language": {
            "emptyTable" : "Sorry, there is no data to display"
        },
        "width": "100%",
        "order" : [[2, "asc"]]
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
                        toastr.success(data.message);
                    }
            }
            })
        }
    });
}