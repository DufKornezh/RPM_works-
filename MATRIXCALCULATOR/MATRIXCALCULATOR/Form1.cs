using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATRIXCALCULATOR
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();

            matrixA.AllowUserToAddRows = false;
            matrixB.AllowUserToAddRows = false;
            ResultMatrix.AllowUserToAddRows = false;

            matrixA.RowCount = (int)RowCounetNumericA.Value;
            matrixA.ColumnCount = (int)ColumnCounterNumericA.Value;

            matrixB.RowCount = (int)RowCounetNumericB.Value;
            matrixB.ColumnCount = (int)ColumnCounterNumericB.Value;

            ResultMatrix.RowCount = (int)RowCounetNumericA.Value;
            ResultMatrix.ColumnCount = (int)ColumnCounterNumericA.Value;

        }

        public int Rank(double[,] A)
        {
            int rang = 0;
            int q = 1;

            while (q <= Math.Min(A.GetLength(0), A.GetLength(1)))
            {
                double[,] matbv = new double[q, q];
                for (int i = 0; i < (A.GetLength(0) - (q - 1)); i++)
                {
                    for (int j = 0; j < (A.GetLength(1) - (q - 1)); j++)
                    {
                        for (int k = 0; k < q; k++)
                        {
                            for (int c = 0; c < q; c++)
                            {
                                matbv[k, c] = A[i + k, j + c];
                            }
                        }

                        if (Determenant(matbv) != 0)
                        {

                            rang = q;
                        }
                    }
                }
                q++;
            }

            return rang;
        }

        public double[,] Submatrix(double[,] A, int a, int b)
        {
            double[,] sm = new double[A.GetLength(0) - 1, A.GetLength(1) - 1];
            for (int i = 0; i < sm.GetLength(0); i++)
                for (int j = 0; j < sm.GetLength(1); j++)
                    sm[i,j] =  A[i < a ? i : i + 1, j < b ? j : j+1];

            return sm;
        }

        public double Determenant(double[,] A)
        {
            if (A.GetLength(0) == 1 && A.GetLength(1) == 1)
            {
                return A[0, 0];
            }
            double S = 0;
            for (int i = 0; i < A.GetLength(1); i++)
                S += Math.Pow(-1, i) * A[i, 0] * Determenant(Submatrix(A, i, 0));
            return S;
        }


        private void RowCounetNumericA_ValueChanged(object sender, EventArgs e)
        {
            matrixA.RowCount = (int)RowCounetNumericA.Value;
            ResultMatrix.RowCount = (int)RowCounetNumericA.Value;
        }

        private void ColumnCounterNumericA_ValueChanged(object sender, EventArgs e)
        {
            matrixA.ColumnCount = (int)ColumnCounterNumericA.Value;
            ResultMatrix.ColumnCount = (int)ColumnCounterNumericA.Value;
        }

        private void RowCounetNumericB_ValueChanged(object sender, EventArgs e)
        {
            matrixB.RowCount = (int)RowCounetNumericB.Value;
        }

        private void ColumnCounterNumericB_ValueChanged(object sender, EventArgs e)
        {
            matrixB.ColumnCount = (int)ColumnCounterNumericB.Value;
        }

        private void buttonMatrixSum_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < ResultMatrix.ColumnCount; j++)
            {
                for (int k = 0; k < ResultMatrix.RowCount; k++)
                {
                    ResultMatrix[j, k].Value = Convert.ToDouble(matrixA[j, k].Value) + Convert.ToDouble(matrixB[j, k].Value);
                }
            }
        }

        private void buttonMatrixSubt_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < ResultMatrix.ColumnCount; j++)
            {
                for (int k = 0; k < ResultMatrix.RowCount; k++)
                {
                    ResultMatrix[j, k].Value = Convert.ToDouble(matrixA[j, k].Value) - Convert.ToDouble(matrixB[j, k].Value);
                }
            }
        }

        private void buttonCopyToBottom_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < matrixA.ColumnCount; j++)
            {
                for (int k = 0; k < matrixA.RowCount; k++)
                {
                    matrixB[j, k].Value = matrixA[j, k].Value;
                }
            }
        }

        private void buttonCopyToUpper_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < matrixB.ColumnCount; j++)
            {
                for (int k = 0; k < matrixB.RowCount; k++)
                {
                    matrixA[j, k].Value = matrixB[j, k].Value;
                }
            }
        }

        private void buttonMatrixMultiply_Click(object sender, EventArgs e)
        {
            int[,] RM = new int[matrixA.RowCount, matrixA.ColumnCount];

            for (int i = 0; i < matrixA.RowCount; i++)
            {
                for (int j = 0; j < matrixB.ColumnCount; j++)
                {
                    for (int k = 0; k < matrixB.RowCount; k++)
                    {

                        RM[j, i] += Convert.ToInt32(matrixA[i, k].Value) * Convert.ToInt32(matrixB[k, j].Value);

                    }
                }
                ResultMatrix.RowCount = matrixA.Rows.Count;
                ResultMatrix.ColumnCount = matrixA.Columns.Count;
                for (int j = 0; j < RM.GetLength(0); j++)
                {
                    for (int k = 0; k < RM.GetLength(1); k++)
                    {
                        ResultMatrix[k, j].Value = RM[j, k];
                    }
                }
            }

        }

        private void buttonTranspose_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < matrixA.ColumnCount; j++)
            {
                for (int k = 0; k < matrixA.RowCount; k++)
                {
                    ResultMatrix[j, k].Value = matrixA[k, j].Value;
                }
            }
        }

        private void buttonCopyResultToB_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < ResultMatrix.ColumnCount; j++)
            {
                for (int k = 0; k < ResultMatrix.RowCount; k++)
                {
                    matrixA[j, k].Value = ResultMatrix[j, k].Value;
                }
            }
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < matrixA.ColumnCount; j++)
            {
                for (int k = 0; k < matrixA.RowCount; k++)
                {
                    if (MultiplicatorNumeric.Value != 0)
                    {
                        ResultMatrix[j, k].Value = Convert.ToDouble(matrixA[j, k].Value) * Convert.ToDouble(MultiplicatorNumeric.Value);
                    }
                    else ResultMatrix[j, k].Value = 0;
                }
            }
        }

        private void buttonDeterminant_Click(object sender, EventArgs e)
        {
            ResultMatrix.RowCount = 1;
            ResultMatrix.ColumnCount = 1;
            double[,] A = new double[matrixA.ColumnCount, matrixA.RowCount];
            for (int i = 0; i < matrixA.ColumnCount; i++)
            {
                for (int j = 0; j < matrixA.RowCount; j++)
                {
                    A[i, j] = Convert.ToDouble(matrixA[i, j].Value);
                }
             }
            ResultMatrix[0,0].Value=Determenant(A);
        }

        private void buttonElementMinor_Click(object sender, EventArgs e)
        {
            ResultMatrix.RowCount = 1;
            ResultMatrix.ColumnCount = 1;
            double[,] A = new double[matrixA.ColumnCount, matrixA.RowCount];
            for (int i = 0; i < matrixA.ColumnCount; i++)
            {
                for (int j = 0; j < matrixA.RowCount; j++)
                {
                    A[i, j] = Convert.ToDouble(matrixA[i, j].Value);
                }
            }
            ResultMatrix[0, 0].Value = Determenant(Submatrix(A, Convert.ToInt32(matrixA.SelectedCells[0].ColumnIndex), Convert.ToInt32(matrixA.SelectedCells[0].RowIndex)));


        }

        private void RandomA_Click(object sender, EventArgs e)
        {
            matrixA.RowCount = Convert.ToInt32(RowCounetNumericA.Value);
            matrixA.ColumnCount = Convert.ToInt32(ColumnCounterNumericA.Value);
            Random getRandomValue = new Random();
            for (int i = 0; i < matrixA.Rows.Count; i++)
            {
                for (int j = 0; j < matrixA.Columns.Count; j++)
                {
                    matrixA[j, i].Value = getRandomValue.Next(-1000, 1001);
                }
            }
        }

        private void RandomB_Click(object sender, EventArgs e)
        {
            Random getRandomValue = new Random();
            for (int i = 0; i < matrixB.Rows.Count; i++)
            {
                for (int j = 0; j < matrixB.Columns.Count; j++)
                {
                    matrixB[j, i].Value = getRandomValue.Next(-1000, 1001);
                }
            }
        }

        private void buttonReversedMatrix_Click(object sender, EventArgs e)
        {

            double[,] A = new double[matrixA.ColumnCount, matrixA.RowCount];
            for (int i = 0; i < matrixA.ColumnCount; i++)
            {
                for (int j = 0; j < matrixA.RowCount; j++)
                {
                    A[i, j] = Convert.ToDouble(matrixA[i, j].Value);
                }
            }

            double d = Determenant(A);

            for (int j = 0; j < A.GetLength(0); j++)
            {
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    A[j, k] = A[k, j];
                }
            }
            

            double[,] um = new double[A.GetLength(0), A.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    um[i, j] = Determenant(Submatrix(A, i, j));
                }
            }

            double[,] rm = new double[A.GetLength(0), A.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    rm[i, j] = (1 / d) * um[i, j];
                }
            }

            ResultMatrix.ColumnCount = rm.GetLength(0);
            ResultMatrix.RowCount = rm.GetLength(1);

            for (int i = 0; i < rm.GetLength(0); i++)
            {
                for (int j = 0; j < rm.GetLength(1); j++)
                {
                    ResultMatrix[i, j].Value = rm[i, j];
                }
            }
            
        }

        private void buttonMatrixRang_Click(object sender, EventArgs e)
        {
            double[,] A = new double[matrixA.ColumnCount, matrixA.RowCount];
            for (int i = 0; i < matrixA.ColumnCount; i++)
            {
                for (int j = 0; j < matrixA.RowCount; j++)
                {
                    A[i, j] = Convert.ToDouble(matrixA[i, j].Value);
                }
            }
            Rank(A);
            ResultMatrix.ColumnCount=1;
            ResultMatrix.RowCount=1;
            ResultMatrix[0, 0].Value = Rank(A); 
        }
    }
}


