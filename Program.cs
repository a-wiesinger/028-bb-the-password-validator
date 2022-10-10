// The Password Validator
// :: Object Tests ::
// :: Boss Battle 5/5 ::

using _028_bb_the_password_validator.Models;

Console.Title = "The Password Validator";

Console.Clear();

// Create instance of validator class
PasswordValidator validator = new PasswordValidator();

// Gather user input
Console.Write("Please enter your desired password: ");
string? desiredPassword = Console.ReadLine();

// Call to password validator through instance
validator.CheckPassword(desiredPassword);

// Receive response from PasswordValidator class
// Do it all again