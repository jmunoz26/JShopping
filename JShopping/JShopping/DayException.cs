using System;
using System.Runtime.Serialization;

namespace JShopping;

[Serializable]
internal class DayException : Exception
{
  public DayException()
  {
  }

  public DayException(string? message) : base(message)
  {
  }

  public DayException(string? message, Exception? innerException) : base(message, innerException)
  {
  }

  protected DayException(SerializationInfo info, StreamingContext context) : base(info, context)
  {
  }
}
