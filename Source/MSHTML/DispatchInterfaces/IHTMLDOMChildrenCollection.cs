﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSHTMLApi
{
	/// <summary>
	/// DispatchInterface IHTMLDOMChildrenCollection 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface)]
	[TypeId("3050F5AB-98B5-11CF-BB82-00AA00BDCE0B")]
	public interface IHTMLDOMChildrenCollection : DispStaticNodeList
	{
	}
}
