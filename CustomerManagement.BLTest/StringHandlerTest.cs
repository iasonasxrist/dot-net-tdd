using Xunit;

public class StringHandlerTests
{
    [Fact]
    public void InsertSpaces_InputIsNull_ReturnsEmptyString()
    {
        // Arrange
        string input = null;

        // Act
        string result = input.InsertSpaces();

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void InsertSpaces_InputIsEmpty_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = input.InsertSpaces();

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void InsertSpaces_InputHasNoUppercaseLetters_ReturnsSameString()
    {
        // Arrange
        string input = "hello world";

        // Act
        string result = input.InsertSpaces();

        // Assert
        Assert.Equal("hello world", result);
    }

    [Fact]
    public void InsertSpaces_InputHasUppercaseLetters_ReturnsStringWithSpacesBeforeUppercaseLetters()
    {
        // Arrange
        string input = "HelloWorld";

        // Act
        string result = input.InsertSpaces();

        // Assert
        Assert.Equal("Hello World", result);
    }

}
