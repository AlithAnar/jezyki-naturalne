﻿namespace NoteGenerator
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
            this.noteView2 = new NoteGenerator.MusicNoteWriter();
            this.noteView = new NoteGenerator.MusicNoteWriter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "listen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.recordStream);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.stopListening);
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.Location = new System.Drawing.Point(12, 12);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(259, 173);
            this.listDevices.TabIndex = 2;
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.Location = new System.Drawing.Point(284, 14);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(42, 13);
            this.freqLabel.TabIndex = 3;
            this.freqLabel.Text = "FREQ: ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 223);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(481, 194);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // seveButton
            // 
            this.seveButton.Location = new System.Drawing.Point(397, 70);
            this.seveButton.Name = "seveButton";
            this.seveButton.Size = new System.Drawing.Size(75, 23);
            this.seveButton.TabIndex = 6;
            this.seveButton.Text = "Zapisz";
            this.seveButton.UseVisualStyleBackColor = true;
            this.seveButton.Click += new System.EventHandler(this.seveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(397, 99);
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
            this.radioButtonRecorder.Size = new System.Drawing.Size(95, 17);
            this.radioButtonRecorder.TabIndex = 8;
            this.radioButtonRecorder.TabStop = true;
            this.radioButtonRecorder.Text = "Recorder Note";
            this.radioButtonRecorder.UseVisualStyleBackColor = true;
            this.radioButtonRecorder.CheckedChanged += new System.EventHandler(this.radioButtonRecorder_CheckedChanged);
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Enabled = false;
            this.radioButtonOpen.Location = new System.Drawing.Point(648, 34);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(77, 17);
            this.radioButtonOpen.TabIndex = 9;
            this.radioButtonOpen.Text = "Open Note";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 616);
            this.Controls.Add(this.noteView2);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.radioButtonRecorder);
            this.Controls.Add(this.noteView);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.seveButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.freqLabel);
            this.Controls.Add(this.listDevices);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        }
    }