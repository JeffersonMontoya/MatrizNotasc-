
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace MatrizNotas1
{
    public partial class frmNotas : Form

    {
        public int N, F, C;
        public Double[,] mNotas;
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)

        {
            dgvNotas.RowCount = 0;

            //Pedimos el numero de estudiantes y lo igualamos a N
            N = Convert.ToInt32(Interaction.InputBox("Ingrese el número de estudiantes"));

            // Definir vectores para nombres y resultados
            string[] vNombres = new string[N];
            string[] vResultado = new string[N];

            // Crear la matriz de notas
            mNotas = new double[N, 7];

            //RowCount agregar filas a un datagrid View
            dgvNotas.RowCount = (N + 3);

            //Cell = columna
            dgvNotas.Rows[N].Cells[0].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N+1].Cells[0].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N+2].Cells[0].Style.BackColor = Color.Transparent;

            dgvNotas.Rows[N].Cells[8].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N + 1].Cells[8].Style.BackColor = Color.Transparent;
            dgvNotas.Rows[N + 2].Cells[8].Style.BackColor = Color.Transparent;


            // Configura "Nota Prom" en la fila N
            dgvNotas.Rows[N].Cells[1].Value = "Nota Prom";
            dgvNotas.Rows[N].Cells[1].Style.BackColor = Color.SkyBlue;

            // Configura "Nota Mayor" en la fila N+1
            dgvNotas.Rows[N + 1].Cells[1].Value = "Nota Mayor";
            dgvNotas.Rows[N + 1].Cells[1].Style.BackColor = Color.SkyBlue;

            // Configura "Nota Menor" en la fila N+2
            dgvNotas.Rows[N + 2].Cells[1].Value = "Nota Menor";
            dgvNotas.Rows[N + 2].Cells[1].Style.BackColor = Color.SkyBlue;


            for( F =0; F <= (N-1); F++)
            {
                vNombres[F] = Interaction.InputBox("Ingrese el nombre del estudiante");
                dgvNotas.Rows[F].Cells[0].Value = vNombres[F];

               

                mNotas[F, 0] = Convert.ToDouble(Interaction.InputBox("Ingrese el codigo del estudiante"));
                dgvNotas.Rows[F].Cells[1].Value = mNotas[F, 0];
                mNotas[F, 1] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 1:"));
                dgvNotas.Rows[F].Cells[2].Value = mNotas[F, 1];
                mNotas[F, 2] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 2: "));
                dgvNotas.Rows[F].Cells[3].Value = mNotas[F, 2];
                mNotas[F, 3] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 3: "));
                dgvNotas.Rows[F].Cells[4].Value = mNotas[F, 3];
                mNotas[F, 4] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 4: "));
                dgvNotas.Rows[F].Cells[5].Value = mNotas[F, 4];
                mNotas[F, 5] = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 5: "));
                dgvNotas.Rows[F].Cells[6].Value = mNotas[F, 5];

                mNotas[F, 6] = (((mNotas[F, 1] + mNotas[F, 2] + mNotas[F, 3]) / 3) * 0.25)+ (mNotas[F, 4]*0.35) + (mNotas[F, 5] * 0.40);

                dgvNotas.Rows[F].Cells[7].Value = mNotas[F, 6];

                if (mNotas[F, 6] >= 3)
                {
                    vResultado[F] = "Gano";
                    dgvNotas.Rows[F].Cells[8].Style.BackColor = Color.GreenYellow;



                }
                else
                {
                    vResultado[F] = "Perdio";
                    dgvNotas.Rows[F].Cells[8].Style.BackColor = Color.Red;
                }
                dgvNotas.Rows[F].Cells[8].Value = vResultado[F];


            }
            btnCalcular.Enabled = true;
            btnIngresar.Enabled = false;



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double acum=0, nMayor=0, nMenor=0;
            double[,] mTotales = new double[3, 6];

            for (C = 1; C <=6; C++)
            {
               for(F=0; F <= (N - 1); F++)
                {
                    acum = acum + mNotas[F, C];
                   

                    if (F == 0)
                    {
                        nMayor = mNotas[F, C];
                        nMenor = mNotas[F, C];

                    } 
                    else
                    {
                      
                        if(mNotas[F , C] > nMayor)
                        {
                            nMayor = mNotas[F, C];
                        }
                        else
                        {
                            if(mNotas[F , C ] < nMenor)
                            {
                                nMenor = mNotas[F, C];
                            }
                        }
                    }


                }
                mTotales[0, C-1] = acum / N;
                dgvNotas.Rows[N].Cells[C + 1].Value = mTotales[0, C-1];
                mTotales[1, C-1] = nMayor;
                dgvNotas.Rows[N + 1].Cells[C + 1].Value = mTotales[1, C - 1];
                mTotales[2, C-1] = nMenor;
                dgvNotas.Rows[N + 2].Cells[C + 1].Value = mTotales[2, C - 1];
                acum = 0;
            }
            btnCalcular.Enabled = false;
            btnIngresar.Enabled = true;



        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Salir = MessageBox.Show("Esta seguro que desea salir"  , "Salir" , MessageBoxButtons.YesNo);

            if(Salir == DialogResult.Yes)
            {
                Close();
            }
            
            
        }
    }
}