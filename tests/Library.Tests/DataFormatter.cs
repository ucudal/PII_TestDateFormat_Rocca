namespace TestDateFormat;

public class DateFormatterTests
{
    [Test]
    public void CorrectFormat()
    {
        string date = "10/11/1997";
        string expected= "1997-11-10";
        string test = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(test,expected);
    }

    [Test]
    public void IncorrectFormat()
    {
        string date = "10/11-1997";
        string NotExpected= "1997-11-10";
        string test = DateFormatter.ChangeFormat(date);
        Assert.AreNotEqual(test, NotExpected);
    }

    [Test]
    public void Empty()
    {
        string date = "";
        string expected= "La fecha ingresada no es válida, el formato debe ser de la forma dd/mm/yyyy";
        string test = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(test, expected);
    }

}