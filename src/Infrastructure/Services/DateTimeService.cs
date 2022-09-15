using Cherpumple.Application.Common.Interfaces;

namespace Cherpumple.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
