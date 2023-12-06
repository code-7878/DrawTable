using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LiveCharts;
using LiveCharts.Wpf;

namespace DrawTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet3.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter1.Fill(this.database1DataSet3.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet2.Table1". При необходимости она может быть перемещена или удалена.
            this.table1TableAdapter1.Fill(this.database1DataSet2.Table1);
            
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            cartesianChart2.LegendLocation = LegendLocation.Bottom;
        }
        //student 1
        public void toolStripButton2_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            ChartValues<int> values = new ChartValues<int>();

            List<string> name = new List<string>();

            foreach (var Row in database1DataSet3.Table)
            {
                values.Add(Row.The_number_of_delays);
                name.Add(Row.Date.ToShortDateString());

            }

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Add(new Axis()
            {
                Title = "Опоздания",
                Labels = name


            });


            LineSeries Line = new LineSeries();
            Line.Title = "Student 1";
            Line.Values = values;


            series.Add(Line);

            cartesianChart1.Series = series;
        }




        //student 2
        public void toolStripButton1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            ChartValues<int> values = new ChartValues<int>();

            List<string> name = new List<string>();

            foreach(var Row in database1DataSet2.Table1)
            {
                values.Add(Row.The_number_of_delays);
                name.Add(Row.Date.ToShortTimeString());

            }

            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisY.Add(new Axis()
            {
                Title = "Опоздания", Labels = name
                
            });


            LineSeries Line = new LineSeries();
            Line.Title = "Student 2";
            Line.Values = values;


            series.Add(Line);

            cartesianChart2.Series = series;

        }

        
    }
}
