// Default variables. Don't edit these
var factors = [3, 5];
var factorWords = ["Fizz", "Buzz"];
var maxNumber = 100;

function GetFizzBuzzData()
{
    // Make the variables JSON serializable
    var factorsJSON = JSON.stringify(factors);
    var factorWordsJSON = JSON.stringify(factorWords);

    // Create a POST request to the PHP to get the data back
    $.post("get-fizzbuzz-data.php", {
        factorJSON: factorsJSON,
        factorWordJSON: factorWordsJSON,
        maxNum: maxNumber
    }, function(data, status)
    {
        // If it failed then ignore it
        if (status != "success")
            return;

        // Update the data box
        $("#fizzbuzz-data").html(data);
    })
}

function FizzBuzz()
{
    // Update the variables
    factors = $("#factorsInput").val().split(",");
    factorWords = $("#factorWordsInput").val().toString().split(",");
    maxNumber = parseInt($("#maxNumberInput").val());

    // Get the data
    GetFizzBuzzData();
}