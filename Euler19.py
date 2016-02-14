def is_leap_year(year):
    return year % 4 == 0 and (year % 100 != 0 or year % 400 == 0)


def get_month_days(year, month):
    thirty_day_months = [4, 6, 9, 11]

    if month == 2:
        if is_leap_year(year):
            return 29
        else:
            return 28

    elif month in [4, 6, 9, 11]:
        return 30

    else:
        return 31

weekday = 2
sundays = 0

for year in xrange(1901, 2001):

    for month in xrange (1, 13):

        month_days = get_month_days(year, month)

        for day in xrange(1, month_days + 1):
            if day == 1 and weekday == 7:
                sundays += 1

            if weekday == 7:
                weekday = 1
            else:
                weekday += 1

print sundays
