var myMap;
ymaps.ready(init);
function init() {
    var myMap = new ymaps.Map('map', {
        center: [55, 34],
        zoom: 10,
        controls: []
    });
}

$(document).ready(Ready);

function Ready() {
    $("#Search").keyup(SearchLines).click(SearchLines);
    $("#SearchList").bind("click focus change", function () {
        alert("User clicked on");
    });;
}

function SearchLines() {
    var Search = $(this).val(),
        List = $("#SearchList");

    var Data = null;
    $.ajax({
        type: "POST",
        url: "/API/SearchLines",
        data: { Search: Search },
        dataType: "json",
        timeout: 5000,
        async: false,
        success: function (data) {
            Data = data;
        },
        error: function () {
        }
    });

    List.empty();
    $.each(Data, function (i, v) {
        List.append('<option value="' + v.Value + '" label="' + v.Type + '">');
    });
}

function SearchBlocks() {
    var Search = $("#Search").val(),
        SearchResult = $("#SearchResult"),
        Block = $("#Templates .Block");

    var Data = null;
    $.ajax({
        type: "POST",
        url: "/API/SearchBlocks",
        data: { Search: Search },
        dataType: "json",
        timeout: 5000,
        async: false,
        success: function (data) {
            Data = data;
        },
        error: function () {
        }
    });
    
    SearchResult.empty();
    $.each(Data, function (i, v) {
        var BlockClone = Block.clone();

        BlockClone.find(".Name").text(v.Name);
        BlockClone.find(".Info.Category").text(v.Tags);
        BlockClone.find(".Info.Adress").text(v.Address);
        BlockClone.find(".Info.Time").text(v.WorkingHour);
        BlockClone.find(".Distance").text("");

        SearchResult.append(BlockClone);
    });
}