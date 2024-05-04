using System;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class SudokuForm : Form
    {
        private SudokuBoard board;

        public SudokuForm()
        {
            InitializeComponent();
        }

        private void SudokuForm_Load(object sender, EventArgs e)
        {
            // Inicializa el tablero de Sudoku
            board = new SudokuBoard();
            board.GenerateNewGame();

            // Llena la cuadrícula con los números del tablero inicial
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 9; i++)
            {
                dataGridView1.Rows.Add(board.GetRow(i));
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Maneja el cambio de valor en una celda
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            DataGridViewCell cell = dataGridView1.Rows[row].Cells[col];
            int value;
            if (int.TryParse(cell.Value?.ToString(), out value))
            {
                if (board.SetCell(row, col, value))
                {
                    // Actualiza la cuadrícula si se establece un valor válido
                    UpdateGrid();
                }
                else
                {
                    // Si se intenta establecer un valor no válido, muestra un mensaje de error
                    MessageBox.Show("Movimiento no válido");
                    cell.Value = "";
                }
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // Genera un nuevo juego y actualiza la cuadrícula
            board.GenerateNewGame();
            UpdateGrid();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Comprueba si el jugador ha completado correctamente el juego
            if (board.IsComplete())
            {
                MessageBox.Show("¡Felicidades, has completado el Sudoku!");
            }
            else
            {
                MessageBox.Show("El Sudoku aún no está completo o contiene errores.");
            }
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            // Proporciona una pista al jugador
            SudokuBoard hintBoard = board.GetHint();
            if (hintBoard != null)
            {
                board = hintBoard;
                UpdateGrid();
            }
            else
            {
                MessageBox.Show("No hay pistas disponibles para este tablero.");
            }
        }
    }
}
