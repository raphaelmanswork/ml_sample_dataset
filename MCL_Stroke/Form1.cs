using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
using CsvHelper;
namespace MCL_Stroke
{
    public partial class Form1 : Form
    {

        NeuralNet bp;
        CsvHelper csvHelper;
        public Form1()
        {
            InitializeComponent();

            csvHelper = new CsvHelper();
            
        }

     

        private void init_Nn(object sender, EventArgs e)
        {
            bp = new NeuralNet(5, 8, 1);
        }

        private void train_Nn(object sender, EventArgs e)
        {
            List<StrokeData> data = csvHelper.getRecords();
            for (int i = 0; i < 1000; i++)
            {
                foreach(var d in data)
                {
                    bp.setInputs(0, d.Age);
                    bp.setInputs(1, d.Avg_Glucose_Level);
                    bp.setInputs(2, csvHelper.ParseGender(d.Gender));
                    bp.setInputs(3, d.Heart_Disease);
                    bp.setInputs(4, d.Hypertension);
                    bp.setDesiredOutput(0, d.Stroke);
                    bp.learn();
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bp.saveWeights(saveFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)

        {

            double age = Convert.ToDouble(txtbox_Age.Text);
            double avg_glucose_level = Convert.ToDouble(txt_GlucoseLevel.Text);
            int gender = csvHelper.ParseGender(cmbx_gender.Text);
            int heart_disease = Convert.ToInt32(txtbox_heartDisease.Text);
            int hypertension = Convert.ToInt32(txtBox_Hypertension.Text);

            bp.setInputs(0, age);
            bp.setInputs(1, avg_glucose_level);
            bp.setInputs(2, gender);
            bp.setInputs(3, heart_disease);
            bp.setInputs(4, hypertension);
            bp.run();

            txtbox_Result.Text = "" + bp.getOuputData(0);

        }

      
    }
}
