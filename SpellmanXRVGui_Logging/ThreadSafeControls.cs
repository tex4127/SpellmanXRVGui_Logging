////////////////////////////////////////////////////////////////////////////////////////////
///
/// This source code is desinged to simplify writing thread safe code for GUI interactions.
///
/// This has been desinged to be universally applicable to any c# code bases implementing a BUI.
///
///
///
///////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellmanXRVGui_Logging
{
    public partial class ThreadSaveControls : Form
    {

        #region enumerations

        public enum AttributeValue
        {
            Disabled = 0,
            Enabled,
            Invisible,
            Visible,
            VisibleDisabled,
            VisibleEnabled
        }
        #endregion

        #region Delegate Declarations

        private delegate void SafeCallDelegateLogText(string text);

        private delegate void SafeCallDelegateImageIndex(PictureBox pictureBox, ImageList imageList, int value);

        private delegate void SafeCallDelegateComboBoxIndex(ComboBox comboBox, int selectedIndex);

        private delegate void SafeCallDelegateComboBoxItem(ComboBox comboBox, string item);

        private delegate void SafeCallDelegateProgressBarValue(ProgressBar bar, int value);

        private delegate void SafeCallDelegateButtonImageIndex(Button button, ImageList imageList, int value);

        private delegate void SafeCallDelegateComponentText<C>(ref C component, string text);

        private delegate void SafeCallDelegateComponentAttribute<C>(ref C component, AttributeValue value);

        private delegate void SafeCallDelegateCheckBoxCheck(CheckBox checkBox, bool value);

        private delegate void SafeCallDelegateSetColors<C>(ref C component, Color foreground, Color background);

        private delegate void SafeCallDelegateAddRow(DataGridView table, DataGridViewRow rowData);

        private delegate void SafeCallDelegateNumericUpDownValue(NumericUpDown numeric, decimal value);

        private delegate void SafeCallDelegateRadioButtonValue(RadioButton radioButton, bool value);

        private delegate void SafeCallDelegateToolStripComboBoxValue(ToolStrip toolStrip, string item);
        

        #endregion



        #region Thread Safe Control Calls

        /// <summary>
        /// Overload of the WriteAttribueThreadSafe for the radio button to allow for better UI
        /// </summary>
        /// <param name="radioButton"></param>
        /// <param name="value"></param>
        /// <param name="OGValue"></param>
        public void WriteAttributeThreadSafe(RadioButton radioButton, bool value, bool OGValue)
        {
            if(value != OGValue)
            {
                if (radioButton.InvokeRequired)
                {

                    var d = new SafeCallDelegateRadioButtonValue(WriteAttributeThreadSafe);
                    radioButton.Invoke(d, new object[] { radioButton, value });
                }
                else
                {
                    radioButton.Checked = value;
                }
            }
            
        }
        /// <summary>
        /// Changes the checked status of a radio button to match the boolean value passed as
        /// a parameter.
        /// </summary>
        /// <param name="radioButton"></param>
        /// <param name="value"></param>
        public void WriteAttributeThreadSafe(RadioButton radioButton, bool value)
        {
            if(radioButton.InvokeRequired)
            {
                
                var d = new SafeCallDelegateRadioButtonValue(WriteAttributeThreadSafe);
                radioButton.Invoke(d, new object[] { radioButton, value });
            }
            else
            {
                radioButton.Checked = value;
            }
        }

        /// <summary>
        /// Changes the image on the given picture box to the given indexed image from the
        /// list of images in imagelist.
        /// </summary>
        /// <param name="pictureBox">The picture box object to change the image on.</param>
        /// <param name="imageList">The image list to use</param>
        /// <param name="imageIndex">Which index in the image list to use</param>
        public void WriteAttributeThreadSafe(PictureBox pictureBox, ImageList imageList, int imageIndex)
        {
            if(pictureBox.InvokeRequired)
            {
                var d = new SafeCallDelegateImageIndex(WriteAttributeThreadSafe);
                pictureBox.Invoke(d, new object[] { pictureBox, imageList, imageIndex });
            }
            else
            {
                pictureBox.Image = imageList.Images[imageIndex];
            }
        }


        /// <summary>
        /// Adds item to the end of a combo box's list of items, or clears the list of items.
        /// </summary>
        /// <param name="comboBox">Combo box instance to modify</param>
        /// <param name="item">Item to add or empty string to clear</param>
        public void WriteAttributeThreadSafe(ComboBox comboBox, string item)
        {
            if (comboBox.InvokeRequired)
            {
                var d = new SafeCallDelegateComboBoxItem(WriteAttributeThreadSafe);
                comboBox.Invoke(d, new object[] { comboBox, item });
            }
            else
            {
                if (item == "")
                {
                    comboBox.Items.Clear();
                }
                else
                {
                    comboBox.Items.Add(item);
                }
            }
        }


        /// <summary>
        /// An overloaded method that changes the image on the given button to the given indexed image
        /// from the list of images in imagelist.
        /// </summary>
        /// <param name="button">The button object to change the image on.</param>
        /// <param name="imageList">The image list to use</param>
        /// <param name="imageIndex">Which index in the image list to use.</param>
        public void WriteAttributeThreadSafe(Button button, ImageList imageList, int imageIndex)
        {
            if (button.InvokeRequired)
            {
                var d = new SafeCallDelegateButtonImageIndex(WriteAttributeThreadSafe);
                button.Invoke(d, new object[] { button, imageList, imageIndex });
            }
            else
            {
                button.Image = imageList.Images[imageIndex];
            }
        }

        /// <summary>
        /// Selects a combo box item.
        /// </summary>
        /// <param name="comboBox">Combo box instance to modify</param>
        /// <param name="selectedIndex">Index of item to make selected</param>
        public void WriteAttributeThreadSafe(ComboBox comboBox, int selectedIndex)
        {
            if (comboBox.InvokeRequired)
            {
                var d = new SafeCallDelegateComboBoxIndex(WriteAttributeThreadSafe);
                comboBox.Invoke(d, new object[] { comboBox, selectedIndex });
            }
            else
            {
                comboBox.SelectedIndex = selectedIndex;
            }
        }

        /// <summary>
        /// Checks or unchecks a check box.
        /// </summary>
        /// <param name="checkBox">Check box instance to modify</param>
        /// <param name="value">Boolean value that checks or unchecks</param>
        public void WriteAttributeThreadSafe(CheckBox checkBox, bool value)
        {
            if (checkBox.InvokeRequired)
            {
                var d = new SafeCallDelegateCheckBoxCheck(WriteAttributeThreadSafe);
                checkBox.Invoke(d, new object[] { checkBox, value });
            }
            else
            {
                checkBox.Checked = value;
            }
        }

        /// <summary>
        /// Adds the given row data to the given data grid view in a thread-safe
        /// manner.
        /// </summary>
        /// <param name="table">Data grid view object to operate on.</param>
        /// <param name="rowData">Row data, as a string, to add to the table.</param>
        public void WriteAttributeThreadSafeAddRow(DataGridView table, DataGridViewRow rowData)
        {
            if (table.InvokeRequired)
            {
                var d = new SafeCallDelegateAddRow(WriteAttributeThreadSafeAddRow);
                table.Invoke(d, new object[] { table, rowData });
            }
            else
            {
                table.Rows.Add(rowData);
            }
        }

        

        /// <summary>
        /// Sets the value of a numeric up down control.
        /// </summary>
        /// <param name="numeric">Numeric up/down instance to modify</param>
        /// <param name="value">Value to set control to</param>
        public void WriteAttributeThreadSafe(NumericUpDown numeric, decimal value)
        {
            if (numeric.InvokeRequired)
            {
                var d = new SafeCallDelegateNumericUpDownValue(WriteAttributeThreadSafe);
                numeric.Invoke(d, new object[] { numeric, value });
            }
            else
            {
                numeric.Value = value;
            }
        }

        /// <summary>
        /// Sets a progress bar to the given value.
        /// </summary>
        /// <param name="bar">Progress bar instance to modify</param>
        /// <param name="value">Value to set bar to (0 to 100%)</param>
        public void WriteAttributeThreadSafe(ProgressBar bar, int value)
        {
            if (bar.InvokeRequired)
            {
                var d = new SafeCallDelegateProgressBarValue(WriteAttributeThreadSafe);
                bar.Invoke(d, new object[] { bar, value });
            }
            else
            {
                bar.Value = value;
            }
        }

        /// <summary>
        /// An overloaded method that sets the enabled and/or visible attributes on the given object to the
        /// given value. The following component types are supported: Button, Label, ComboBox, GroupBox and
        /// PictureBox.
        /// </summary>
        /// <typeparam name="C">Object (component) type, i.e. Button, Label, etc.</typeparam>
        /// <param name="component">The specific component to change</param>
        /// <param name="value">An enumerated value for setting enabled and visible parameters on the component</param>
        public void WriteAttributeThreadSafe<C>(ref C component, AttributeValue value)
        {
            switch (typeof(C).ToString())
            {
                case "System.Windows.Forms.Button":
                    {
                        Button button = (Button)Convert.ChangeType(component, typeof(C));
                        if (button.InvokeRequired)
                        {
                            var d = new SafeCallDelegateComponentAttribute<C>(WriteAttributeThreadSafe);
                            button.Invoke(d, new object[] { component, value });
                        }
                        else
                        {
                            switch (value)
                            {
                                case AttributeValue.Disabled:
                                    button.Enabled = false;
                                    break;
                                case AttributeValue.Enabled:
                                    button.Enabled = true;
                                    break;
                                case AttributeValue.Invisible:
                                    button.Visible = false;
                                    break;
                                case AttributeValue.Visible:
                                    button.Visible = true;
                                    break;
                                case AttributeValue.VisibleDisabled:
                                    button.Visible = true;
                                    button.Enabled = false;
                                    break;
                                case AttributeValue.VisibleEnabled:
                                    button.Visible = true;
                                    button.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                
                case "System.Windows.Forms.Label":
                    {
                        Label label = (Label)Convert.ChangeType(component, typeof(C));
                        if (label.InvokeRequired)
                        {
                            var d = new SafeCallDelegateComponentAttribute<C>(WriteAttributeThreadSafe);
                            label.Invoke(d, new object[] { component, value });
                        }
                        else
                        {
                            switch (value)
                            {
                                case AttributeValue.Disabled:
                                    label.Enabled = false;
                                    break;
                                case AttributeValue.Enabled:
                                    label.Enabled = true;
                                    break;
                                case AttributeValue.Invisible:
                                    label.Visible = false;
                                    break;
                                case AttributeValue.Visible:
                                    label.Visible = true;
                                    label.BringToFront();
                                    break;
                                case AttributeValue.VisibleDisabled:
                                    label.Visible = true;
                                    label.Enabled = false;
                                    break;
                                case AttributeValue.VisibleEnabled:
                                    label.Visible = true;
                                    label.Enabled = true;
                                    label.BringToFront();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case "System.Windows.Forms.ComboBox":
                    {
                        ComboBox comboBox = (ComboBox)Convert.ChangeType(component, typeof(C));
                        if (comboBox.InvokeRequired)
                        {
                            var d = new SafeCallDelegateComponentAttribute<C>(WriteAttributeThreadSafe);
                            comboBox.Invoke(d, new object[] { component, value });
                        }
                        else
                        {
                            switch (value)
                            {
                                case AttributeValue.Disabled:
                                    comboBox.Enabled = false;
                                    break;
                                case AttributeValue.Enabled:
                                    comboBox.Enabled = true;
                                    break;
                                case AttributeValue.Invisible:
                                    comboBox.Visible = false;
                                    break;
                                case AttributeValue.Visible:
                                    comboBox.Visible = true;
                                    break;
                                case AttributeValue.VisibleDisabled:
                                    comboBox.Visible = true;
                                    comboBox.Enabled = false;
                                    break;
                                case AttributeValue.VisibleEnabled:
                                    comboBox.Visible = true;
                                    comboBox.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case "System.Windows.Forms.GroupBox":
                    {
                        GroupBox groupBox = (GroupBox)Convert.ChangeType(component, typeof(C));
                        if (groupBox.InvokeRequired)
                        {
                            var d = new SafeCallDelegateComponentAttribute<C>(WriteAttributeThreadSafe);
                            groupBox.Invoke(d, new object[] { component, value });
                        }
                        else
                        {
                            switch (value)
                            {
                                case AttributeValue.Disabled:
                                    groupBox.Enabled = false;
                                    break;
                                case AttributeValue.Enabled:
                                    groupBox.Enabled = true;
                                    break;
                                case AttributeValue.Invisible:
                                    groupBox.Visible = false;
                                    break;
                                case AttributeValue.Visible:
                                    groupBox.Visible = true;
                                    groupBox.BringToFront();
                                    break;
                                case AttributeValue.VisibleDisabled:
                                    groupBox.Visible = true;
                                    groupBox.Enabled = false;
                                    break;
                                case AttributeValue.VisibleEnabled:
                                    groupBox.Visible = true;
                                    groupBox.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case "System.Windows.Forms.PictureBox":
                    {
                        PictureBox pictureBox = (PictureBox)Convert.ChangeType(component, typeof(C));
                        if (pictureBox.InvokeRequired)
                        {
                            var d = new SafeCallDelegateComponentAttribute<C>(WriteAttributeThreadSafe);
                            pictureBox.Invoke(d, new object[] { component, value });
                        }
                        else
                        {
                            switch (value)
                            {
                                case AttributeValue.Disabled:
                                    pictureBox.Enabled = false;
                                    break;
                                case AttributeValue.Enabled:
                                    pictureBox.Enabled = true;
                                    break;
                                case AttributeValue.Invisible:
                                    pictureBox.Visible = false;
                                    break;
                                case AttributeValue.Visible:
                                    pictureBox.Visible = true;
                                    break;
                                case AttributeValue.VisibleDisabled:
                                    pictureBox.Visible = true;
                                    pictureBox.Enabled = false;
                                    break;
                                case AttributeValue.VisibleEnabled:
                                    pictureBox.Visible = true;
                                    pictureBox.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case "System.Windows.Forms.TabControl":
                    {
                        TabControl tabControl = (TabControl)Convert.ChangeType(component, typeof(C));
                        if (tabControl.InvokeRequired)
                        {
                            var d = new SafeCallDelegateComponentAttribute<C>(WriteAttributeThreadSafe);
                            tabControl.Invoke(d, new object[] { component, value });
                        }
                        else
                        {
                            switch (value)
                            {
                                case AttributeValue.Disabled:
                                    tabControl.Enabled = false;
                                    break;
                                case AttributeValue.Enabled:
                                    tabControl.Enabled = true;
                                    break;
                                case AttributeValue.Invisible:
                                    tabControl.Visible = false;
                                    break;
                                case AttributeValue.Visible:
                                    tabControl.Visible = true;
                                    break;
                                case AttributeValue.VisibleDisabled:
                                    tabControl.Visible = true;
                                    tabControl.Enabled = false;
                                    break;
                                case AttributeValue.VisibleEnabled:
                                    tabControl.Visible = true;
                                    tabControl.Enabled = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case "System.Windows.Forms.ProgressBar":
                    {
                        ProgressBar bar = (ProgressBar)Convert.ChangeType(component, typeof(C));
                        if (bar.InvokeRequired)
                        {
                            var d = new SafeCallDelegateComponentAttribute<C>(WriteAttributeThreadSafe);
                            bar.Invoke(d, new object[] { component, value });
                        }
                        else
                        {
                            switch (value)
                            {
                                case AttributeValue.Disabled:
                                    bar.Enabled = false;
                                    break;
                                case AttributeValue.Enabled:
                                    bar.Enabled = true;
                                    break;
                                case AttributeValue.Invisible:
                                    bar.Visible = false;
                                    break;
                                case AttributeValue.Visible:
                                    bar.Visible = true;
                                    bar.BringToFront();
                                    break;
                                case AttributeValue.VisibleDisabled:
                                    bar.Visible = true;
                                    bar.Enabled = false;
                                    break;
                                case AttributeValue.VisibleEnabled:
                                    bar.Visible = true;
                                    bar.Enabled = true;
                                    bar.BringToFront();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case "System.Windows.Forms.TextBox":
                    {
                        TextBox box = (TextBox)Convert.ChangeType(component, typeof(C));
                        if (box.InvokeRequired)
                        {
                            var d = new SafeCallDelegateComponentAttribute<C>(WriteAttributeThreadSafe);
                            box.Invoke(d, new object[] { component, value });
                        }
                        else
                        {
                            switch (value)
                            {
                                case AttributeValue.Disabled:
                                    box.Enabled = false;
                                    break;
                                case AttributeValue.Enabled:
                                    box.Enabled = true;
                                    break;
                                case AttributeValue.Invisible:
                                    box.Visible = false;
                                    break;
                                case AttributeValue.Visible:
                                    box.Visible = true;
                                    box.BringToFront();
                                    break;
                                case AttributeValue.VisibleDisabled:
                                    box.Visible = true;
                                    box.Enabled = false;
                                    break;
                                case AttributeValue.VisibleEnabled:
                                    box.Visible = true;
                                    box.Enabled = true;
                                    box.BringToFront();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                default:
                    // Do nothing.
                    break;
            }
        }

        /// <summary>
        /// An overloaded method that sets the text field on the given component.
        /// </summary>
        /// <typeparam name="C">The type of component, i.e. Button, Label, etc.</typeparam>
        /// <param name="component">The specific component we wish to change.</param>
        /// <param name="text">The text we want displayed on the component</param>
        public void WriteAttributeThreadSafe<C>(ref C component, string text)
        {
            switch (typeof(C).ToString())
            {
                case "System.Windows.Forms.Button":
                    Button button = (Button)Convert.ChangeType(component, typeof(C));
                    if (button.InvokeRequired)
                    {
                        var d = new SafeCallDelegateComponentText<C>(WriteAttributeThreadSafe);
                        button.Invoke(d, new object[] { component, text });
                    }
                    else
                    {
                        button.Text = text;
                    }
                    break;
                case "System.Windows.Forms.Label":
                    Label label = (Label)Convert.ChangeType(component, typeof(C));
                    if (label.InvokeRequired)
                    {
                        var d = new SafeCallDelegateComponentText<C>(WriteAttributeThreadSafe);
                        label.Invoke(d, new object[] { component, text });
                    }
                    else
                    {
                        label.Text = text;
                    }
                    break;
                case "System.Windows.Forms.ComboBox":
                    ComboBox comboBox = (ComboBox)Convert.ChangeType(component, typeof(C));
                    if (comboBox.InvokeRequired)
                    {
                        var d = new SafeCallDelegateComponentText<C>(WriteAttributeThreadSafe);
                        comboBox.Invoke(d, new object[] { component, text });
                    }
                    else
                    {
                        comboBox.Text = text;
                    }
                    break;
                case "System.Windows.Forms.GroupBox":
                    GroupBox groupBox = (GroupBox)Convert.ChangeType(component, typeof(C));
                    if (groupBox.InvokeRequired)
                    {
                        var d = new SafeCallDelegateComponentText<C>(WriteAttributeThreadSafe);
                        groupBox.Invoke(d, new object[] { component, text });
                    }
                    else
                    {
                        groupBox.Text = text;
                    }
                    break;
                case "System.Windows.Forms.PictureBox":
                    PictureBox pictureBox = (PictureBox)Convert.ChangeType(component, typeof(C));
                    if (pictureBox.InvokeRequired)
                    {
                        var d = new SafeCallDelegateComponentText<C>(WriteAttributeThreadSafe);
                        pictureBox.Invoke(d, new object[] { component, text });
                    }
                    else
                    {
                        pictureBox.Text = text;
                    }
                    break;
                case "System.Windows.Forms.TextBox":
                    TextBox textBox = (TextBox)Convert.ChangeType(component, typeof(C));
                    if (textBox.InvokeRequired)
                    {
                        var d = new SafeCallDelegateComponentText<C>(WriteAttributeThreadSafe);
                        textBox.Invoke(d, new object[] { component, text });
                    }
                    else
                    {
                        textBox.Text = text;
                    }
                    break;
                
                default:
                    // Do nothing.
                    break;
            }
        }
        /// <summary>
        /// An overloaded method that sets the foreground and background colors of the given component.
        /// </summary>
        /// <typeparam name="C">The type of component, i.e. Button, Label, etc.</typeparam>
        /// <param name="component">The specific component we wish to change.</param>
        public void WriteAttributeThreadSafe<C>(ref C component, Color foreground, Color background)
        {
            //SafeCallDelegateSetColors

            switch (typeof(C).ToString())
            {
                case "System.Windows.Forms.Button":
                    Button button = (Button)Convert.ChangeType(component, typeof(C));
                    if (button.InvokeRequired)
                    {
                        var d = new SafeCallDelegateSetColors<C>(WriteAttributeThreadSafe);
                        button.Invoke(d, new object[] { component, foreground, background });
                    }
                    else
                    {
                        button.ForeColor = foreground;
                        button.BackColor = background;
                    }
                    break;
                case "System.Windows.Forms.Label":
                    Label label = (Label)Convert.ChangeType(component, typeof(C));
                    if (label.InvokeRequired)
                    {
                        var d = new SafeCallDelegateSetColors<C>(WriteAttributeThreadSafe);
                        label.Invoke(d, new object[] { component, foreground, background });
                    }
                    else
                    {
                        label.ForeColor = foreground;
                        label.BackColor = background;
                    }
                    break;
                case "System.Windows.Forms.ComboBox":
                    ComboBox comboBox = (ComboBox)Convert.ChangeType(component, typeof(C));
                    if (comboBox.InvokeRequired)
                    {
                        var d = new SafeCallDelegateSetColors<C>(WriteAttributeThreadSafe);
                        comboBox.Invoke(d, new object[] { component, foreground, background });
                    }
                    else
                    {
                        comboBox.ForeColor = foreground;
                        comboBox.BackColor = background;
                    }
                    break;
                case "System.Windows.Forms.GroupBox":
                    GroupBox groupBox = (GroupBox)Convert.ChangeType(component, typeof(C));
                    if (groupBox.InvokeRequired)
                    {
                        var d = new SafeCallDelegateSetColors<C>(WriteAttributeThreadSafe);
                        groupBox.Invoke(d, new object[] { component, foreground, background });
                    }
                    else
                    {
                        groupBox.ForeColor = foreground;
                        groupBox.BackColor = background;
                    }
                    break;
                case "System.Windows.Forms.PictureBox":
                    PictureBox pictureBox = (PictureBox)Convert.ChangeType(component, typeof(C));
                    if (pictureBox.InvokeRequired)
                    {
                        var d = new SafeCallDelegateSetColors<C>(WriteAttributeThreadSafe);
                        pictureBox.Invoke(d, new object[] { component, foreground, background });
                    }
                    else
                    {
                        pictureBox.ForeColor = foreground;
                        pictureBox.BackColor = background;
                    }
                    break;
                case "System.Windows.Forms.TextBox":
                    TextBox textBox = (TextBox)Convert.ChangeType(component, typeof(C));
                    if (textBox.InvokeRequired)
                    {
                        var d = new SafeCallDelegateSetColors<C>(WriteAttributeThreadSafe);
                        textBox.Invoke(d, new object[] { component, foreground, background });
                    }
                    else
                    {
                        textBox.ForeColor = foreground;
                        textBox.BackColor = background;
                    }
                    break;
                default:
                    // Do nothing.
                    break;
            }
        }

        #endregion
    
    

        public ThreadSaveControls()
        {
            InitializeComponent();
        }




        //we will not be loading this form, so dont add anything to this area
        private void ThreadSaveControls_Load(object sender, EventArgs e)
        {

        }
    }
}
