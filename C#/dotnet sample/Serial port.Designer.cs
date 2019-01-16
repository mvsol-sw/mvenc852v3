namespace mvenc852_test_win
{
    partial class Serial_port
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serial_port));
            this.comboBox_selectport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_selectport
            // 
            this.comboBox_selectport.FormattingEnabled = true;
            this.comboBox_selectport.Location = new System.Drawing.Point(94, 30);
            this.comboBox_selectport.Name = "comboBox_selectport";
            this.comboBox_selectport.Size = new System.Drawing.Size(121, 20);
            this.comboBox_selectport.TabIndex = 0;
            this.comboBox_selectport.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "PortName";
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(140, 64);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 2;
            this.button_Ok.Text = "확인";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // Serial_port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 98);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_selectport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Serial_port";
            this.Text = "Serial_port";
            this.Load += new System.EventHandler(this.Serial_port_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Ok;
        public System.Windows.Forms.ComboBox comboBox_selectport;
    }
}