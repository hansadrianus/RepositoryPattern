// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
async function GetOrderTypes() {
    await $.ajax({
        type: 'GET',
        url: '../Sales/GetOrderTypes',
        dataType: 'json',
        success: function (response) {
            $("#select_orderType").append("<option value='0'> - Select Order Type - </option>");

            for (var i = 0; i < response.data.length; i++) {
                var id = response.data[i]['id'];
                var name = response.data[i]['name'];

                $("#select_orderType").append("<option value='" + id + "'>" + name + "</option>");
            }
        }
    });
}

async function GetPaymentTypes() {
    await $.ajax({
        type: 'GET',
        url: '../Sales/GetPaymentTypes',
        dataType: 'json',
        success: function (response) {
            $("#select_paymentType").append("<option value='0'> - Select Payment Type - </option>");

            for (var i = 0; i < response.data.length; i++) {
                var id = response.data[i]['id'];
                var name = response.data[i]['name'];

                $("#select_paymentType").append("<option value='" + id + "'>" + name + "</option>");
            }
        }
    });
}

async function GetProducts() {
    const result = await $.ajax({
        type: 'GET',
        url: '../Sales/GetProducts',
        dataType: 'json',
    });
    result.data.unshift({
        "id": 0,
        "name": "Select Product"
    });
    var products = result.data;

    return products;
}

function GetSelectedProduct(id) {
    var product = {};
    $.ajax({
        type: "GET",
        url: '../Sales/GetProducts',
        data: { "id": id },
        dataType: "json",
        async: false,
        success: function (response) {
            product = response.data[0];
        }
    });

    return product;
}