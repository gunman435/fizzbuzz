<?php
    // Enter your factors into the array below
    $factors = array(
        3,
        5
    );

    // Enter here your words to be displayed when a factor appears.
    // Write the words in the same order of the factors array
    $factorWords = array(
        "Fizz",
        "Buzz"
    );

    // The highest number that we should go to
    $maxNumber = 100;

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
?>
