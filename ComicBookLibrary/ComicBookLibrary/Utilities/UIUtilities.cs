using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace ComicBookLibrary.Utilities
{
    public static class UIUtilities
    {
        public static void BindComboBox(ComboBox cmb, DataTable dt, string displayMember, string valueMember)
        {
            //Adding an empty DataRow in the DataTable at first index
            DataRow row = dt.NewRow();
            row[valueMember] = DBNull.Value;
            row[displayMember] = "";
            dt.Rows.InsertAt(row, 0);

            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }
        public static void ClearChildControls(this Control control)
        {
            control.Controls.ClearControls();
        }
        public static void ClearControls(this ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case RichTextBox rTxt:
                        rTxt.Clear();
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case GroupBox gB:
                        ClearControls(gB.Controls);
                        break;
                    case ComboBox cB:
                        cB.SelectedIndex = 0;
                        break;
                }
            }
        }
    }
}
