#Using TimestampHelper

```csharp
var nowUnixTimestamp = TimestampHelper.Now;
var tomorrowUnixTimestamp = TimestampHelper.Tomorrow;

var timestamp = TimestampHelper.ToTimestamp(DateTime.UtcNow);
var dateTime = TimestampHelper.ToDateTime(timestamp);
timestamp = TimestampHelper.AddSeconds(timestamp, 20);
```
