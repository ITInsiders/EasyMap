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
}

function AddPointToMap(object) {
    var objectMap = new ymaps.Placemark(object.position, {

    }, {

    });
    geoMap.geoObjects.add(objectMap);
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

        setTimeout(AddPointToMap(v), 0);

        var BlockClone = Block.clone(),
            BlockData = BlockClone.find(".Data");

        BlockData.find(".Name").text(v.Name);
        BlockData.find(".Info.Category").text(v.Tags);
        BlockData.find(".Info.Adress").text(v.Address);
        BlockData.find(".Info.Time").text(v.WorkingHour);
        BlockData.find(".Distance").text("");

        var position = [v.Longitude, v.Latitude];
        BlockData.data("position", JSON.stringify(position));

        var mainPhoto = null;

        $.each(v.photos, function (index, element) {
            if (element.Main) mainPhoto = element.SRC;
        });

        BlockClone.find(".Photo").css("background-image", "url(\"" + mainPhoto + "\")");

        SearchResult.append(BlockClone);
    });
}