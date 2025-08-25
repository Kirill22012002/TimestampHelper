namespace TimestampHelper;

public static class TimestampHelper
{
    public static long Now => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    public static long Tomorrow => DateTimeOffset.UtcNow.AddDays(1).ToUnixTimeMilliseconds();

    public static long ToTimestamp(DateTime dateTime)
    {
        if (dateTime.Kind != DateTimeKind.Utc) throw new ArgumentException("not correct format, use only utc");
        return new DateTimeOffset(dateTime).ToUnixTimeMilliseconds();
    }

    public static DateTime ToDateTime(long timestamp)
    {
        var dateTime = DateTimeOffset.FromUnixTimeMilliseconds(timestamp).DateTime;
        return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
    }

    public static long AddSeconds(long timestamp, double seconds)
    {
        if (seconds == 0) return timestamp;
        var dateTime = ToDateTime(timestamp);
        var newDateTime = dateTime.AddSeconds(seconds);
        return ToTimestamp(newDateTime);
    }
}
