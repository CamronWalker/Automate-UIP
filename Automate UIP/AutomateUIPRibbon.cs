﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Automate_UIP
{
    public partial class AutomateUIPRibbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void AddNewTradeSheet_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("FeaturePending", "Add New Trade Sheet");
        }

        private void OpenQuantityLinkFile_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("FeaturePending", "Open Quantity Link File");
        }

        private void GenerateFullReport_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("FeaturePending", "Generate Full Report");
        }

        private void UpdatePathtoQuantityLinkFile_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("SelectQuantityLinkFile");
        }

        private void UpdatePlan_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("FeaturePending", "Update Plan");
        }

        private void UpdateWeek_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("FeaturePending", "Update Week");
        }

        private void SendSubUpdates_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("FeaturePending", "Send Sub Updates");
        }

        private void ExportSubReports_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("FeaturePending", "Export Sub Reports");
        }

        private void SelectTakeoffFiles_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("SelectTradeTakeoffFiles");
        }

        private void Settings_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("OpenSettings");
        }

        private void ExportCurrentTrade_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("ExportCurrentTrade");
        }

        private void RefreshQuantityLinks_Click_1(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("RefreshLinks");
        }

        private void OpenQuantityLinkFile_Click_1(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.Application.Run("OpenQuantityLinkFile");
        }
    }
}
