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
        public static Brush     brushStation        = Brushes.Green;
        public static Pen       penStation          = new Pen(Color.Black, 2);

        public static int       radiusTrain         = 6;
        public static Brush     brushTrain          = Brushes.Yellow;
        public static Pen       penTrain            = new Pen(Color.Red, 2);
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

                    Graphics g  = panel2.CreateGraphics();
                    DrawAll(g);
                }
            }
            catch (FormatException)
            {
                FormMessage Message         = new FormMessage();
                Message.messageLabel.Text   = "Введённая дата или время имели неверный формат! Введите дату и время в формате ДД.MM.ГГГГ ЧЧ:ММ:СС";
                Message.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radiusStation++;
            Invalidate();
            if (radiusStation >= maxradiusStation)
            {
                button2.Enabled = false;
            }
            if (radiusStation > minradiusStation)
            {
                button3.Enabled = true;
            }
            textBox1.Text = radiusStation.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radiusStation--;
            Invalidate();
            if (radiusStation <= minradiusStation)
            {
                button3.Enabled = false;
            }
            if (radiusStation < maxradiusStation)
            {
                button2.Enabled = true;
            }
            textBox1.Text = radiusStation.ToString();
        }

        private void FormVisual_Load(object sender, EventArgs e)
        {
            textBox1.Text = radiusStation.ToString();    
            DrawAll(panel2.CreateGraphics());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            time = Convert.ToDateTime(maskedTextBox1.Text);
            timer1.Start();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddMinutes(12);
            panel2.Invalidate();
            maskedTextBox1.Text = time.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawAll(panel2.CreateGraphics());
        }
    }
}
