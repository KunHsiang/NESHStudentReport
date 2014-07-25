using System.Windows.Forms;
using NESHStudentReport.Properties;

namespace NESHStudentReport
{
    public class Program
    {
        [FISCA.MainMethod()]
        public static void Main()
        {
            //學生->資料統計->報表->成績相關報表->學生成績通知單(3~6年級)
            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學生成績通知單(3~6年級)"].Click += (sender, e) => new frmHome("學生成績通知單(3~6年級)",Resources.學生成績通知單_3_6).ShowDialog();
            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學生成績通知單(7~8年級)"].Click += (sender, e) => new frmHome("學生成績通知單(7~8年級)",Resources.學生成績通知單_7_8).ShowDialog();
            K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["報表"]["成績相關報表"]["學生成績通知單(9~12年級)"].Click += (sender, e) => new frmHome("學生成績通知單(9~12年級)",Resources.學生成績通知單_9_12).ShowDialog();
        }
    }
}