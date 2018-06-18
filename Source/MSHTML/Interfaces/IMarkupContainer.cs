﻿using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSHTMLApi
{
	/// <summary>
	/// Interface IMarkupContainer 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsInterface), BaseType]
	[TypeId("3050F5F9-98B5-11CF-BB82-00AA00BDCE0B")]
	public interface IMarkupContainer : ICOMObject
	{
		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="ppDoc">NetOffice.MSHTMLApi.IHTMLDocument2 ppDoc</param>
		[SupportByVersion("MSHTML", 4)]
		Int32 OwningDoc(out NetOffice.MSHTMLApi.IHTMLDocument2 ppDoc);

		#endregion
	}
}
