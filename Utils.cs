using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DarkParachute
{
    class Utils
    {
        Graphics g;
        Pen pen;
        private const float PI = 3.14159265359f;

        private float deg2rad(float deg)
        { 
            return deg * PI / 180.0f;
        }

        private float px2mm(float px)
        {
            return px * 3.779527559f;        
        }

        private int f2int(float f)
        {
            return Convert.ToInt32(f);
        }

        private void drawLine(float x1, float y1, float x2, float y2)
        {
            g.DrawLine(pen, px2mm(x1) + 10, px2mm(y1) + 10, px2mm(x2) + 10, px2mm(y2) + 10);
        }

        private Point makePoint(float x, float y)
        {
            return new Point(Convert.ToInt32(px2mm(x)) + 10, Convert.ToInt32(px2mm(y)) + 10);
        }

        public void makeParachute(PaintEventArgs e, Panel panel, int radius, int gores, float ratio, int hole, int sphere, int margin)
        {
            g = e.Graphics;
            pen = new Pen(Color.Black, 1F);

            //Stałe
            float obw = 2 * PI * radius; //Obwód spadochronu
            float goreWidth = obw / gores; //Szerokość segmentu
            float goreHeight = (obw * ratio) / 4; //Wysokość segmentu
            float sphereScalar = (float)sphere * 2.0f / 100.0f; //% sfery
            int gh = f2int(px2mm(goreHeight)); //Wysokość panelu zamieniona na centymetryint 
            int holeStart = f2int(px2mm(hole)); //Początek otworu
            int cycles = f2int(px2mm(goreHeight) * sphereScalar); //Ilość cykli do wyrysowania panelu

            //Wielkość panela dopasowywujemy do wielkości segmentu
            panel.Size = new Size(f2int(px2mm(goreWidth + 2 * margin)) + 20, cycles + 20);

            //Rysujemy!
            if (radius > 0 && gores > 0 && ratio > 0 && sphere > 0 && hole < goreHeight)
            {
                Point[] ls = new Point[cycles - holeStart];
                Point[] rs = new Point[cycles - holeStart];
                Point[] lm = new Point[cycles - holeStart];
                Point[] rm = new Point[cycles - holeStart];

                for (int i = holeStart; i < cycles; i++)
                {
                    float Sin = (float)Math.Sin(deg2rad((float)i / gh * 90.0f)) * goreWidth;
                    int index = i - holeStart;

                    //Krawędzie
                    ls[index] = makePoint((goreWidth / 2.0f) - (Sin / 2.0f) + margin, (float)i / gh * goreHeight);
                    rs[index] = makePoint((goreWidth / 2.0f) + (Sin / 2.0f) + margin, (float)i / gh * goreHeight);

                    //Marginesy na szwy
                    lm[index] = makePoint((goreWidth / 2.0f) - (Sin / 2.0f), (float)i / gh * goreHeight);
                    rm[index] = makePoint((goreWidth / 2.0f) + (Sin / 2.0f) + 2 * margin, (float)i / gh * goreHeight);

                    //Górna i dolna linia
                    if (i == cycles - 1 || i == holeStart) g.DrawLine(pen, ls[index].X - px2mm(margin), ls[index].Y, rs[index].X + px2mm(margin), rs[index].Y);
                }

                //Rysujemy krzywe
                e.Graphics.DrawCurve(pen, ls);
                e.Graphics.DrawCurve(pen, rs);
                e.Graphics.DrawCurve(pen, lm);
                e.Graphics.DrawCurve(pen, rm);
            }
            else
            {
                panel.Size = new Size(300, 70);
                g.DrawString("Złe parametry.", new Font("Arial", 16), new SolidBrush(Color.Black), 20.0f, 20.0f, new StringFormat());
            }
            pen.Dispose();
        }

        public void makeHoles(PaintEventArgs e, Panel panel, int radius, int holes, int margin, int holeRadius)
        {
            g = e.Graphics;
            pen = new Pen(Color.Black, 1F);

            //Stałe
            float obw = 2 * PI * radius; //Obwód walca
            float dis = obw / (float)holes;

            //Wielkość panela dopasowywujemy do wielkości segmentu
            panel.Size = new Size(f2int(px2mm(obw)) + 20, f2int(px2mm(margin * 2)) + 20);

            Point[] rm = new Point[]
            {
              new Point(10, 10), 
              new Point(f2int(px2mm(obw)) + 10, 10),
              new Point(f2int(px2mm(obw)) + 10, f2int(px2mm(margin * 2)) + 10),
              new Point(10, f2int(px2mm(margin * 2)) + 10)
            };

            for (int i = 0; i < holes; i++)
            {
                e.Graphics.DrawEllipse(pen, f2int(px2mm(dis/2 + dis * i - holeRadius)) + 10 , f2int(px2mm(margin - holeRadius)) + 10 , f2int(px2mm(holeRadius * 2)), f2int(px2mm(holeRadius * 2)));
            }

            e.Graphics.DrawPolygon(pen, rm);
        }

        public void makeCircle(PaintEventArgs e, Panel panel, int radius, int holeRadius)
        { 
            g = e.Graphics;
            pen = new Pen(Color.Black, 1F);

            panel.Size = new Size(f2int(px2mm(radius*2)) + 20, f2int(px2mm(radius * 2)) + 20);

            e.Graphics.DrawEllipse(pen, 10, 10, f2int(px2mm(radius * 2)), f2int(px2mm(radius * 2)));
            e.Graphics.DrawEllipse(pen, f2int(px2mm(radius - holeRadius)) + 10, f2int(px2mm(radius - holeRadius)) + 10, f2int(px2mm(holeRadius * 2)), f2int(px2mm(holeRadius * 2)));
        }
    }
}
