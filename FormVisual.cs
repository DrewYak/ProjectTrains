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
        public FormVisual()
        {
            InitializeComponent();
        }

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
                PointF point = new PointF(routenode.Station.X, routenode.Station.Y);
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
        /// <param name="radius">Радиус станции.</param>
        /// <param name="e"></param>
        private void DrawStation(Station station, int radius, PaintEventArgs e)
        {
            PointF p = new Point(station.X + radius, station.Y + radius);
            e.Graphics.FillEllipse(Brushes.White, station.X - radius, station.Y - radius, radius * 2, radius * 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black, 1.5F), station.X - radius, station.Y - radius, radius * 2, radius * 2);
            e.Graphics.DrawString(station.Name, Font, SystemBrushes.WindowText, p);
        }

        /// <summary>
        /// Рисует станции из списка станций stations.
        /// </summary>
        /// <param name="stations">Список станций, которые нужно нарисовать.</param>
        /// <param name="radius">Радиус станции.</param>
        /// <param name="e"></param>
        private void DrawStations(List<Station> stations, int radius, PaintEventArgs e)
        {
            foreach (Station station in stations)
            {
                DrawStation(station, radius, e);
            }

        }

        private void DrawTrain(PointF p, PaintEventArgs e)
        {
            
            /*
            DateTime    time        = Convert.ToDateTime(maskedTextBox1.Text);
            List<Train> trains      = Train.Search("", "");
            TimeSpan    timeSpan    = new TimeSpan(0, 0, 1);
            for (;;)
            {
                PointF p = trains[0].Location(time);
                e.Graphics.DrawEllipse(new Pen(Color.Black, 1.5F),p.X, p.Y, 5,5);
            }
             * */
        }


        private void FormVisual_Paint(object sender, PaintEventArgs e)
        {
            int             radius      = 6;
            List<Station>   stations    = Station.Search();
            List<Train>     trains      = Train.Search("", "");
            DrawRoutes(trains, e);
            DrawStations(stations, radius, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int         radius      = 3;
            DateTime    time        = Convert.ToDateTime(maskedTextBox1.Text);
            Train       trn         = Train.Search(13);
            PointF      p           = trn.Location(time);
            Graphics g = Graphics.FromHwnd(Handle);
            g.DrawEllipse(Pens.Red, p.X - radius, p.Y - radius, radius, radius);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
