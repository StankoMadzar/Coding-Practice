string? passwordToCheck;

while(true)
{
	Console.WriteLine("Give me a password to check");
    passwordToCheck = Console.ReadLine();
    if (passwordToCheck == null)
        break;
	Console.WriteLine($"The password is {PasswordValidator.PasswordisGood(passwordToCheck)}");
}

public static class PasswordValidator {
    public static string PasswordisGood(string? passwordToCheck)
    {
        bool isValid = IsValidLength(passwordToCheck) 
            && HasUpperCaseLetter(passwordToCheck) 
            && HasLowercaseLetter(passwordToCheck) 
            && HasNumber(passwordToCheck) 
            && DoesNotContainLetterT(passwordToCheck) 
            && DoesNotContainAmpersand(passwordToCheck);

        return isValid switch
        {
            true => "Good",
            false => "Bad"
        };
    }

    private static bool DoesNotContainAmpersand(string passwordToCheck)
    {
        bool doesNotContainAmpersand = false;
        foreach (char letter in passwordToCheck)
        {
            if (letter == '&')
                return doesNotContainAmpersand;
        }
        return !doesNotContainAmpersand;
    }

    private static bool DoesNotContainLetterT(string passwordToCheck)
    {
        bool doesNotContainLetterT = false;
        foreach (char letter in passwordToCheck)
        {
            if (letter == 'T')
                return doesNotContainLetterT;
        }
        return !doesNotContainLetterT;
    }

    private static bool HasNumber(string passwordToCheck)
    {
        bool hasNumber = false;
        foreach (char letter in passwordToCheck)
        {
            if (hasNumber = char.IsNumber(letter))
                return hasNumber;
        }
        return hasNumber;
    }

    private static bool HasLowercaseLetter(string passwordToCheck)
    {
        bool hasLowercaseLetter = false;
        foreach (char letter in passwordToCheck)
        {
            if (hasLowercaseLetter = char.IsLower(letter))
                return hasLowercaseLetter;
        }
        return hasLowercaseLetter;
    }

    private static bool HasUpperCaseLetter(string passwordToCheck)
    {
        bool hasUppercaseLetter = false;
        foreach (char letter in passwordToCheck)
        {
            if (hasUppercaseLetter = char.IsUpper(letter))
                return hasUppercaseLetter;
        }
        return hasUppercaseLetter;
    }

    private static bool IsValidLength(string passwordToCheck)
    {
        int charCounter = 0;
        bool isValidLength = false;
        foreach (char letter in passwordToCheck)
        {
            charCounter++;   
        }
        return isValidLength = (charCounter <= 13 && charCounter >= 6);
    }
}

//int charCounter = 0;
//bool validLength = false;
//bool hasUppercaseLetter = false;
//bool hasLowercaseLetter = false;
//bool hasNumber = false;
//bool doesNotContainLetterT = false;
//bool doesNotContainAmpersand = false;

//if (passwordToCheck == null)
//    return "Bad";

//foreach (char letter in passwordToCheck)
//{
//    charCounter++;
//    validLength = (charCounter <= 13 && charCounter >= 6);
//    hasUppercaseLetter = char.IsUpper(letter);
//    hasLowercaseLetter = char.IsLower(letter);
//    hasNumber = char.IsNumber(letter);
//    doesNotContainLetterT = letter != 'T';
//    doesNotContainAmpersand = letter != '&';
//    Console.WriteLine(letter.ToString(), validLength, hasUppercaseLetter, hasLowercaseLetter, hasNumber, doesNotContainLetterT, doesNotContainAmpersand);
//}

//bool isValid = validLength && hasUppercaseLetter && hasLowercaseLetter && hasNumber && doesNotContainLetterT && doesNotContainAmpersand;

//return isValid switch
//{
//    true => "Good",
//    false => "Bad"
//};