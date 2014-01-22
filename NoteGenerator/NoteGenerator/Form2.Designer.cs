namespace NoteGenerator
    {
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listDevices = new System.Windows.Forms.ListBox();
            this.freqLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.seveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveFileNoteDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileNoteDialog = new System.Windows.Forms.OpenFileDialog();
            this.radioButtonRecorder = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.noteView2 = new NoteGenerator.MusicNoteWriter();
            this.noteView = new NoteGenerator.MusicNoteWriter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Słuchaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.recordStream);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zatrzymaj nasłuchiwanie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.stopListening);
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.Location = new System.Drawing.Point(12, 27);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(259, 173);
            this.listDevices.TabIndex = 2;
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.Location = new System.Drawing.Point(12, 203);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(76, 13);
            this.freqLabel.TabIndex = 3;
            this.freqLabel.Text = "Częstotliwości:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 223);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(481, 131);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // seveButton
            // 
            this.seveButton.Location = new System.Drawing.Point(418, 34);
            this.seveButton.Name = "seveButton";
            this.seveButton.Size = new System.Drawing.Size(75, 23);
            this.seveButton.TabIndex = 6;
            this.seveButton.Text = "Zapisz";
            this.seveButton.UseVisualStyleBackColor = true;
            this.seveButton.Click += new System.EventHandler(this.seveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(418, 63);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Odtwórz";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openFileNoteDialog
            // 
            this.openFileNoteDialog.FileName = "openFileDialog1";
            // 
            // radioButtonRecorder
            // 
            this.radioButtonRecorder.AutoSize = true;
            this.radioButtonRecorder.Checked = true;
            this.radioButtonRecorder.Location = new System.Drawing.Point(511, 34);
            this.radioButtonRecorder.Name = "radioButtonRecorder";
            this.radioButtonRecorder.Size = new System.Drawing.Size(103, 17);
            this.radioButtonRecorder.TabIndex = 8;
            this.radioButtonRecorder.TabStop = true;
            this.radioButtonRecorder.Text = "Nuty z nasłuchu";
            this.radioButtonRecorder.UseVisualStyleBackColor = true;
            this.radioButtonRecorder.CheckedChanged += new System.EventHandler(this.radioButtonRecorder_CheckedChanged);
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Enabled = false;
            this.radioButtonOpen.Location = new System.Drawing.Point(648, 34);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(99, 17);
            this.radioButtonOpen.TabIndex = 9;
            this.radioButtonOpen.Text = "Wczytane nuty:";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.loadFile);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(12, 374);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(481, 118);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // noteView2
            // 
            this.noteView2.Location = new System.Drawing.Point(511, 57);
            this.noteView2.Name = "noteView2";
            this.noteView2.Size = new System.Drawing.Size(738, 152);
            this.noteView2.TabIndex = 10;
            this.noteView2.Visible = false;
            // 
            // noteView
            // 
            this.noteView.Location = new System.Drawing.Point(511, 57);
            this.noteView.Name = "noteView";
            this.noteView.Size = new System.Drawing.Size(738, 152);
            this.noteView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wizualizacja Wave";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1271, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteView2);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.radioButtonRecorder);
            this.Controls.Add(this.noteView);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.seveButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.freqLabel);
            this.Controls.Add(this.listDevices);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private NoteGenerator.MusicNoteWriter noteView;
        private System.Windows.Forms.Button seveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.SaveFileDialog saveFileNoteDialog;
        private System.Windows.Forms.OpenFileDialog openFileNoteDialog;
        private System.Windows.Forms.RadioButton radioButtonRecorder;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private NoteGenerator.MusicNoteWriter noteView2;


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;

        }
    }