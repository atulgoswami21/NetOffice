﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface IPivotCache 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface)]
 	public class IPivotCache : COMObject, NetOffice.ExcelApi.IPivotCache
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.ExcelApi.IPivotCache);
                return _contractType;
            }
        }
        private static Type _contractType;


        /// <summary>        /// Instance Type
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
                    _type = typeof(IPivotCache);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IPivotCache() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool BackgroundQuery
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "BackgroundQuery");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BackgroundQuery", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object Connection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Connection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Connection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool EnableRefresh
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "EnableRefresh");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnableRefresh", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Index
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Index");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 MemoryUsed
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "MemoryUsed");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool OptimizeCache
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "OptimizeCache");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OptimizeCache", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 RecordCount
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "RecordCount");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual DateTime RefreshDate
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDateTimePropertyGet(this, "RefreshDate");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual string RefreshName
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "RefreshName");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool RefreshOnFileOpen
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "RefreshOnFileOpen");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RefreshOnFileOpen", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual object Sql
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Sql");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Sql", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool SavePassword
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "SavePassword");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SavePassword", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object SourceData
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "SourceData");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "SourceData", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object CommandText
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "CommandText");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "CommandText", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCmdType CommandType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCmdType>(this, "CommandType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "CommandType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.xlQueryType QueryType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.xlQueryType>(this, "QueryType");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool MaintainConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "MaintainConnection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "MaintainConnection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 RefreshPeriod
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "RefreshPeriod");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RefreshPeriod", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16), ProxyResult]
		public virtual object Recordset
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Recordset");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteReferencePropertySet(this, "Recordset", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object LocalConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "LocalConnection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "LocalConnection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool UseLocalConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "UseLocalConnection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "UseLocalConnection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16), ProxyResult]
		public virtual object ADOConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "ADOConnection");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool IsConnected
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "IsConnected");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool OLAP
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "OLAP");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlPivotTableSourceType SourceType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlPivotTableSourceType>(this, "SourceType");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlPivotTableMissingItems MissingItemsLimit
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlPivotTableMissingItems>(this, "MissingItemsLimit");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "MissingItemsLimit", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual string SourceConnectionFile
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "SourceConnectionFile");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SourceConnectionFile", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual string SourceDataFile
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "SourceDataFile");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlRobustConnect RobustConnect
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlRobustConnect>(this, "RobustConnect");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "RobustConnect", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.WorkbookConnection WorkbookConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.WorkbookConnection>(this, "WorkbookConnection", typeof(NetOffice.ExcelApi.WorkbookConnection));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlPivotTableVersionList Version
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlPivotTableVersionList>(this, "Version");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool UpgradeOnRefresh
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "UpgradeOnRefresh");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "UpgradeOnRefresh", value);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Refresh()
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Refresh");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 ResetTimer()
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "ResetTimer");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="tableDestination">object tableDestination</param>
		/// <param name="tableName">optional object tableName</param>
		/// <param name="readData">optional object readData</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.PivotTable CreatePivotTable(object tableDestination, object tableName, object readData)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PivotTable>(this, "CreatePivotTable", typeof(NetOffice.ExcelApi.PivotTable), tableDestination, tableName, readData);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="tableDestination">object tableDestination</param>
		/// <param name="tableName">optional object tableName</param>
		/// <param name="readData">optional object readData</param>
		/// <param name="defaultVersion">optional object defaultVersion</param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.PivotTable CreatePivotTable(object tableDestination, object tableName, object readData, object defaultVersion)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PivotTable>(this, "CreatePivotTable", typeof(NetOffice.ExcelApi.PivotTable), tableDestination, tableName, readData, defaultVersion);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="tableDestination">object tableDestination</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.PivotTable CreatePivotTable(object tableDestination)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PivotTable>(this, "CreatePivotTable", typeof(NetOffice.ExcelApi.PivotTable), tableDestination);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="tableDestination">object tableDestination</param>
		/// <param name="tableName">optional object tableName</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.PivotTable CreatePivotTable(object tableDestination, object tableName)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.PivotTable>(this, "CreatePivotTable", typeof(NetOffice.ExcelApi.PivotTable), tableDestination, tableName);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual Int32 MakeConnection()
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "MakeConnection");
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="oDCFileName">string oDCFileName</param>
		/// <param name="description">optional object description</param>
		/// <param name="keywords">optional object keywords</param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual Int32 SaveAsODC(string oDCFileName, object description, object keywords)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName, description, keywords);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="oDCFileName">string oDCFileName</param>
		[CustomMethod]
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual Int32 SaveAsODC(string oDCFileName)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="oDCFileName">string oDCFileName</param>
		/// <param name="description">optional object description</param>
		[CustomMethod]
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual Int32 SaveAsODC(string oDCFileName, object description)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName, description);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <param name="chartDestination">object chartDestination</param>
		/// <param name="xlChartType">optional object xlChartType</param>
		/// <param name="left">optional object left</param>
		/// <param name="top">optional object top</param>
		/// <param name="width">optional object width</param>
		/// <param name="height">optional object height</param>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Shape CreatePivotChart(object chartDestination, object xlChartType, object left, object top, object width, object height)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Shape>(this, "CreatePivotChart", typeof(NetOffice.ExcelApi.Shape), new object[]{ chartDestination, xlChartType, left, top, width, height });
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <param name="chartDestination">object chartDestination</param>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Shape CreatePivotChart(object chartDestination)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Shape>(this, "CreatePivotChart", typeof(NetOffice.ExcelApi.Shape), chartDestination);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <param name="chartDestination">object chartDestination</param>
		/// <param name="xlChartType">optional object xlChartType</param>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Shape CreatePivotChart(object chartDestination, object xlChartType)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Shape>(this, "CreatePivotChart", typeof(NetOffice.ExcelApi.Shape), chartDestination, xlChartType);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <param name="chartDestination">object chartDestination</param>
		/// <param name="xlChartType">optional object xlChartType</param>
		/// <param name="left">optional object left</param>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Shape CreatePivotChart(object chartDestination, object xlChartType, object left)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Shape>(this, "CreatePivotChart", typeof(NetOffice.ExcelApi.Shape), chartDestination, xlChartType, left);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <param name="chartDestination">object chartDestination</param>
		/// <param name="xlChartType">optional object xlChartType</param>
		/// <param name="left">optional object left</param>
		/// <param name="top">optional object top</param>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Shape CreatePivotChart(object chartDestination, object xlChartType, object left, object top)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Shape>(this, "CreatePivotChart", typeof(NetOffice.ExcelApi.Shape), chartDestination, xlChartType, left, top);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <param name="chartDestination">object chartDestination</param>
		/// <param name="xlChartType">optional object xlChartType</param>
		/// <param name="left">optional object left</param>
		/// <param name="top">optional object top</param>
		/// <param name="width">optional object width</param>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Shape CreatePivotChart(object chartDestination, object xlChartType, object left, object top, object width)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Shape>(this, "CreatePivotChart", typeof(NetOffice.ExcelApi.Shape), new object[]{ chartDestination, xlChartType, left, top, width });
		}

		#endregion

		#pragma warning restore
	}
}


