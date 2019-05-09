namespace Oreilly_Csharp_ch6_PartyPlanner_3_P274
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DinnerPartyTab = new System.Windows.Forms.TabPage();
            this.DinnerCostLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DinnerHealthyCheak = new System.Windows.Forms.CheckBox();
            this.DinnerFancyCheck = new System.Windows.Forms.CheckBox();
            this.NumberDinnerChange = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.BirthdayPartyTab = new System.Windows.Forms.TabPage();
            this.TooLongLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayCostLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthdayFancyCheck = new System.Windows.Forms.CheckBox();
            this.NumberBirthdayChange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DinnerPartyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberDinnerChange)).BeginInit();
            this.BirthdayPartyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberBirthdayChange)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.DinnerPartyTab);
            this.tabControl1.Controls.Add(this.BirthdayPartyTab);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(217, 260);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 6;
            // 
            // DinnerPartyTab
            // 
            this.DinnerPartyTab.Controls.Add(this.DinnerCostLabel);
            this.DinnerPartyTab.Controls.Add(this.label4);
            this.DinnerPartyTab.Controls.Add(this.DinnerHealthyCheak);
            this.DinnerPartyTab.Controls.Add(this.DinnerFancyCheck);
            this.DinnerPartyTab.Controls.Add(this.NumberDinnerChange);
            this.DinnerPartyTab.Controls.Add(this.label5);
            this.DinnerPartyTab.Font = new System.Drawing.Font("新細明體", 12F);
            this.DinnerPartyTab.Location = new System.Drawing.Point(4, 26);
            this.DinnerPartyTab.Name = "DinnerPartyTab";
            this.DinnerPartyTab.Padding = new System.Windows.Forms.Padding(3);
            this.DinnerPartyTab.Size = new System.Drawing.Size(209, 230);
            this.DinnerPartyTab.TabIndex = 0;
            this.DinnerPartyTab.Text = "Dinner Party";
            this.DinnerPartyTab.UseVisualStyleBackColor = true;
            // 
            // DinnerCostLabel
            // 
            this.DinnerCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DinnerCostLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.DinnerCostLabel.Location = new System.Drawing.Point(9, 159);
            this.DinnerCostLabel.Name = "DinnerCostLabel";
            this.DinnerCostLabel.Size = new System.Drawing.Size(178, 32);
            this.DinnerCostLabel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // DinnerHealthyCheak
            // 
            this.DinnerHealthyCheak.AutoSize = true;
            this.DinnerHealthyCheak.Font = new System.Drawing.Font("新細明體", 12F);
            this.DinnerHealthyCheak.Location = new System.Drawing.Point(9, 100);
            this.DinnerHealthyCheak.Name = "DinnerHealthyCheak";
            this.DinnerHealthyCheak.Size = new System.Drawing.Size(159, 20);
            this.DinnerHealthyCheak.TabIndex = 9;
            this.DinnerHealthyCheak.Text = "Healthy Decorations ";
            this.DinnerHealthyCheak.UseVisualStyleBackColor = true;
            this.DinnerHealthyCheak.CheckedChanged += new System.EventHandler(this.DinnerHealthyCheak_CheckedChanged);
            // 
            // DinnerFancyCheck
            // 
            this.DinnerFancyCheck.AutoSize = true;
            this.DinnerFancyCheck.Font = new System.Drawing.Font("新細明體", 12F);
            this.DinnerFancyCheck.Location = new System.Drawing.Point(9, 74);
            this.DinnerFancyCheck.Name = "DinnerFancyCheck";
            this.DinnerFancyCheck.Size = new System.Drawing.Size(144, 20);
            this.DinnerFancyCheck.TabIndex = 8;
            this.DinnerFancyCheck.Text = "Fancy Decorations";
            this.DinnerFancyCheck.UseVisualStyleBackColor = true;
            this.DinnerFancyCheck.CheckedChanged += new System.EventHandler(this.DinnerFancyCheck_CheckedChanged);
            // 
            // NumberDinnerChange
            // 
            this.NumberDinnerChange.Font = new System.Drawing.Font("新細明體", 12F);
            this.NumberDinnerChange.Location = new System.Drawing.Point(20, 41);
            this.NumberDinnerChange.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberDinnerChange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberDinnerChange.Name = "NumberDinnerChange";
            this.NumberDinnerChange.Size = new System.Drawing.Size(167, 27);
            this.NumberDinnerChange.TabIndex = 7;
            this.NumberDinnerChange.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberDinnerChange.ValueChanged += new System.EventHandler(this.NumberDinnerChange_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of People";
            // 
            // BirthdayPartyTab
            // 
            this.BirthdayPartyTab.Controls.Add(this.TooLongLabel);
            this.BirthdayPartyTab.Controls.Add(this.label6);
            this.BirthdayPartyTab.Controls.Add(this.BirthdayTextBox);
            this.BirthdayPartyTab.Controls.Add(this.BirthdayCostLabel);
            this.BirthdayPartyTab.Controls.Add(this.label2);
            this.BirthdayPartyTab.Controls.Add(this.BirthdayFancyCheck);
            this.BirthdayPartyTab.Controls.Add(this.NumberBirthdayChange);
            this.BirthdayPartyTab.Controls.Add(this.label1);
            this.BirthdayPartyTab.Font = new System.Drawing.Font("新細明體", 12F);
            this.BirthdayPartyTab.Location = new System.Drawing.Point(4, 26);
            this.BirthdayPartyTab.Name = "BirthdayPartyTab";
            this.BirthdayPartyTab.Padding = new System.Windows.Forms.Padding(3);
            this.BirthdayPartyTab.Size = new System.Drawing.Size(209, 230);
            this.BirthdayPartyTab.TabIndex = 1;
            this.BirthdayPartyTab.Text = "Birthday Party";
            this.BirthdayPartyTab.UseVisualStyleBackColor = true;
            // 
            // TooLongLabel
            // 
            this.TooLongLabel.AutoSize = true;
            this.TooLongLabel.BackColor = System.Drawing.Color.Red;
            this.TooLongLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.TooLongLabel.Location = new System.Drawing.Point(103, 102);
            this.TooLongLabel.Name = "TooLongLabel";
            this.TooLongLabel.Size = new System.Drawing.Size(85, 16);
            this.TooLongLabel.TabIndex = 14;
            this.TooLongLabel.Text = "TOO LONG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cake Writing";
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Location = new System.Drawing.Point(9, 121);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.Size = new System.Drawing.Size(179, 27);
            this.BirthdayTextBox.TabIndex = 12;
            this.BirthdayTextBox.Text = "Happy Birthday";
            this.BirthdayTextBox.TextChanged += new System.EventHandler(this.CakeWriting_TextChanged);
            // 
            // BirthdayCostLabel
            // 
            this.BirthdayCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BirthdayCostLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.BirthdayCostLabel.Location = new System.Drawing.Point(9, 178);
            this.BirthdayCostLabel.Name = "BirthdayCostLabel";
            this.BirthdayCostLabel.Size = new System.Drawing.Size(179, 28);
            this.BirthdayCostLabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // BirthdayFancyCheck
            // 
            this.BirthdayFancyCheck.AutoSize = true;
            this.BirthdayFancyCheck.Font = new System.Drawing.Font("新細明體", 12F);
            this.BirthdayFancyCheck.Location = new System.Drawing.Point(9, 74);
            this.BirthdayFancyCheck.Name = "BirthdayFancyCheck";
            this.BirthdayFancyCheck.Size = new System.Drawing.Size(144, 20);
            this.BirthdayFancyCheck.TabIndex = 8;
            this.BirthdayFancyCheck.Text = "Fancy Decorations";
            this.BirthdayFancyCheck.UseVisualStyleBackColor = true;
            this.BirthdayFancyCheck.CheckedChanged += new System.EventHandler(this.BirthdayFancyCheck_CheckedChanged);
            // 
            // NumberBirthdayChange
            // 
            this.NumberBirthdayChange.Font = new System.Drawing.Font("新細明體", 12F);
            this.NumberBirthdayChange.Location = new System.Drawing.Point(20, 41);
            this.NumberBirthdayChange.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberBirthdayChange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberBirthdayChange.Name = "NumberBirthdayChange";
            this.NumberBirthdayChange.Size = new System.Drawing.Size(168, 27);
            this.NumberBirthdayChange.TabIndex = 7;
            this.NumberBirthdayChange.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberBirthdayChange.ValueChanged += new System.EventHandler(this.NumberBirthdayChange_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 299);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner V2.0";
            this.tabControl1.ResumeLayout(false);
            this.DinnerPartyTab.ResumeLayout(false);
            this.DinnerPartyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberDinnerChange)).EndInit();
            this.BirthdayPartyTab.ResumeLayout(false);
            this.BirthdayPartyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberBirthdayChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DinnerPartyTab;
        private System.Windows.Forms.Label DinnerCostLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox DinnerHealthyCheak;
        private System.Windows.Forms.CheckBox DinnerFancyCheck;
        private System.Windows.Forms.NumericUpDown NumberDinnerChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage BirthdayPartyTab;
        private System.Windows.Forms.Label TooLongLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BirthdayTextBox;
        private System.Windows.Forms.Label BirthdayCostLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox BirthdayFancyCheck;
        private System.Windows.Forms.NumericUpDown NumberBirthdayChange;
        private System.Windows.Forms.Label label1;
    }
}

