using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDTools
{
    public class FormController
    {
        public static void TbxClear(Form form, string tbxName = "")
        {
            // Optional parameter clears specified tbx
            if (tbxName != "")
            {
                // If in form (won't check tab controls)
                foreach (Control c in form.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Name.Contains(tbxName))
                            c.Text = "";
                    }
                }
                // Checks tab controls
                foreach (Control c in form.Controls)
                {
                    if (c is TabControl)
                    {
                        foreach (Control tc in c.Controls)
                        {
                            if (tc is TabPage)
                            {
                                foreach (Control tp in tc.Controls)
                                {
                                    if (tp is TextBox)
                                    {
                                        if (tp.Name.Contains(tbxName))
                                            tp.Text = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Clears every tbx
            else
            {
                // If in form (won't check tab controls)
                foreach (Control c in form.Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                }
                // Checks tab controls
                foreach (Control c in form.Controls)
                {
                    if (c is TabControl)
                    {
                        foreach (Control tc in c.Controls)
                        {
                            if (tc is TabPage)
                            {
                                foreach (Control tp in tc.Controls)
                                {
                                    if (tp is TextBox)
                                    {
                                        if (tp is TextBox)
                                            tp.Text = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void TbxHide(Form form, bool isVisible = false, string tbxName = "")
        {
            // Optional parameter clears specified tbx
            if (tbxName != "")
            {
                // If in form (won't check tab controls)
                foreach (Control c in form.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Name.Contains(tbxName))
                            c.Visible = isVisible;
                    }
                }
                // Checks tab controls
                foreach (Control c in form.Controls)
                {
                    if (c is TabControl)
                    {
                        foreach (Control tc in c.Controls)
                        {
                            if (tc is TabPage)
                            {
                                foreach (Control tp in tc.Controls)
                                {
                                    if (tp is TextBox)
                                    {
                                        if (tp.Name.Contains(tbxName))
                                            tp.Visible = isVisible;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Clears every tbx
            else
            {
                // If in form (won't check tab controls)
                foreach (Control c in form.Controls)
                {
                    if (c is TextBox)
                        c.Visible = isVisible;
                }
                // Checks tab controls
                foreach (Control c in form.Controls)
                {
                    if (c is TabControl)
                    {
                        foreach (Control tc in c.Controls)
                        {
                            if (tc is TabPage)
                            {
                                foreach (Control tp in tc.Controls)
                                {
                                    if (tp is TextBox)
                                    {
                                        if (tp is TextBox)
                                            tp.Visible = isVisible;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void BtnHide(Form form, bool isVisible = false, string btnName = "")
        {
            // Optional parameter clears specified btn
            if (btnName != "")
            {
                // If in form (won't check tab controls)
                foreach (Control c in form.Controls)
                {
                    if (c is Button)
                    {
                        if (c.Name.Contains(btnName))
                            c.Visible = isVisible;
                    }
                }
                // Checks tab controls
                foreach (Control c in form.Controls)
                {
                    if (c is TabControl)
                    {
                        foreach (Control tc in c.Controls)
                        {
                            if (tc is TabPage)
                            {
                                foreach (Control tp in tc.Controls)
                                {
                                    if (tp is Button)
                                    {
                                        if (tp.Name.Contains(btnName))
                                            tp.Visible = isVisible;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Clears every btn
            else
            {
                // If in form (won't check tab controls)
                foreach (Control c in form.Controls)
                {
                    if (c is Button)
                        c.Visible = isVisible;
                }
                // Checks tab controls
                foreach (Control c in form.Controls)
                {
                    if (c is TabControl)
                    {
                        foreach (Control tc in c.Controls)
                        {
                            if (tc is TabPage)
                            {
                                foreach (Control tp in tc.Controls)
                                {
                                    if (tp is Button)
                                    {
                                        if (tp is Button)
                                            tp.Visible = isVisible;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void LblHide(Form form, bool isVisible = false, string lblName = "")
        {
            // Optional parameter clears specified lbl
            if (lblName != "")
            {
                // If in form (won't check tab controls)
                foreach (Control c in form.Controls)
                {
                    if (c is Label)
                    {
                        if (c.Name.Contains(lblName))
                            c.Visible = isVisible;
                    }
                }
                // Checks tab controls
                foreach (Control c in form.Controls)
                {
                    if (c is TabControl)
                    {
                        foreach (Control tc in c.Controls)
                        {
                            if (tc is TabPage)
                            {
                                foreach (Control tp in tc.Controls)
                                {
                                    if (tp is Label)
                                    {
                                        if (tp.Name.Contains(lblName))
                                            tp.Visible = isVisible;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Clears every lbl
            else
            {
                // If in form (won't check tab controls)
                foreach (Control c in form.Controls)
                {
                    if (c is Label)
                        c.Visible = isVisible;
                }
                // Checks tab controls
                foreach (Control c in form.Controls)
                {
                    if (c is TabControl)
                    {
                        foreach (Control tc in c.Controls)
                        {
                            if (tc is TabPage)
                            {
                                foreach (Control tp in tc.Controls)
                                {
                                    if (tp is Label)
                                    {
                                        if (tp is Label)
                                            tp.Visible = isVisible;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
