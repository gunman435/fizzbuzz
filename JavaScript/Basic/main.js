// Enter your factors in the array below
var factors = [
    3,
    5
];

// Enter here your words to be displayed when a factor appears.
// Write the words in the same order of the factors array
var factorWords = [
    "Fizz",
    "Buzz"
];

// The highest number that we should go to
var maxNumber = 100;

for (var i = 1; i <= maxNumber; i++)
{
    var output = "";

    // Test for the factors and apply the words that are needed
    for (var i2 = 0; i2 < factors.length; i2++)
    {
        if (i % factors[i2] == 0)
            output += factorWords[i2];
    }

    // Check if there are no factors found for this number
    if (output == "")
        output = i;

    // Print our final output
    console.log(output);
}
