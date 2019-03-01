<?php

/*
    Obtain the variables
*/

$factors = null;
$factorWords = null;
$maxNumber = null;

if (isset($_POST["factorJSON"]))
{
    $factors = json_decode($_POST["factorJSON"]);
}
else
{
    // Enter your factors into the array below
    // NOTE: This will only work upon loading the file for the first time
    $factors = array(
        3,
        5
    );
}

if (isset($_POST["factorWordJSON"]))
{
    $factorWords = json_decode($_POST["factorWordJSON"]);
}
else
{
    // Enter here your words to be displayed when a factor appears.
    // Write the words in the same order of the factors array
    // NOTE: This will only work upon loading the file for the first time
    $factorWords = array(
        "Fizz",
        "Buzz"
    );
}

if (isset($_POST["maxNum"]))
{
    $maxNumber = $_POST["maxNum"];
}
else
{
    // The highest number that we should go to
    // NOTE: This will only work upon loading the file for the first time
    $maxNumber = 100;
}

/*
    Output the data
*/

echo "<p id='data'>";

for ($i = 1; $i <= $maxNumber; $i++)
{
    $output = "";

    // Test for the factors and apply the words that are needed
    for ($i2 = 0; $i2 < count($factors); $i2++)
    {
        if ($i % $factors[$i2] == 0)
            $output = $output . $factorWords[$i2];
    }

    // Check if there are no factors found for this number
    if ($output == "")
        $output = $i;

    // Print our final output
    echo $output . "<br/>\n";
}

echo "</p>";