namespace TimestampHelper.Tests;

public class TimestampHelperTests
{
    [Fact]
    public void ToTimestamp_FromDateTime_ShouldReturnCorrectTimestamp()
    {
        // Arrange
        var expected = 1756100303408;
        var dateTime = new DateTime(2025, 08, 25, 05, 38, 23, 408, DateTimeKind.Utc);

        // Act
        var actual = TimestampHelper.ToTimestamp(dateTime);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ToTimestamp_FromDateTime_WithNotUtc_ShouldReturnArgumentException()
    {
        // Arrange
        var dateTime = new DateTime(2025, 08, 25, 05, 38, 23, 408, DateTimeKind.Local);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => TimestampHelper.ToTimestamp(dateTime));
    }

    [Fact]
    public void ToDateTime_FromTimestamp_ShouldReturnCorrectDateTime()
    {
        // Arrange
        var expected = new DateTime(2025, 08, 25, 05, 38, 23, 408, DateTimeKind.Utc);
        var timestamp = 1756100303408;

        // Act
        var actual = TimestampHelper.ToDateTime(timestamp);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ToDateTime_FromTimestamp_HasCorrectUtcFormat()
    {
        // Arrange
        var timestamp = 1756100303408;

        // Act
        var actual = TimestampHelper.ToDateTime(timestamp);

        // Assert
        Assert.Equal(DateTimeKind.Utc, actual.Kind);
    }

    [Fact]
    public void AddSeconds_ShouldReturnCorrectTimestamp()
    {
        // Arrange
        var expected = 1756100323408;
        var timestamp = 1756100303408;

        // Act
        var actual = TimestampHelper.AddSeconds(timestamp, 20.0);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void AddSeconds_WithZero_ShouldReturnTheSameTimestamp()
    {
        // Arrange
        var expected = 1756100303408;
        var timestamp = 1756100303408;

        // Act
        var actual = TimestampHelper.AddSeconds(timestamp, 0.0);

        // Assert
        Assert.Equal(expected, actual);
    }
}
