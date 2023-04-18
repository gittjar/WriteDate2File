namespace _03_WriteDateFilename;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        string expectedFileName = string.Format("filename-date-{0:yyyy-MM-dd_hh-mm}.txt", DateTime.Now);
        string expectedContent = "teksti";

        // Act
        string n = string.Format("filename-date-{0:yyyy-MM-dd_hh-mm}.txt", DateTime.Now);
        File.WriteAllText(n, "teksti");

        // Assert
        Assert.True(File.Exists(expectedFileName)); // Check if the file was created
        string actualContent = File.ReadAllText(expectedFileName);
        Assert.Equal(expectedContent, actualContent); // Check if the file content matches the expected content

        // Clean up
        File.Delete(expectedFileName); // Delete the created file!

    }
}


