﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSFormsApi
{
	/// <summary>
	/// DispatchInterface IMdcOptionButton 
	/// SupportByVersion MSForms, 2
	/// </summary>
	[SupportByVersion("MSForms", 2)]
	[EntityType(EntityType.IsDispatchInterface), BaseType]
	[TypeId("8BD21D53-EC42-11CE-9E0D-00AA006002F3")]
    [CoClassSource(typeof(NetOffice.MSFormsApi.OptionButton))]
    public interface IMdcOptionButton : IMdcCheckBox
	{
	}
}
