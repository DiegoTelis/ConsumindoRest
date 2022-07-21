using FormConsumindoRest.Model;
using FormConsumindoRest.Repositorio;

namespace FormConsumindoRest
{
    public partial class Form1 : Form
    {
        TodoRepositorio _repositorio;
        List<Todo> todos;
        public Form1()
        {
            InitializeComponent();

            if (_repositorio == null)
                _repositorio = new TodoRepositorio();

            todos = _repositorio.GetTodosAPI();

            dtGrid.DataSource = todos;
            dtGrid.Refresh();
            dtGrid.Update();
        }

        
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var filtro = todos.Where(x => x.title.Contains(txtPesquisa.Text)).ToList();
                if (filtro.Any())
                {
                    //dtGrid.DataSource = null;
                    dtGrid.DataSource = filtro;
                    dtGrid.Refresh();
                    dtGrid.Update();
                }

            }

        }
    }
}