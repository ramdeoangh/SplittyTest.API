using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SplittyTest.API.Extensions
{
    public static class ModelStateExtensions
    {

        //This is what I was talking about for error response. Still this is not the up to the work. need some changes.
        /// <summary>
        ///  An Extension Method for common error message mapping.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
        {
            var result = dictionary.SelectMany(m => m.Value.Errors)
                                 .Select(s => s.ErrorMessage)
                                 .ToList();
            return result;
        }
    }
}