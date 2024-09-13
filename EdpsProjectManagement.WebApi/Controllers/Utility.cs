using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace EdpsProjectManagement.WebApi.Controllers
{
	public class Utility
	{
		#region private variables
		#endregion
		#region Update Entity
		public delegate object GetPropertyValueByRequestKey(object requestData, string key, Type propertyType);
		internal static MetaShare.Common.Core.Entities.Common GetEntityFromRequest(MetaShare.Common.Core.Entities.Common newEntity, IFormCollection nameValueCollection)
		internal static string GetUpdateEntityId(dynamic entity)
		internal static string GetUpdateEntityId(IFormCollection nameValueCollection)
		internal static void UpdateEntityValue(object newEntity, object json, ICollection<string> keys, GetPropertyValueByRequestKey getPropertyValueByRequestKey)
		public static object ConvertStringToPropertyTypeValue(object @object, string key, Type propertyInfoPropertyType)
		public static object ConvertJTokenToPropertyTypeValue(object @object, string key, Type propertyInfoPropertyType)
		internal static ICollection<string> GetJsonKeys(JObject json)
		#region covert to PrimitiveType from string
		
		private static object CovertFromPrimitiveType(string keyValue, Type propertyInfoPropertyType)
		#endregion
		
		#region    covert to PrimitiveType from JToken
		
		private static object CovertFromJTokePrimitiveType(JToken keyValue, Type propertyInfoPropertyType)
		#endregion
		#endregion
		#region SelectBy
		
		internal static List<string> GetColumnStrings(MetaShare.Common.Core.Entities.Common newEntity, ICollection<string> keys)
		#endregion
		
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}