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
        public static Brush     brushStation        = Brushes.White;
        public static Pen       penStation          = new Pen(Color.Black, 1.5F);

        public static int       radiusTrain         = 6;
        public static Brush     brushTrain          = Brushes.Snow;
        public static Pen       penTrain            = new Pen(Color.Black, 1.5F);



        public FormVisual()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Рисует маршруты всех указанных поездов.
        /// </summary>
        /// <param name="trains">Список поездов, маршруты которых следует отрисовать.</param>
        /// <param name="e"></param>
        private void DrawRoutes(List<Train> trains, PaintEventArgs e)
        {
            foreach (Train train in trains)
            {
                List<RouteNode> routenodes = train.RouteNodes;
                DrawRoute(routenodes, e); 
            }
        }

        /// <summary>
        /// Рисует маршрут поезда.
        /// </summary>
        /// <param name="routenodes">Список узлов маршрута.</param>
        /// <param name="e"></param>
        private void DrawRoute(List<RouteNode> routenodes, PaintEventArgs e)
        {
            List<PointF> points = new List<PointF>();
            foreach (RouteNode routenode in routenodes)
            {
                PointF point = new PointF(routenode.Station.X + radiusStation, routenode.Station.Y + radiusStation);
                points.Add(point);
            }
            foreach (RouteNode routenode in routenodes)
            {
                e.Graphics.DrawLines(Pens.Black, points.ToArray());
            }
        }


        /// <summary>
        /// Рисует одну станцию.
        /// </summary>
        /// <param name="station">Станция, которую нужно нарисовать.</param>
        /// <param name="e"></param>
        private void DrawStation(Station station, PaintEventArgs e)
        {
            PointF p = new Point(station.X + radiusStation * 2, station.Y + radiusStation*2);
            e.Graphics.FillEllipse(brushStation, station.X, station.Y, radiusStation * 2, radiusStation * 2);
            e.Graphics.DrawEllipse(penStation, station.X, station.Y, radiusStation * 2, radiusStation * 2);
            e.Graphics.DrawString(station.Name, Font, SystemBrushes.WindowText, p);
        }

        /// <summary>
        /// Рисует станции из списка станций.
        /// </summary>
        /// <param name="stations">Список станций, которые нужно нарисовать.</param>
        /// <param name="e"></param>
        private void DrawStations(List<Station> stations, PaintEventArgs e)
        {
            foreach (Station station in stations)
            {
                DrawStation(station, e);
            }

        }

        /// <summary>
        /// Рисует поезд по его текущим координатам.
        /// </summary>
        /// <param name="p">Местоположение поезда.</param>
        private void DrawTrain(PointF p)
        {
            Graphics g = Graphics.FromHwnd(Handle);
            g.DrawEllipse(Pens.Red,         p.X, p.Y, radiusTrain, radiusTrain);
            g.FillEllipse(Brushes.Yellow,   p.X, p.Y, radiusTrain, radiusTrain);                    
        }

        /// <summary>
        /// Рисует список укзазанных поездов.
        /// </summary>
        /// <param name="trains">Список поездов, котоые седует отрисовать.</param>
        /// <param name="time"></param>
        private void DrawTrains(List<Train> trains, DateTime time)
        {
            foreach(Train train in trains)
            {
                PointF p = train.Location(time);
                DrawTrain(p);
            }
        }


        private void FormVisual_Paint(object sender, PaintEventArgs e)
        {
            List<Station>   stations    = Station.Search();
            List<Train>     trains      = Train.Search("", "");
            DrawRoutes(trains, e);
            DrawStations(stations, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int         radius      = 8;
            DateTime    time        = Convert.ToDateTime(maskedTextBox1.Text);
            Train       trn         = Train.Search(13);
            PointF      p           = trn.Location(time);
            Graphics g = Graphics.FromHwnd(Handle);
            g.DrawEllipse(Pens.Red, p.X - radius, p.Y - radius, radius, radius);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Train> trains = Train.Search("","");
            DateTime time = Convert.ToDateTime(maskedTextBox1.Text);
            DrawTrains(trains, time);
            time = time.AddMinutes(5);
            maskedTextBox1.Text = Convert.ToString(time);
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
        }
    }
}
