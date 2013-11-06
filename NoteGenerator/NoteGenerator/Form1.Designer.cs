namespace NoteGenerator
    {
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.button1 = new System.Windows.Forms.Button();
            this.ppBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.recordBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.freqText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Audio File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openAudioFile);
            // 
            // ppBtn
            // 
            this.ppBtn.Enabled = false;
            this.ppBtn.Location = new System.Drawing.Point(12, 127);
            this.ppBtn.Name = "ppBtn";
            this.ppBtn.Size = new System.Drawing.Size(116, 23);
            this.ppBtn.TabIndex = 1;
            this.ppBtn.Text = "play/pouse";
            this.ppBtn.UseVisualStyleBackColor = true;
            this.ppBtn.Click += new System.EventHandler(this.ppBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 82);
            this.listBox1.TabIndex = 2;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(244, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 42);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "refresh devices";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(343, 12);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(95, 23);
            this.recordBtn.TabIndex = 4;
            this.recordBtn.Text = "Record Stream";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "RecordToWave";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.recordAudioFile);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(12, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 221);
            this.panel1.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(585, 221);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // freqText
            // 
            this.freqText.AutoSize = true;
            this.freqText.Location = new System.Drawing.Point(504, 63);
            this.freqText.Name = "freqText";
            this.freqText.Size = new System.Drawing.Size(35, 13);
            this.freqText.TabIndex = 9;
            this.freqText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 431);
            this.Controls.Add(this.freqText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ppBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ppBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label freqText;
        }
    }

