﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OutlookApi.Behind
{
	/// <summary>
	/// CoClass AttachmentSelection 
	/// SupportByVersion Outlook, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863628.aspx </remarks>
	[SupportByVersion("Outlook", 12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
 	public class AttachmentSelection : _AttachmentSelection, NetOffice.OutlookApi.AttachmentSelection
    {
		#pragma warning disable

		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;

        #endregion

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
        
        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(AttachmentSelection);
                return _type;
            }
        }
        
        #endregion
        		
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public AttachmentSelection() : base()
		{

		}

		#endregion

		#pragma warning restore
	}
}
