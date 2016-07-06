using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Newtonsoft.Json;
using UsingDependencyService.iOS;

[assembly: Dependency(typeof(JSONSerialise))]

namespace UsingDependencyService.iOS
{
  public class JSONSerialise : IJSONSerialise
  {
    public JSONSerialise()
    {
    }

    public object Deserialise(string json)
    {
      var obj = JsonConvert.DeserializeObject(json);
      return obj;
    }

    public string Serialise(object obj)
    {
      var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
      return json;
    }
  }
}

