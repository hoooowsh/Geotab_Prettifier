# Geotab_Prettifier

## Requirements
Write tested code (in any language) that accepts a numeric type and returns a truncated, "prettified" string version. The prettified version should include one number after the decimal when the truncated number is not an integer. It should prettify numbers greater than 6 digits and support millions, billions and trillions.

## Approach
At the beginning, I tried to solve it in a very simple way, like a LeetCode question, and it only took a couple of minutes. Then I started from there and expanded what I had. I used a basic OOP strategy, modified my code, and added some unit tests to it. I created a solution and attached two projects to it: one is a console app that contains my logic, and the other is an xUnit project for unit tests. For the console app, the main class is just some testing code that calls the logic class. My logic is implemented in the NumPrettifier.cs file. The NumRound.cs file is used to pick a rounding method.

## Concerns
1. I'm not sure how the question wants to round the number, so I implemented a helper rounder class, but I feel it's not necessary and adds more complexity to the project. Depending on the requirements, if only one rounding method is needed, I will remove the rounding helper class.
2. I should have more unit tests, but I spent too much time on the rounding method, so I only implemented a few.
3. I'm not sure what the number range is, so I used decimal. I might change it to double to save space if I know the range.
4. I also didn't write unit tests for my rounding method, because I feel I overthink it

## How to run
```
# Run simple test that will be print out in terminal
cd NumPrettifierApp
dotnet run
```

```
# Run unit tests
cd NumPrettifierTest
dotnet test
```