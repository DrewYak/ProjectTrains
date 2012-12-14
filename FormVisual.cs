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

        /// <summary>
        /// Рисует одну станцию.
        /// </summary>
        /// <param name="station">Станция, которую нужно нарисовать.</param>
        /// <param name="radius">Радиус станции.</param>
        /// <param name="e"></param>
        private void DrawStation(Station station, int radius, PaintEventArgs e)
        {
            PointF p = new Point(station.X + radius, station.Y + radius);
            e.Graphics.DrawEllipse(Pens.Indigo, station.X - radius, station.Y - radius, radius * 2, radius * 2);
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

        private void FormVisual_Paint(object sender, PaintEventArgs e)
        {
            int radius = 6;
            List<Station> stations  = Station.Search();
            DrawStations(stations, radius, e);
        }
    }
}
