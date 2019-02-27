-- Enter your factors into the table below
local factors = {
    3,
    5
}

-- Enter here your words to be displayed when a factor appears.
-- Write the words in the same order of the factors table
local factorWords = {
    "Fizz",
    "Buzz"
}

-- The highest number that we should go to
local maxNumber = 100

for i=1, maxNumber do
    local output = ""

    -- Test for the factors and apply the words that are needed
    for i2=1, #factors do
        if i % factors[i2] == 0 then
            output = output .. factorWords[i2]
        end
    end

    -- Check if there are no factors found for this number
    if output == "" then
        output = i
    end

    -- Print our final output
    print(output)
end
