$('#ddlReservas').hide();
$(document).ready(function () {
    $(function () {
        var ddlCustomers = $("#ddlReservas");
        ddlCustomers.empty().append('<option selected="selected" value="0" disabled = "disabled">Loading.....</option>');
        $.ajax({
            type: "POST",
            url: "/HotelSurf/Simulador/FetchReservas",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                ddlCustomers.empty().append('<option selected="selected" value="0">Escolha uma Reserva</option>');
                var toAppend = '';
                $.each(response, function (i, o) {
                    toAppend += ('<option value="'
                        + o.ID + '">'
                        + o.ID + '</option>');
                });

                ddlCustomers.append(toAppend);

            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });

        $('#reservascbox').change(function () {
            if ($(this).prop("checked")) {
                $('#ddlReservas').show();
            } else {
                $('#ddlReservas').hide();
            }
        });

        $("#ddlReservas").change(function () {

            if ($("#ddlReservas").val() === "0") {
                $("#NumAdultos").val("");
                $("#NumCriancas").val("");
                $("#DatEntrada").val("");
                $("#DatSaida").val("");
                $("#NumBungalow").val("");
                $("#PrecoBungalow").val("");
            }

            $.ajax({
                type: 'POST',
                url: '/HotelSurf/Simulador/FetchReservasByID',
                dataType: 'json',
                data: { id: $("#ddlReservas").val() },
                success: function (a) {
                    $.each(a, function (i, a) {
                        //Convert Dates
                        var datentrada = a.DatEntrada;
                        var cdatentrada = new Date(parseInt(datentrada.replace(/(^.*\()|([+-].*$)/g, '')));
                        var cdateentrada = cdatentrada.toLocaleDateString();
                        var fdataentrada = cdateentrada.split("/").reverse().join("-");
                        var datsaida = a.DatSaida;
                        var cdatasaida = new Date(parseInt(datsaida.replace(/(^.*\()|([+-].*$)/g, '')));
                        var cdatesaida = cdatasaida.toLocaleDateString();
                        var fdatasaida = cdatesaida.split("/").reverse().join("-");
                        //End of convert
                        $("#NumAdultos").val(a.NumAdultos);
                        $("#NumCriancas").val(a.NumCriancas);
                        $("#DatEntrada").val(fdataentrada);
                        $("#DatSaida").val(fdatasaida);
                        //$("#NumBungalow").val(a.NumBungRes);
                        $("#PrecoBungalow").val(a.Bungalow.PrecoBung);

                        //$("#ddlNumAdultos").append('<option value="'
                        //    + a.Value + '">'
                        //    + a.Text + '</option>');

                    });
                },
                error: function (ex) {
                    alert('Failed.' + ex);
                }
            });
            return false;
        })
    });
    $("#calc").click(function () {
        var startDay = new Date($("#DatEntrada").val());
        var endDay = new Date($("#DatSaida").val());
        var millisecondsPerDay = 1000 * 60 * 60 * 24;
        var millisBetween = endDay.getTime() - startDay.getTime();
        var dias = millisBetween / millisecondsPerDay;
        var numAdultos = $("#NumAdultos").val();
        var numCriancas = $("#NumCriancas").val();
        var precoBungalow = $("#PrecoBungalow").val();
        var datEntrada = $("#DatEntrada").val();
        var mes = datEntrada.charAt(5) + datEntrada.charAt(6);
        var verao = precoBungalow * 1.25;
        var discMenor = verao * 0.75;
        var total;
        if (mes >= 6 && mes <= 8) {
            total = ((numAdultos * verao) + (numCriancas * discMenor)) * dias;
        } else {
            disc = precoBungalow * 0.75;
            total = ((numAdultos * precoBungalow) + (numCriancas * discMenor)) * dias;
        }

        $("#totalLbl").text(Math.floor(total) + "€");

    });
});