using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace katir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'databaseDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.databaseDataSet.Table);
            //this.tableTableAdapter.FillBy(databaseDataSet.Table,DateTime.Parse("7.4.2021"));
            //this.databaseDataSet.Table.Select("Id=1");
            // TODO: Bu kod satırı 'databaseDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            int masa1Count = 0;
            int masa2Count = 0;
            int rowCount = Convert.ToInt32(this.tableDataGridView.Rows.Count);
            for (int i = 0; i<(rowCount-1); i++)
            { 
                if (this.tableDataGridView.Rows[i].Cells[2].Value.Equals("MASA1"))
                {
                    masa1Count += Convert.ToInt32(this.tableDataGridView.Rows[i].Cells[3].Value);
                } else if (this.tableDataGridView.Rows[i].Cells[2].Value.Equals("MASA2"))
                {
                    masa2Count += Convert.ToInt32(this.tableDataGridView.Rows[i].Cells[3].Value);
                }   
            }
            masa1countlbl.Text = masa1Count.ToString();
            masa2countlbl.Text = masa2Count.ToString();
            toplamadetcountlbl.Text = (masa1Count + masa2Count).ToString();

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ((katir.DatabaseDataSet.TableRow)((System.Data.DataRowView)this.tableBindingSource.Current).Row).Tarih = tarihDateTimePicker.Value;
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            masaComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //((BindingSource)this.tableDataGridView.DataSource).Find() = "Tarih=" + DateTime.Now.ToLongDateString();
            DataTable dt = new DataTable();
            dt.TableName = "Katir";

            for (int i = 0; i < this.tableDataGridView.Columns.Count; i++)
            {
                //if (dataGridView1.Columns[i].Visible) // Add's only Visible columns (if you need it)
                //{
                string headerText = this.tableDataGridView.Columns[i].HeaderText;
                headerText = Regex.Replace(headerText, "[-/, ]", "_");

                DataColumn column = new DataColumn(headerText);
                dt.Columns.Add(column);
                //}
            }

            foreach (DataGridViewRow DataGVRow in this.tableDataGridView.Rows)
            {
                DataRow dataRow = dt.NewRow();
                // Add's only the columns that you want
                dataRow["Ibm"] = DataGVRow.Cells[1].Value;
                dataRow["Masa"] = DataGVRow.Cells[2].Value;
                dataRow["adet"] = DataGVRow.Cells[3].Value;
                dataRow["Tarih"] = DataGVRow.Cells[4].Value;

                dt.Rows.Add(dataRow); //dt.Columns.Add();
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            //Finally the save part:
            XmlTextWriter xmlSave = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\"+DateTime.Now.ToFileTime().ToString() + ".xml", Encoding.UTF8);
            xmlSave.Formatting = Formatting.Indented;
            ds.DataSetName = "Data";
            ds.WriteXml(xmlSave);
            xmlSave.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.databaseDataSet.Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(tarih1ToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(tarih2ToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gosterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.databaseDataSet.Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(baslangicdatepicker.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(bitisdatepicker.Value, typeof(System.DateTime))))));

                int masa1Count = 0;
                int masa2Count = 0;
                int rowCount = Convert.ToInt32(this.tableDataGridView.Rows.Count);
                for (int i = 0; i < (rowCount - 1); i++)
                {
                    if (this.tableDataGridView.Rows[i].Cells[2].Value.Equals("MASA1"))
                    {
                        masa1Count += Convert.ToInt32(this.tableDataGridView.Rows[i].Cells[3].Value);
                    }
                    else if (this.tableDataGridView.Rows[i].Cells[2].Value.Equals("MASA2"))
                    {
                        masa2Count += Convert.ToInt32(this.tableDataGridView.Rows[i].Cells[3].Value);
                    }
                }
                masa1countlbl.Text = masa1Count.ToString();
                masa2countlbl.Text = masa2Count.ToString();
                toplamadetcountlbl.Text = (masa1Count + masa2Count).ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
