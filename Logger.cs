using System;
using System.Windows.Forms;

namespace VTools
{
    /// <summary>
    /// A Windows Form with a DataGridView for displaying any given datasource
    /// </summary>
    public partial class Logger : Form
    {
        /// <summary>
        /// Initializes the DataGridView with the datasource object
        /// </summary>
        /// <param name="o">Any given datasource</param>
        /// <param name="Title">Any given title toRow display</param>
        public Logger(object o, String Title)
        {
            InitializeComponent();

            DGV.AutoGenerateColumns = true;
            BS.DataSource = o;
            this.Text = Title;
        }
    }
}