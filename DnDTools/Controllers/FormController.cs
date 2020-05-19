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

        public static void TbxHide(Form form, string tbxName = "")
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
                            c.Visible = false;
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
                                            tp.Visible = false;
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
                        c.Visible = false;
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
                                            tp.Visible = false;
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
