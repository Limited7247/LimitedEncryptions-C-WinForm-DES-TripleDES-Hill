namespace LimitedEncryptions.Views
{
    partial class HillCipher
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtPlainText = new System.Windows.Forms.RichTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPlaintTextsCounter = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExecuteSingleKey = new DevExpress.XtraEditors.SimpleButton();
            this.txtKeys = new System.Windows.Forms.RichTextBox();
            this.txtKeysCounter = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtKey = new System.Windows.Forms.RichTextBox();
            this.btnGetAndExecuteNewSingleKey = new DevExpress.XtraEditors.SimpleButton();
            this.txtCipherText = new System.Windows.Forms.RichTextBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.txtPlainTextDecrypt = new System.Windows.Forms.RichTextBox();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.txtInverseKey = new System.Windows.Forms.RichTextBox();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.txtCustomKey = new System.Windows.Forms.RichTextBox();
            this.groupControl10 = new DevExpress.XtraEditors.GroupControl();
            this.txtDictionary = new System.Windows.Forms.RichTextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).BeginInit();
            this.groupControl10.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(5, 52);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(494, 157);
            this.txtPlainText.TabIndex = 0;
            this.txtPlainText.Text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.simpleButton9);
            this.groupControl1.Controls.Add(this.txtPlaintTextsCounter);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txtPlainText);
            this.groupControl1.Location = new System.Drawing.Point(300, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 220);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Bản rõ";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Location = new System.Drawing.Point(5, 23);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(90, 23);
            this.simpleButton9.TabIndex = 4;
            this.simpleButton9.Text = "Mở File";
            this.simpleButton9.Click += new System.EventHandler(this.btnReadFile_click);
            // 
            // txtPlaintTextsCounter
            // 
            this.txtPlaintTextsCounter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPlaintTextsCounter.Location = new System.Drawing.Point(347, 28);
            this.txtPlaintTextsCounter.Name = "txtPlaintTextsCounter";
            this.txtPlaintTextsCounter.Size = new System.Drawing.Size(34, 13);
            this.txtPlaintTextsCounter.TabIndex = 2;
            this.txtPlaintTextsCounter.Text = "00/00";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(403, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Sau";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(235, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Trước";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.simpleButton8);
            this.groupControl2.Controls.Add(this.btnExecuteSingleKey);
            this.groupControl2.Controls.Add(this.txtKeys);
            this.groupControl2.Controls.Add(this.txtKeysCounter);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Location = new System.Drawing.Point(12, 66);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(135, 220);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Bộ khóa ngẫu nhiên";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Location = new System.Drawing.Point(5, 160);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(125, 23);
            this.simpleButton8.TabIndex = 8;
            this.simpleButton8.Text = "Lấy bộ mã ng.nhiên";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // btnExecuteSingleKey
            // 
            this.btnExecuteSingleKey.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExecuteSingleKey.Appearance.Options.UseFont = true;
            this.btnExecuteSingleKey.Location = new System.Drawing.Point(5, 189);
            this.btnExecuteSingleKey.Name = "btnExecuteSingleKey";
            this.btnExecuteSingleKey.Size = new System.Drawing.Size(125, 23);
            this.btnExecuteSingleKey.TabIndex = 7;
            this.btnExecuteSingleKey.Text = "Thực hiện";
            this.btnExecuteSingleKey.Click += new System.EventHandler(this.btnExecuteSingleKey_Click);
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(5, 55);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.ReadOnly = true;
            this.txtKeys.Size = new System.Drawing.Size(125, 102);
            this.txtKeys.TabIndex = 7;
            this.txtKeys.Text = "";
            // 
            // txtKeysCounter
            // 
            this.txtKeysCounter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtKeysCounter.Location = new System.Drawing.Point(52, 28);
            this.txtKeysCounter.Name = "txtKeysCounter";
            this.txtKeysCounter.Size = new System.Drawing.Size(34, 13);
            this.txtKeysCounter.TabIndex = 2;
            this.txtKeysCounter.Text = "00/00";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(104, 23);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(26, 23);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = ">";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(5, 23);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(24, 23);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "<";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.txtKey);
            this.groupControl3.Controls.Add(this.btnGetAndExecuteNewSingleKey);
            this.groupControl3.Location = new System.Drawing.Point(159, 66);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(135, 220);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Khóa ngẫu nhiên";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(5, 55);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(125, 102);
            this.txtKey.TabIndex = 6;
            this.txtKey.Text = "";
            // 
            // btnGetAndExecuteNewSingleKey
            // 
            this.btnGetAndExecuteNewSingleKey.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAndExecuteNewSingleKey.Appearance.Options.UseFont = true;
            this.btnGetAndExecuteNewSingleKey.Location = new System.Drawing.Point(5, 160);
            this.btnGetAndExecuteNewSingleKey.Name = "btnGetAndExecuteNewSingleKey";
            this.btnGetAndExecuteNewSingleKey.Size = new System.Drawing.Size(125, 52);
            this.btnGetAndExecuteNewSingleKey.TabIndex = 5;
            this.btnGetAndExecuteNewSingleKey.Text = "Lấy mã\r\nvà Thực hiện";
            this.btnGetAndExecuteNewSingleKey.Click += new System.EventHandler(this.btnGetAndExecuteNewSingleKey_Click);
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(5, 23);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.ReadOnly = true;
            this.txtCipherText.Size = new System.Drawing.Size(494, 192);
            this.txtCipherText.TabIndex = 4;
            this.txtCipherText.Text = "";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.txtCipherText);
            this.groupControl4.Location = new System.Drawing.Point(300, 238);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(504, 223);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "Bản mã";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.Controls.Add(this.richTextBox2);
            this.groupControl5.Location = new System.Drawing.Point(12, 467);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(135, 186);
            this.groupControl5.TabIndex = 7;
            this.groupControl5.Text = "Thống kê t. văn bản";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(5, 21);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(125, 159);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // groupControl6
            // 
            this.groupControl6.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl6.AppearanceCaption.Options.UseFont = true;
            this.groupControl6.Controls.Add(this.richTextBox1);
            this.groupControl6.Location = new System.Drawing.Point(159, 467);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(135, 186);
            this.groupControl6.TabIndex = 8;
            this.groupControl6.Text = "Thống kê theo khóa";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(125, 157);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(12, 12);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(282, 48);
            this.simpleButton7.TabIndex = 7;
            this.simpleButton7.Text = "THỰC HIỆN THỐNG KÊ";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(810, 453);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(344, 200);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(810, 238);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(344, 200);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // groupControl7
            // 
            this.groupControl7.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl7.AppearanceCaption.Options.UseFont = true;
            this.groupControl7.Controls.Add(this.txtPlainTextDecrypt);
            this.groupControl7.Location = new System.Drawing.Point(300, 467);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(504, 186);
            this.groupControl7.TabIndex = 11;
            this.groupControl7.Text = "Bản rõ";
            // 
            // txtPlainTextDecrypt
            // 
            this.txtPlainTextDecrypt.Location = new System.Drawing.Point(5, 23);
            this.txtPlainTextDecrypt.Name = "txtPlainTextDecrypt";
            this.txtPlainTextDecrypt.ReadOnly = true;
            this.txtPlainTextDecrypt.Size = new System.Drawing.Size(494, 157);
            this.txtPlainTextDecrypt.TabIndex = 4;
            this.txtPlainTextDecrypt.Text = "";
            // 
            // groupControl8
            // 
            this.groupControl8.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl8.AppearanceCaption.Options.UseFont = true;
            this.groupControl8.Controls.Add(this.txtInverseKey);
            this.groupControl8.Location = new System.Drawing.Point(159, 292);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(135, 169);
            this.groupControl8.TabIndex = 12;
            this.groupControl8.Text = "Khóa nghịch đảo";
            // 
            // txtInverseKey
            // 
            this.txtInverseKey.Location = new System.Drawing.Point(5, 24);
            this.txtInverseKey.Name = "txtInverseKey";
            this.txtInverseKey.ReadOnly = true;
            this.txtInverseKey.Size = new System.Drawing.Size(125, 108);
            this.txtInverseKey.TabIndex = 6;
            this.txtInverseKey.Text = "";
            // 
            // groupControl9
            // 
            this.groupControl9.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl9.AppearanceCaption.Options.UseFont = true;
            this.groupControl9.Controls.Add(this.simpleButton5);
            this.groupControl9.Controls.Add(this.txtCustomKey);
            this.groupControl9.Location = new System.Drawing.Point(12, 292);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(135, 169);
            this.groupControl9.TabIndex = 13;
            this.groupControl9.Text = "Khóa tự nhập";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(5, 138);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(125, 23);
            this.simpleButton5.TabIndex = 9;
            this.simpleButton5.Text = "Thực hiện";
            this.simpleButton5.Click += new System.EventHandler(this.btnExecuteCustom_Click);
            // 
            // txtCustomKey
            // 
            this.txtCustomKey.Location = new System.Drawing.Point(5, 24);
            this.txtCustomKey.Name = "txtCustomKey";
            this.txtCustomKey.Size = new System.Drawing.Size(125, 108);
            this.txtCustomKey.TabIndex = 6;
            this.txtCustomKey.Text = "";
            // 
            // groupControl10
            // 
            this.groupControl10.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl10.AppearanceCaption.Options.UseFont = true;
            this.groupControl10.Controls.Add(this.txtDictionary);
            this.groupControl10.Location = new System.Drawing.Point(810, 12);
            this.groupControl10.Name = "groupControl10";
            this.groupControl10.Size = new System.Drawing.Size(344, 220);
            this.groupControl10.TabIndex = 14;
            this.groupControl10.Text = "Từ điển ký tự";
            // 
            // txtDictionary
            // 
            this.txtDictionary.Location = new System.Drawing.Point(5, 23);
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.ReadOnly = true;
            this.txtDictionary.Size = new System.Drawing.Size(334, 186);
            this.txtDictionary.TabIndex = 6;
            this.txtDictionary.Text = "";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // HillCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 663);
            this.Controls.Add(this.groupControl10);
            this.Controls.Add(this.groupControl9);
            this.Controls.Add(this.groupControl8);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "HillCipher";
            this.Text = "HillCipher";
            this.Load += new System.EventHandler(this.HillCipher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).EndInit();
            this.groupControl10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPlainText;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl txtPlaintTextsCounter;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl txtKeysCounter;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnGetAndExecuteNewSingleKey;
        private System.Windows.Forms.RichTextBox txtCipherText;
        private System.Windows.Forms.RichTextBox txtKey;
        private System.Windows.Forms.RichTextBox txtKeys;
        private DevExpress.XtraEditors.SimpleButton btnExecuteSingleKey;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private System.Windows.Forms.RichTextBox txtPlainTextDecrypt;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private System.Windows.Forms.RichTextBox txtInverseKey;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private System.Windows.Forms.RichTextBox txtCustomKey;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.GroupControl groupControl10;
        private System.Windows.Forms.RichTextBox txtDictionary;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}