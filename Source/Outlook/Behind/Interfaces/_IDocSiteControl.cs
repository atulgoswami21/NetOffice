﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OutlookApi;

namespace NetOffice.OutlookApi.Behind
{
	/// <summary>
	/// Interface _IDocSiteControl 
	/// SupportByVersion Outlook, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Outlook", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface)]
 	public class _IDocSiteControl : COMObject, NetOffice.OutlookApi._IDocSiteControl
	{
		#pragma warning disable

		#region Type Information

		/// <summary>
		/// Instance Type
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
		public override Type InstanceType
		{
			get
			{
				return LateBindingApiWrapperType;
			}
		}

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_IDocSiteControl);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _IDocSiteControl() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15,16)]
		public virtual bool ReadOnly
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ReadOnly");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ReadOnly", value);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Outlook", 12,14,15,16)]
		public virtual Int16 SuppressAttachments
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "SuppressAttachments");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SuppressAttachments", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}

