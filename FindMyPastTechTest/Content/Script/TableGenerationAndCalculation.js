function GenerateNumbers() {
    var number = $('#NumberBox').val();

    $.ajax({
        type: "POST",
        url: "Generator/GenerateListOfNumbers",
        data: { 'NumberRequired': number },
        dataType: "json"
    })
    .done(function (data) {
        var list = data;
        $('#DisplayTable').empty();

        GenerateFirstLine(list);
        
        $.each(list, function (index, item) {
            GenerateAdditionalLines(item, list)
        });

        })
    .fail(function (xhr) {
        alert(xhr.responseText);
        });
};


function GenerateFirstLine(list) {
    var content = "<tr>"
    content += '<td></td>';
    $.each(list, function (index, item) {
        content += '<td>' + item + '</td>';
    });
    content += "</tr>"

    $('#DisplayTable').append(content);
};


function GenerateAdditionalLines(passedItem, list) {
    var content = "<tr>"
    content += '<td>' + passedItem + '</td>';

    $.each(list, function (index, item) {
        var result = passedItem * item;
        content += '<td>' + result + '</td>';
    });

    content += "</tr>"
    $('#DisplayTable').append(content);
}