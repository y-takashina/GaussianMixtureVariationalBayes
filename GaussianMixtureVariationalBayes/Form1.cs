using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static GaussianMixtureVariationalBayes.Extensions;

namespace GaussianMixtureVariationalBayes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
            var data = ReadData("GaussianMixtureData20130501.tsv", (0, 1), '\t');
            chart1.PlotPoints(data, "observed data");
        }
    }
}