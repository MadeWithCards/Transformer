using AdaptiveCards.Templating;
using Newtonsoft.Json;
using System;

namespace ApiTransformer
{
  public static class Transformer
  {
 
    /// <summary>
    /// Transforms the given input onto the transformtemplate and
    /// returns it as the given type if matching. 
    /// transformTemplate has to match the class structure of T
    /// </summary>
    /// <typeparam name="T">Desired Output Type</typeparam>
    /// <param name="input">Any serializable input, can be string or any object</param>
    /// <param name="transformTemplate">a transformer compatible template</param>
    /// <returns></returns>
    public static T TransformData<T>(object input, string transformTemplate)
    {
      try
      {
        var transformedData = new AdaptiveTransformer().Transform(transformTemplate, JsonConvert.SerializeObject(input));
        return JsonConvert.DeserializeObject<T>(transformedData);
      }
      catch (Exception ex)
      {
        throw new Exception("An error occured transforming the data, does your class match the template?",ex);
      }

    }


    /// <summary>
    /// Transforms the given input onto the transformtemplate and
    /// returns the raw JSON String transformed
    /// </summary>
    /// <param name="input">A valid JSON Structure</param>
    /// <param name="transformTemplate">a transformer compatible template</param>
    /// <returns></returns>
    public static string TransformDataString(string input, string transformTemplate)
    {
      try
      {
        return new AdaptiveTransformer().Transform(transformTemplate, input);
      }
      catch (Exception ex)
      {
        throw new Exception("An error occured transforming the data", ex);
      }

    }


  }
}
