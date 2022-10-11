// The Password Validator
// :: Object Tests ::
// :: Boss Battle 5/5 ::

using _028_bb_the_password_validator.Models;

Console.Title = "The Password Validator";

Console.Clear();

// Create instance of validator class
PasswordValidator validator = new PasswordValidator();

while (true)
{
    // Gather user input
    Console.Write("Please enter your desired password: ");
    string? desiredPassword = Console.ReadLine();
    
    if (desiredPassword == "exit") break; // Stop app via command line if desired

    // Call to password validator through instance
    validator.CheckPassword(desiredPassword);
}

