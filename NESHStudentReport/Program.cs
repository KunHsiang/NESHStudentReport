using System.Windows.Forms;
using FISCA.Permission;
using NESHStudentReport.Properties;

namespace NESHStudentReport
{
    public class Program
    {
        [FISCA.MainMethod()]
        public static void Main()
        {
            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學期成績通知單(3~6年級)"].Click += (sender, e) => new frmHome("學期成績通知單(3~6年級)", Resources.學生成績通知單_3_6).ShowDialog();
            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學期成績通知單(3~6年級)"].Enable = Permissions.學期成績通知單3至6年級權限;

            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學期成績通知單(7~8年級)"].Click += (sender, e) => new frmHome("學期成績通知單(7~8年級)", Resources.學生成績通知單_7_8).ShowDialog();
            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學期成績通知單(7~8年級)"].Enable = Permissions.學期成績通知單7至8年級權限;

            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學期成績通知單(9~12年級)"].Click += (sender, e) => new frmHome("學期成績通知單(9~12年級)", Resources.學生成績通知單_9_12).ShowDialog();
            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學期成績通知單(9~12年級)"].Enable = Permissions.學期成績通知單9至12年級權限;

            FISCA.Permission.Catalog AdminCatalog = FISCA.Permission.RoleAclSource.Instance["學生"]["功能按鈕"];
            AdminCatalog.Add(new RibbonFeature(Permissions.學期成績通知單3至6年級, "學期成績通知單3至6年級"));
            AdminCatalog.Add(new RibbonFeature(Permissions.學期成績通知單7至8年級, "學期成績通知單7至8年級"));
            AdminCatalog.Add(new RibbonFeature(Permissions.學期成績通知單9至12年級, "學期成績通知單9至12年級"));
        }
    }
}