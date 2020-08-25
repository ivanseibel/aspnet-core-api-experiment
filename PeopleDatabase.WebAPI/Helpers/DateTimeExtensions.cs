using System;

namespace PeopleDatabase.WebAPI.Helpers
{
  public static class DateTimeExtensions
  {
    public static int GetCurrentAgeInYears(this DateTime referenceDate)
    {
      var currentDate = DateTime.UtcNow;

      int ageInYears = currentDate.Year - referenceDate.Year;

      if (currentDate < referenceDate.AddYears(ageInYears))
        ageInYears--;

      return ageInYears;
    }
  }
}