/**
 * Created by maaike on 12-5-2016.
 */

function addVacancy() {

    var request = $.ajax({
        type: "GET",
        url: '../Controller/addVacancy.php',
        data: "employerID=6" + "&function=" + $("#functie").val() + "&description=" + $("#description").val() +
        "&salary=" + $("#salary").val() + "&hours=" + $("#hours").val() + "&requirements=" + $("#requirements").val() +
        "&tags=" + $("#tags").val()
    });
    request.done(function () {
        $('#newVacModal').attr('aria-hidden', 'true');
        location.reload();
    });
    request.fail(function (jqXHR, textStatus) {
        alert("Request failed: " + textStatus);
    });

}