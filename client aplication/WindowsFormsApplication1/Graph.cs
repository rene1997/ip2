using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Network;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Graph
    {
        // Bijbehorende gebruiker
        public Session session { get; set; }

        // Wat laat de grafiek zien
        private SearchTypes CurrentSearchType { get; set; }

        public enum SearchTypes
        {
            DEFAULT,
            BETWEEN_VALUES,
            BETWEEN_TIMES
        }

        public Graph()
        {
            InitializeComponent();
            CurrentSearchType = SearchTypes.DEFAULT;       // Alle aanwezige waarden plotten
            setup();
        }

        public void setSession(Session s)
        {
            this.session = s;

            CurrentSearchType = SearchTypes.DEFAULT;
            plot();
        }

        // Initiele opzet van de chart
        public void plot()
        {
            // Alles clearen
            foreach (Series obj in chart1.Series)
                obj.Points.Clear();

            int min = 0;
            int max = 0;
            // Enumerator voor onze measurements
            IEnumerator<Measurement> measurements;
            if (valueMinBox.Text.Length > 0)
                min = int.Parse(valueMinBox.Text);
            if (valueMaxBox.Text.Length > 0)
                max = int.Parse(valueMaxBox.Text);

            try
            {
                // Bij normale searchType, alle waarden plotten
                if (CurrentSearchType.Equals(SearchTypes.DEFAULT))
                    measurements = session.getMeasurement().OrderBy(m => m.time).GetEnumerator();
                else // Bij 'BETWEEN_VALUES' waarden alle signalen tussen min en max box
                    measurements = session.getMeasurement().OrderBy(m => m.time).Where(signal =>
                        signal.actual_power > min && signal.actual_power < max ||
                        signal.distance > min && signal.distance < max ||
                        signal.energy > min && signal.energy < max ||
                        signal.rpm > min && signal.rpm < max ||
                        signal.pulse > min && signal.pulse < max ||
                        signal.speed > min && signal.speed < max
                    ).GetEnumerator();

                while (measurements.MoveNext())
                {
                    Measurement item = (Measurement)measurements.Current;
                    plotMeasurement(item);
                }
            }
            catch (NullReferenceException ex)
            {
                measurements = null;
            }
        }


        private void plotMeasurement(Measurement m)
        {   // Measurement uitlezen en plotten
            chart1.Series["actualpower"].Points.AddXY(m.time, m.actual_power);
            chart1.Series["energy"].Points.AddXY(m.time, m.energy);
            chart1.Series["pulse"].Points.AddXY(m.time, m.pulse);
            chart1.Series["requestedpower"].Points.AddXY(m.time, m.requested_power);
            chart1.Series["rpm"].Points.AddXY(m.time, m.rpm);
            chart1.Series["speed"].Points.AddXY(m.time, m.speed);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Opnieuw plotten
            plot();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Alles weergeven
            CurrentSearchType = SearchTypes.DEFAULT;
            plot();
        }
    }
}