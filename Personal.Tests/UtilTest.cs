using Moq;
using PersonalRegister;
using PersonalRegister.Helpers;

namespace Personal.Tests;

public class UtilTest
{
    [Fact]
    public void AskForString_ShouldReturnExpectedString()
    {
        //Arrange
        const string expected = "some value";
        var mockUI = new MockUI();
        mockUI.SetInput = expected;

        //Act
        var actual = Util.AskForString("", mockUI);

        //Assert
        Assert.Equal(expected, actual);
    } 
    
    [Fact]
    public void AskForString_ShouldReturnExpectedString2()
    {
        //Arrange
        const string expected = "some value";
        var mockUI = new Mock<IUI>();
        mockUI.Setup(m => m.GetInput()).Returns(expected);

        //Act
        var actual = Util.AskForString("", mockUI.Object);

        //Assert
        Assert.Equal(expected, actual);
    }
}