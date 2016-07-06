using System;

namespace UsingDependencyService
{
  public interface IJSONSerialise
  {
    string Serialise(object obj);
    object Deserialise(string json);
  }
}

