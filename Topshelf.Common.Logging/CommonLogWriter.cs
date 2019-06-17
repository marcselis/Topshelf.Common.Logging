﻿using System;
using Common.Logging;
using Topshelf.Logging;

namespace Topshelf.Common.Logging
{
    /// <summary>
    /// Topshelf Log Writer implementation writing to Common.Logging
    /// </summary>
    public class CommonLogWriter : LogWriter
    {
        private readonly string _name;

        /// <summary>
        /// Creates a new instance of the <see cref="CommonLogWriter"/> class, specifying the name of the logger.
        /// </summary>
        /// <param name="name"></param>
        public CommonLogWriter(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Writes a debug message to the log
        /// </summary>
        /// <param name="messageProvider"></param>
        public void Debug(LogWriterOutputProvider messageProvider)
        {
            GetLogger().Debug(messageProvider());
        }

        /// <summary>
        /// Writes an exception to the debugging log.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="exception"></param>
        public void Debug(object obj, Exception exception)
        {
            GetLogger().Debug(obj, exception);
        }

        /// <summary>
        /// Writes a debug message to the log.
        /// </summary>
        /// <param name="obj"></param>
        public void Debug(object obj)
        {
            GetLogger().Debug(obj);
        }

        public void DebugFormat(string format, params object[] args)
        {
            GetLogger().DebugFormat(format, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            GetLogger().DebugFormat(formatProvider, format, args);
        }

        public void Error(LogWriterOutputProvider messageProvider)
        {
            GetLogger().Error(messageProvider());
        }

        public void Error(object obj, Exception exception)
        {
            GetLogger().Error(obj, exception);
        }

        public void Error(object obj)
        {
            GetLogger().Error(obj);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            GetLogger().ErrorFormat(format, args);
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            GetLogger().ErrorFormat(formatProvider, format, args);
        }

        public void Fatal(LogWriterOutputProvider messageProvider)
        {
            GetLogger().Fatal(messageProvider());
        }

        public void Fatal(object obj, Exception exception)
        {
            GetLogger().Fatal(obj, exception);
        }

        public void Fatal(object obj)
        {
            GetLogger().Fatal(obj);
        }

        public void FatalFormat(string format, params object[] args)
        {
            GetLogger().FatalFormat(format, args);
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            GetLogger().FatalFormat(formatProvider, format, args);
        }

        public void Info(LogWriterOutputProvider messageProvider)
        {
            GetLogger().Info(messageProvider());
        }

        public void Info(object obj, Exception exception)
        {
            GetLogger().Info(obj, exception);
        }

        public void Info(object obj)
        {
            GetLogger().Info(obj);
        }

        public void InfoFormat(string format, params object[] args)
        {
            GetLogger().InfoFormat(format, args);
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            GetLogger().InfoFormat(formatProvider, format, args);
        }

        public bool IsDebugEnabled => GetLogger().IsDebugEnabled;

        public bool IsErrorEnabled => GetLogger().IsErrorEnabled;

        public bool IsFatalEnabled => GetLogger().IsFatalEnabled;

        public bool IsInfoEnabled => GetLogger().IsInfoEnabled;

        public bool IsWarnEnabled => GetLogger().IsWarnEnabled;

        public void Log(LoggingLevel level, LogWriterOutputProvider messageProvider)
        {
            throw new NotImplementedException();
        }

        public void Log(LoggingLevel level, object obj, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Log(LoggingLevel level, object obj)
        {
            throw new NotImplementedException();
        }

        public void LogFormat(LoggingLevel level, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void LogFormat(LoggingLevel level, IFormatProvider formatProvider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Warn(LogWriterOutputProvider messageProvider)
        {
            GetLogger().Warn(messageProvider());
        }

        public void Warn(object obj, Exception exception)
        {
            GetLogger().Warn(obj, exception);
        }

        public void Warn(object obj)
        {
            GetLogger().Warn(obj);
        }

        public void WarnFormat(string format, params object[] args)
        {
            GetLogger().WarnFormat(format, args);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            GetLogger().WarnFormat(formatProvider, format, args);
        }

        private ILog GetLogger()
        {
            return LogManager.GetLogger(_name);
        }
    }
}