using hangman;
namespace ViewTest;

public class ViewTest
{
    [Fact]
    public void viewWord_test()
    {
        // Arrange
        string word = "hello";
        
        //Act
        string result = HandgameView.viewWord(word);
        
        // Assert 
        Assert.Equal(result, "#####"); 
        
    }

    // Vérifier si la lettre saisie est dans le mot
    [Fact]
    public void searchIfWordContainsThisLetter_test()
    {
        // Arrange
        string word = "hello";
        string h = "h";
        string a = "a";

        // Act
        


        // Assert 



    }

    // Mettre la lettre à la bonne place dans le mot
    [Fact]
    public void replaceBlankByGoodLetter_test()
    {

    }
    
    // Implémenter le score d'erreur
    [Fact]
    public void countNumberOfError_test()
    {

    }
}