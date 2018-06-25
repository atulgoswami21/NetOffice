﻿using System;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Tools;
using NetOffice.ExcelApi.Tools;
using Office = NetOffice.OfficeApi;

namespace ExcelAddin
{
    [COMAddin("Addin Source Sample Addin CS4", "Addin Source Sample", LoadBehavior.LoadAtStartup)]
    [ProgId("ExcelAddin.Connect"), Guid("CDDF2714-BC19-4CD5-860A-9119AC445914"), Codebase, Timestamp]
    [RegistryLocation(RegistrySaveLocation.InstallScopeCurrentUser)]
    [CustomUI("RibbonUI.xml", true)]
    [CustomPane(typeof(Pane), "Source", false, PaneDockPosition.msoCTPDockPositionTop, PaneDockPositionRestrict.msoCTPDockPositionRestrictNoVertical, 60, 60)]
    public class Connect : COMAddin
    {
        public Connect()
        {
            OnStartupComplete += Addin_OnStartupComplete;
            OnDisconnection += Addin_OnDisconnection;
        }

        private void Addin_OnStartupComplete(ref Array custom)
        {
            Factory.Console.Mode = DebugConsoleMode.Trace;
            Factory.Console.WriteLine("Factory initialized in {0}", Factory.InitializedTime);
            Factory.Console.WriteLine("LoadingTimeElapsed {0}", LoadingTimeElapsed);
        }

        private void Addin_OnDisconnection(ext_DisconnectMode removeMode, ref Array custom)
        {

        }

        public void OnClickAboutButton(Office.IRibbonControl control)
        {
            Utils.Dialog.ShowDiagnostics();
        }
    }
}