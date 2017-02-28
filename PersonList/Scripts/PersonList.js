//adds a new person textbox
function OnAddPerson() {
    $.ajax({
        cache: false,
        type: "POST",
        url: "/Person/AddPerson",
        data: $("#person-list-form").serialize(),
        success: function (partialView) {
            $("#persons-container").html(partialView);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert("error:" + errorThrown);
        },
        complete: function () {
        }
    });
};

function RemovePerson(index) {
    $("#remove_person_index").val(index);
    alert("index: " + $("#remove_person_index").val());
    $.ajax({
        cache: false,
        type: "POST",
        url: "/Person/RemovePerson",
        data: $("#person-list-form").serialize(),
        success: function (partialView) {
            $("#persons-container").html(partialView);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert("error:" + errorThrown);
        },
        complete: function () {
        }
    });
};