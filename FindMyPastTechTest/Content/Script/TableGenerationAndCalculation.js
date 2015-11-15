function GenerateNumbers() {
    var number = $('#NumberBox').val();
    
    //$.ajax({
    //    type: "GET",
    //    url: "http://localhost:5050/Generator/GenerateListOfNumbers",
    //    data: {'NumberRequired': number},
    //    success: function (data) {
    //        alert("stuff back :" + data[0])
    //    },
    //    error: function (jqXHR, textStatus) {
    //        alert("there has been an error :" + textStatus)
    //    }
    //});

    $.ajax({
        type: "POST",
        url: "Generator/GenerateListOfNumbers",
        data: { 'NumberRequired': number },
        dataType: "json"
    })
    .done(function (data) {
    var list = data;
    $.each(list, function (index, item) {
        alert(item);
        });
    })
    .fail(function (xhr) {
        alert(xhr.responseText);
    });
};
