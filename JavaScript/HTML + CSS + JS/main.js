// Default variables. Don't edit these
var factors = [3, 5];
var factorWords = ["Fizz", "Buzz"];
var maxNumber = 100;

function GetFizzBuzzData()
{
    // Setup the html
    var output = "<p id='data'>";
    
    for (var i = 1; i <= maxNumber; i++)
    {
        // Individual line variable
        var lineOutput = "";

        // Test for the factors and apply the words that are needed
        for (var i2 = 0; i2 < factors.length; i2++)
        {
            if (i % factors[i2] == 0)
                lineOutput += factorWords[i2];
        }

        // Check if there are no factors found for this number
        if (lineOutput == "")
            lineOutput = i;

        // Add a line break to the end of our line so it won't be one big mess or numbers
        lineOutput += "<br/>\n";

        // Add the line to the overall output
        output += lineOutput;
    }

    // Set the data box to the output
    $("#fizzbuzz-data").html(output + "</p>");
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