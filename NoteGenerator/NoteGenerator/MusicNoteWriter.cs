using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoteGenerator
{
    public class noteFrequencyAndPosition
    {
        public double startFrequency;
        public double endFrequency;
        public int position;
        public bool increase;
        public string clef;

        public noteFrequencyAndPosition(double startFrequency, double endFrequency, int position, bool increase, string clef)
        {
            this.startFrequency = startFrequency;
            this.endFrequency = endFrequency;
            this.position = position;
            this.increase = increase;
            this.clef = clef;
        }
    }

    public partial class MusicNoteWriter : Control
    {
        List<noteFrequencyAndPosition> notePositions;
        public List<double> hzs;
        public List<noteFrequencyAndPosition> notes;
        public MusicNoteWriter()
        {
            this.hzs = new List<double>();
            this.notes = new List<noteFrequencyAndPosition>();
            notePositions = new List<noteFrequencyAndPosition>();
            notePositions.Add(new noteFrequencyAndPosition(127.141805, 134.7020505, 55, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(134.7020505, 142.711851, 55, true, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(142.711851, 151.197939, 50, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(151.197939, 160.1886365, 50, true, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(160.1886365, 169.713949, 45, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(169.713949, 179.8056655, 40, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(179.8056655, 190.4974665, 40, true, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(190.4974665, 201.8250355, 35, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(201.82503555, 213.8261765, 35, true, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(213.8261765, 226.5409425, 30, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(226.540942, 240.011768, 30, true, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(240.011768, 254.2836105, 25, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(254.2836105, 269.404101, 20, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(269.404101, 285.4237025, 20, true, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(285.4237025, 302.395879, 15, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(302.395879, 320.3772735, 15, true, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(320.3772735, 339.4278975, 10, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(339.4278975, 359.611331, 5, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(359.611331, 380.99493351, 5, true, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(380.99493351, 403.650071, 0, false, "Treble"));
            notePositions.Add(new noteFrequencyAndPosition(403.650071, 427.6523535, 0, true, "Treble"));


            notePositions.Add(new noteFrequencyAndPosition(84.8569745, 89.902833, 120, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(89.902833, 95.2487335, 120, true, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(95.2487335, 100.9125175, 115, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(100.9125175, 106.913088, 115, true, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(106.913088, 113.2704715, 110, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(113.2704715, 120.0058845, 110, true, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(120.0058845, 127.1418055, 105, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(127.141805, 134.7020505, 100, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(134.7020505, 142.711851, 100, true, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(142.711851, 151.197939, 95, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(151.197939, 160.1886365, 95, true, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(160.1886365, 169.713949, 90, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(169.713949, 179.8056655, 85, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(179.8056655, 190.4974665, 85, true, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(190.4974665, 201.8250355, 80, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(201.82503555, 213.8261765, 80, true, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(213.8261765, 226.5409425, 75, false, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(226.540942, 240.011768, 75, true, "Bas"));
            notePositions.Add(new noteFrequencyAndPosition(240.011768, 254.2836105, 70, false, "Bas"));



            InitializeComponent();
        }

        public int AddNote(double frequency)
        {

            for (int i = 0; i < notePositions.Count; i++)
            {
                if (frequency > notePositions[i].startFrequency && frequency <= notePositions[i].endFrequency)
                {
                    notes.Add(notePositions[i]);
                }
            }
            return -1;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Image G_clef = Properties.Resources.G_clef;
            Image F_clef = Properties.Resources.F_clef;
            Image half = Properties.Resources._1_2;
            Image increase = Properties.Resources.increase;

            Graphics newo = pe.Graphics;
            Pen blackPen = new Pen(Color.Gray, 2);
            // Draw rectangle to screen.


            int startX = 0;
            int startY = 0;
            newo.DrawLine(blackPen, new Point(0, startY + 24), new Point(this.Width, startY + 24));
            newo.DrawLine(blackPen, new Point(0, startY + 34), new Point(this.Width, startY + 34));
            newo.DrawLine(blackPen, new Point(0, startY + 44), new Point(this.Width, startY + 44));
            newo.DrawLine(blackPen, new Point(0, startY + 54), new Point(this.Width, startY + 54));
            newo.DrawLine(blackPen, new Point(0, startY + 64), new Point(this.Width, startY + 64));
            newo.DrawImage(G_clef, new Point(0, 10));

            newo.DrawLine(blackPen, new Point(0, startY + 94), new Point(this.Width, startY + 94));
            newo.DrawLine(blackPen, new Point(0, startY + 104), new Point(this.Width, startY + 104));
            newo.DrawLine(blackPen, new Point(0, startY + 114), new Point(this.Width, startY + 114));
            newo.DrawLine(blackPen, new Point(0, startY + 124), new Point(this.Width, startY + 124));
            newo.DrawLine(blackPen, new Point(0, startY + 134), new Point(this.Width, startY + 134));
            newo.DrawImage(F_clef, new Point(0, 93));

            bool same = false;
            for (int i = 0; i < notes.Count; i++)
            {
                if (40 + startX * 30 > this.Width - 10)
                {
                    startY += 150;
                    startX = 0;
                    newo.DrawLine(blackPen, new Point(0, startY + 24), new Point(this.Width, startY + 24));
                    newo.DrawLine(blackPen, new Point(0, startY + 34), new Point(this.Width, startY + 34));
                    newo.DrawLine(blackPen, new Point(0, startY + 44), new Point(this.Width, startY + 44));
                    newo.DrawLine(blackPen, new Point(0, startY + 54), new Point(this.Width, startY + 54));
                    newo.DrawLine(blackPen, new Point(0, startY + 64), new Point(this.Width, startY + 64));
                    newo.DrawImage(G_clef, new Point(0, startY + 10));

                    newo.DrawLine(blackPen, new Point(0, startY + 94), new Point(this.Width, startY + 94));
                    newo.DrawLine(blackPen, new Point(0, startY + 104), new Point(this.Width, startY + 104));
                    newo.DrawLine(blackPen, new Point(0, startY + 114), new Point(this.Width, startY + 114));
                    newo.DrawLine(blackPen, new Point(0, startY + 124), new Point(this.Width, startY + 124));
                    newo.DrawLine(blackPen, new Point(0, startY + 134), new Point(this.Width, startY + 134));
                    newo.DrawImage(F_clef, new Point(0, startY + 93));


                }

                if(notes[i].clef == "Treble")
                {
                    if (notes[i].increase == true)
                        newo.DrawImage(increase, new Point(50 - 10 + startX * 30, startY + 7 + notes[i].position));
                    newo.DrawImage(half, new Point(50 + startX * 30, startY + notes[i].position));
                    startX++;
                }
                else
                {
                    if (i != 0 && notes[i].clef == "Bas")
                        if (notes[i - 1].clef == "Treble" && notes[i - 1].startFrequency == notes[i].startFrequency)
                            same = true;
                    if(same == false)
                    {
                        if (notes[i].increase == true)
                            newo.DrawImage(increase, new Point(50 - 10 + startX * 30, startY + 7 + notes[i].position));
                        newo.DrawImage(half, new Point(50 + startX * 30, startY + notes[i].position));
                        startX++;
                    }
                    else
                    {
                        startX--;
                        if (notes[i].increase == true)
                            newo.DrawImage(increase, new Point(50 - 10 + startX * 30, startY + 7 + notes[i].position));
                        newo.DrawImage(half, new Point(50 + startX * 30, startY + notes[i].position));
                        startX++;
                    }
                }
                same = false;
            }

            base.OnPaint(pe);
        }
    }
}
