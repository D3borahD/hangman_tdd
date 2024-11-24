namespace hangman;

public class HandgameView
{
    public static string viewWord(string unknowWord)
    {
        string result = "";

        int countOfLetter = unknowWord.Length;
        
        for(var i =0 ; i < countOfLetter; i++)
        {
            result += '#';
        }
     
        return result;
    }
}