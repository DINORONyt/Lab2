using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary1_Lab2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly TaskSolver _solver;

        public Form1()
        {
            InitializeComponent();
            _solver = new TaskSolver();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Подписка на события кнопок
            btnCheckPoint.Click += BtnCheckPoint_Click;
            btnRunMonteCarlo.Click += BtnRunMonteCarlo_Click;
            btnClear.Click += BtnClear_Click;
        }

        private void BtnCheckPoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtPointX.Text, out double pointX) ||
                    !double.TryParse(txtPointY.Text, out double pointY) ||
                    !double.TryParse(txtCircleCx.Text, out double circleCx) ||
                    !double.TryParse(txtCircleCy.Text, out double circleCy) ||
                    !double.TryParse(txtCircleR.Text, out double radius))
                {
                    MessageBox.Show("Введите корректные числовые значения", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string result = _solver.CheckPointPosition(pointX, pointY, circleCx, circleCy, radius, out Color color);

                lblResultTask1.Text = result;
                lblResultTask1.ForeColor = color;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRunMonteCarlo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPointsCount.Text, out int pointCount) || pointCount <= 0)
                {
                    MessageBox.Show("Введите положительное количество точек", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cursor = Cursors.WaitCursor;

                var data = _solver.GenerateRandomPoints(pointCount);

                lblPiResult.Text = $"Точек: {data.TotalPoints}\n" +
                                  $"В круге: {data.InsidePoints}\n" +
                                  $"π ≈ {data.PiApproximation:F6}";

                _solver.DrawVisualization(pictureBox1, data);

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtPointX.Clear();
            txtPointY.Clear();
            txtCircleCx.Clear();
            txtCircleCy.Clear();
            txtCircleR.Clear();
            txtPointsCount.Text = "1000";

            lblResultTask1.Text = "Результат: ...";
            lblResultTask1.ForeColor = Color.Black;

            lblPiResult.Text = "π = ...";

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;
        }
    }
}