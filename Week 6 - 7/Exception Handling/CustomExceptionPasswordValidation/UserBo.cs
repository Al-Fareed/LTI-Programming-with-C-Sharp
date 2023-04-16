using System;
public class UserBo
{
    public static void validatePassword(string password)
    {
        if(password.Length < 10 && password.Length >20 || (!password.Any(char.IsDigit)) || (!password.Any(c => !char.IsLetterOrDigit(c))))
            throw new WeakException("WeakPasswordException");
    }
}