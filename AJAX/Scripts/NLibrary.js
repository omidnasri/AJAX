$(document).ready(function() {
    $("[datetime-now]").click(function() {
        var model = "/Home/GetDateTime";
        $.get(model, {yourname:"omid nasri"}, function(data) {
            alert(data);
        });
    });
    $("[yourname-now]").click(function () {
        var model = "/Home/GetName";
        $.get(model, {yourname:"omid nasri"}, function (data) {
            alert(data);
        });
    });
    $("[getyear-now]").click(function () {
        var model = "/Home/GetYear";
        $.post(model, function (data) {
            alert(data);
        });
    });
    $("[getyear]").click(function () {
        var model = "/Home/GetYear";
        $.post(model, {year:"2015"}, function (data) {
            alert(data);
        });
    });
    $("[return-json]").click(function () {
        var model = "/Home/Json";
        $.post(model, function (data) {
            alert(data.name);
            alert(data.family);
        });
    });
});