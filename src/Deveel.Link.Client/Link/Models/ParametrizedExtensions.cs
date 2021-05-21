using System;
using System.Collections.Generic;
using System.Globalization;

namespace Deveel.Link.Models {
	public static class ParametrizedExtensions {
		public static T GetParameterValue<T>(this IParametrized parametrized, string key, T defaultValue) {
			if (parametrized == null || 
				parametrized.CustomParameters == null ||
				!parametrized.CustomParameters.TryGetValue(key, out var value))
				return defaultValue;

			if (!typeof(T).IsInstanceOfType(value))
				value = Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture);

			return (T)value;
		}

		public static void SetParameterValue(this IParametrized parametrized, string key, object value) {
			if (parametrized == null)
				throw new ArgumentNullException(nameof(parametrized));

			if (parametrized.CustomParameters == null)
				parametrized.CustomParameters = new Dictionary<string, object>();

			if (value == null) {
				parametrized.CustomParameters.Remove(key);
			} else {
				parametrized.CustomParameters[key] = value;
			}
		}
	}
}
