// See https://aka.ms/new-console-template for more information

Console.WriteLine("BMI and Karoven Calculator\n");

// Get user input
Console.WriteLine("Please enter the following values for the user . . .\n");
Console.Write("Height in inches: ");
double heightInches = Convert.ToDouble(Console.ReadLine());

Console.Write("Weight in pounds: ");
double weightPounds = Convert.ToDouble(Console.ReadLine());

Console.Write("Age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Resting heart rate: ");
int restingHeartRate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("Results . . .\n");

// Convert height to meters
double heightMeters = heightInches * 0.0254;

// Convert weight to kilograms
double weightKilograms = weightPounds * 0.45359237;

// Square height in meters
double heightMetersSquared = heightMeters * heightMeters;

// Calculate BMI
double bmi = weightKilograms / heightMetersSquared;


// Determine BMI category
string category;

if (bmi < 18.5)
    category = "Underweight";
else if (bmi < 25)
    category = "Normal weight";
else if (bmi < 30)
    category = "Overweight";
else
    category = "Obesity";

Console.WriteLine($"Your BMI is: {bmi:F2} -- {category}\n");

Console.WriteLine("Exercise Intensity Heart Rates:");


// Step 1: Maximum Heart Rate
int mhr = 220 - age;

// Step 2: Heart Rate Reserve
int hrr = mhr - restingHeartRate;

Console.WriteLine("Intensity      Max Heart Rate\n");


// Loop from 50% to 95% increasing by 5%
for (int intensity = 50; intensity <= 95; intensity += 5)
{
    double intensityPercent = intensity / 100.0;

    // Step 3: Maximum Target Zone
    double mtz = hrr * intensityPercent;

    // Step 4: Target Training Zone
    double ttz = mtz + restingHeartRate;

    Console.WriteLine($"{intensity}%     --      {Math.Round(ttz)} ");
}
Console.WriteLine("");
Console.WriteLine("Please press any key to end the program.");
Console.ReadKey();