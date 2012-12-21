using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trains
{
    public partial class FormVisual : Form
    {
        /// <summary>
        /// Константа для рисования станций на форме.
        /// </summary>
        
        public static int       minradiusStation    = 3;
        public static int       radiusStation       = 8;
        public static int       maxradiusStation    = 15;
        public static Color     colorStation1       = Color.Green;
        public static Color     colorStation2       = Color.Black;
        public static Brush     brushStation        = new SolidBrush(colorStation1);
        public static Pen       penStation          = new Pen(colorStation2, 2);

        public static int       minradiusTrain      = 3;
        public static int       radiusTrain         = 6;
        public static int       maxradiusTrain      = 15;
        public static Color     colorTrain1         = Color.Yellow;
        public static Color     colorTrain2         = Color.Red;
        public static Brush     brushTrain          = new SolidBrush(colorTrain1);
        public static Pen       penTrain            = new Pen(colorTrain2, 2);
        public static DateTime  time                = DateTime.Now;

        static List<Station>    allstations    = Station.Search();
        static List<Train>      alltrains      = Train.Search("", "");


        public FormVisual()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Рисует одну станцию.
        /// </summary>
        /// <param name="station">Станция, которую нужно нарисовать.</param>
        /// <param name="e"></param>
        private void DrawStation(Station station, Graphics g)
        {
            g.FillEllipse(brushStation, station.X, station.Y, radiusStation * 2, radiusStation * 2);
            g.DrawEllipse(penStation,   station.X, station.Y, radiusStation * 2, radiusStation * 2);

            PointF p = new Point(station.X + radiusStation * 2, station.Y + radiusStation*2);
            g.DrawString(station.Name, Font, SystemBrushes.WindowText, p);
        }

        /// <summary>
        /// Рисует станции из списка станций.
        /// </summary>
        /// <param name="stations">Список станций, которые нужно нарисовать.</param>
        /// <param name="e"></param>
        private void DrawStations(List<Station> stations, Graphics g)
        {
            foreach (Station station in stations)
            {
                DrawStation(station, g);
            }

        }

        /// <summary>
        /// Рисует маршрут поезда.
        /// </summary>
        /// <param name="routenodes">Список узлов маршрута.</param>
        /// <param name="e"></param>
        private void DrawRoute(List<RouteNode> routenodes, Graphics g)
        {
            List<PointF> points = new List<PointF>();
            foreach (RouteNode routenode in routenodes)
            {
                PointF point = new PointF(routenode.Station.X + radiusStation, routenode.Station.Y + radiusStation);
                points.Add(point);
            }
            g.DrawLines(new Pen (Brushes.Black, 2), points.ToArray());
        }

        /// <summary>
        /// Рисует маршруты всех указанных поездов.
        /// </summary>
        /// <param name="trains">Список поездов, маршруты которых следует отрисовать.</param>
        /// <param name="e"></param>
        private void DrawRoutes(List<Train> trains, Graphics g)
        {
            foreach (Train train in trains)
            {
                List<RouteNode> routenodes = train.RouteNodes;
                DrawRoute(routenodes, g); 
            }
        }

        /// <summary>
        /// Рисует поезд.
        /// </summary>
        /// <param name="train"></param>
        /// <param name="g"></param>
        private void DrawTrain(Train train, Graphics g)
        {
            PointF p = train.Location(time);
            g.DrawEllipse(penTrain,     p.X + radiusStation - radiusTrain, p.Y + radiusStation - radiusTrain, radiusTrain * 2, radiusTrain * 2);
            g.FillEllipse(brushTrain,   p.X + radiusStation - radiusTrain, p.Y + radiusStation - radiusTrain, radiusTrain * 2, radiusTrain * 2);
        }

        /// <summary>
        /// Рисует список поездов.
        /// </summary>
        /// <param name="trains"></param>
        /// <param name="g"></param>
        private void DrawTrains(List<Train> trains, Graphics g)
        {
            foreach(Train train in trains)
            {
                DrawTrain(train, g);
            }
        }

        /// <summary>
        /// Рисует все объекты, предварительно очищая поверхность для рисования.
        /// </summary>
        /// <param name="g"></param>
        private void DrawAll(Graphics g)
        {
            DrawRoutes  (alltrains,    g);
            DrawStations(allstations,  g);
            DrawTrains  (alltrains,    g);
        }

        private void FormVisual_Paint(object sender, PaintEventArgs e)
        {
            DrawAll(panel2.CreateGraphics());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.MaskCompleted)
                {
                    time        = Convert.ToDateTime(maskedTextBox1.Text);
                    panel2.Invalidate();
                }
            }
            catch (FormatException)
            {
                FormMessage Message         = new FormMessage();
                Message.messageLabel.Text   = "Введённая дата или время имели неверный формат! Введите дату и время в формате ДД.MM.ГГГГ ЧЧ:ММ:СС";
                Message.ShowDialog();
            }
        }


        private void FormVisual_Load(object sender, EventArgs e)
        {
            DrawAll(panel2.CreateGraphics());

            colorSt1.BackColor  = colorStation1;
            colorSt2.BackColor  = colorStation2;
            colorTr1.BackColor  = colorTrain1;
            colorTr2.BackColor  = colorTrain2;

            radiusSt.Text       = radiusStation.ToString();
            radiusTr.Text       = radiusTrain.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                time = Convert.ToDateTime(maskedTextBox1.Text);
                timer1.Start();
                this.DoubleBuffered = true;
            }
            catch (FormatException)
            {
                FormMessage Message         = new FormMessage();
                Message.messageLabel.Text   = "Введённая дата или время имели неверный формат! Введите дату и время в формате ДД.MM.ГГГГ ЧЧ:ММ:СС";
                Message.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddMinutes(5);
            this.DoubleBuffered = true;
            panel2.Invalidate();
            maskedTextBox1.Text = time.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawAll(panel2.CreateGraphics());
        }

        #region Выбор цветов
        private void colorSt1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = colorSt1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorSt1.BackColor  = colorDialog1.Color;
                colorStation1       = colorDialog1.Color;
                brushStation        = new SolidBrush(colorStation1);

                panel2.Invalidate();
            }
        }

        private void colorSt2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color  = colorSt2.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorSt2.BackColor  = colorDialog1.Color;
                colorStation2       = colorDialog1.Color;
                penStation          = new Pen(colorStation2, 2);

                panel2.Invalidate();
            }
        }

        private void colorTr1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = colorTr1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorTr1.BackColor  = colorDialog1.Color;
                colorTrain1         = colorDialog1.Color;
                brushTrain          = new SolidBrush(colorTrain1);

                panel2.Invalidate();
            }

        }

        private void ColorTr2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color  = colorTr2.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorTr2.BackColor  = colorDialog1.Color;
                colorTrain2         = colorDialog1.Color;
                penTrain            = new Pen(colorTrain2, 2);

                panel2.Invalidate();
            }
        }
        #endregion

        #region Изменение размеров
        private void sizeDecSt_Click(object sender, EventArgs e)
        {
            radiusStation--;
            panel2.Invalidate();
            if (radiusStation <= minradiusStation)
            {
                sizeDecSt.Enabled = false;
            }
            if (radiusStation < maxradiusStation)
            {
                sizeIncSt.Enabled = true;
            }
            radiusSt.Text   = radiusStation.ToString();
        }

        private void sizeIncSt_Click(object sender, EventArgs e)
        {
            radiusStation++;
            panel2.Invalidate();
            if (radiusStation >= maxradiusStation)
            {
                sizeIncSt.Enabled = false;
            }
            if (radiusStation > minradiusStation)
            {
                sizeDecSt.Enabled = true;
            }
            radiusSt.Text   = radiusStation.ToString();
        }

        private void sizeDecTr_Click(object sender, EventArgs e)
        {
            radiusTrain--;
            panel2.Invalidate();
            if (radiusTrain <= minradiusTrain)
            {
                sizeDecTr.Enabled = false;
            }
            if (radiusTrain < maxradiusStation)
            {
                sizeIncTr.Enabled = true;
            }
            radiusTr.Text   = radiusTrain.ToString();
        }

        private void sizeIncTr_Click(object sender, EventArgs e)
        {
            radiusTrain++;
            panel2.Invalidate();
            if (radiusTrain >= maxradiusTrain)
            {
                sizeIncTr.Enabled = false;
            }
            if (radiusTrain > minradiusTrain)
            {
                sizeDecTr.Enabled = true;
            }
            radiusTr.Text   = radiusTrain.ToString();
        }
#endregion

        private void viewStat_CheckedChanged(object sender, EventArgs e)
        {
            if (viewStat.Checked)
            {
                viewStatic.Enabled          = true;
                viewDynamicStart.Enabled    = false;
                viewDynamicStop.Enabled     = false;
            }
            if (viewDyn.Checked)
            {
                viewStatic.Enabled          = false;
                viewDynamicStart.Enabled    = true;
                viewDynamicStop.Enabled     = true;
            }
        }

        private void viewDynamicStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
