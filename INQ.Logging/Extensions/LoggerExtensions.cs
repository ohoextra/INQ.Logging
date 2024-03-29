﻿using Serilog;
using Serilog.Events;

namespace INQ.Logging.Extensions;

public static class LoggerExtensions
{
    public static void Log(
        this ILogger logger,
        string messageTemplate = "",
        LogEventLevel level = LogEventLevel.Information,
        params object?[]? propertyValues)
    {
        if (!string.IsNullOrWhiteSpace(messageTemplate))
            logger.Write(level, messageTemplate, propertyValues);
    }
}
