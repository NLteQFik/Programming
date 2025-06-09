using System.Data;
using Task3.Services;

DateServices myDate = new DateServices();
Console.WriteLine($"Day of week: {myDate.GetDay("15.03.2025")}");
Console.WriteLine($"Difference: {myDate.GetDaysSpan(16, 3, 2025)}");