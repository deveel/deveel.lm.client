using System;
using System.Collections.Generic;

namespace Deveel.Link.Models {
	public interface IParametrized {
		IDictionary<string, object> CustomParameters { get; set; }
	}
}
