namespace _028_bb_the_password_validator.Models;

public class PasswordValidator
{
    public void CheckPassword(string desiredPassword)
    {
        if (!IsReqLength(desiredPassword) || !MeetsCharReq(desiredPassword))
        {
            Console.WriteLine("Sorry. That's not a valid password.");
        }
        else
        {
            Console.WriteLine("Nice. Show me what you got!");
        }
    }

    private bool IsReqLength(string desiredPassword)
    {
        if (desiredPassword.Length >= 6 && desiredPassword.Length <= 13) return true;
        return false;
    }

    private bool MeetsCharReq(string desiredPassword)
    {
        bool hasUpper = false;
        bool hasLower = false;
        bool hasNumber = false;
        foreach (var letter in desiredPassword)
        {
            if (letter == 'T' || letter == '&') return false;
            
            if (char.IsUpper(letter)) hasUpper = true;
            if (char.IsLower(letter)) hasLower = true;
            if (char.IsNumber(letter)) hasNumber = true;
        }

        if (hasUpper && hasLower && hasNumber) return true;

        return false;
    }
}