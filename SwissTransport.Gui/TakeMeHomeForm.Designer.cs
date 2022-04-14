namespace SwissTransport.Gui
{
    partial class TakeMeHomeSettingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.homeForm = new System.Windows.Forms.GroupBox();
            this.homeStopInput = new System.Windows.Forms.ComboBox();
            this.saveHomeButton = new System.Windows.Forms.Button();
            this.homeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home Stop:";
            // 
            // homeForm
            // 
            this.homeForm.Controls.Add(this.homeStopInput);
            this.homeForm.Controls.Add(this.saveHomeButton);
            this.homeForm.Controls.Add(this.label1);
            this.homeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeForm.Location = new System.Drawing.Point(0, 0);
            this.homeForm.Name = "homeForm";
            this.homeForm.Size = new System.Drawing.Size(336, 59);
            this.homeForm.TabIndex = 2;
            this.homeForm.TabStop = false;
            this.homeForm.Text = "Change Home Stop";
            // 
            // homeStopInput
            // 
            this.homeStopInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.homeStopInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.homeStopInput.FormattingEnabled = true;
            this.homeStopInput.Location = new System.Drawing.Point(88, 20);
            this.homeStopInput.Name = "homeStopInput";
            this.homeStopInput.Size = new System.Drawing.Size(155, 23);
            this.homeStopInput.TabIndex = 3;
            this.homeStopInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HomeStopInputKeyUp);
            // 
            // saveHomeButton
            // 
            this.saveHomeButton.Location = new System.Drawing.Point(249, 20);
            this.saveHomeButton.Name = "saveHomeButton";
            this.saveHomeButton.Size = new System.Drawing.Size(75, 24);
            this.saveHomeButton.TabIndex = 2;
            this.saveHomeButton.Text = "Save";
            this.saveHomeButton.UseVisualStyleBackColor = true;
            this.saveHomeButton.Click += new System.EventHandler(this.SaveHomeStop);
            // 
            // TakeMeHomeSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 59);
            this.Controls.Add(this.homeForm);
            this.Name = "TakeMeHomeSettingsForm";
            this.Text = "Take Me Home Settings";
            this.homeForm.ResumeLayout(false);
            this.homeForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private GroupBox homeForm;
        private Button saveHomeButton;
        private ComboBox homeStopInput;
    }
}