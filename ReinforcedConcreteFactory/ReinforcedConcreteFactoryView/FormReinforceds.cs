using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace ReinforcedConcreteFactoryView
{
    public partial class FormReinforceds : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReinforcedLogic logic;
        public FormReinforceds(ReinforcedLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormReinforceds_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<ReinforcedConcreteFactoryBusinessLogic.ViewModels.ReinforcedViewModel> list = logic.Read(null);
                if (list != null)
                {
                    dataReinforcedsGridView.DataSource = list;
                    dataReinforcedsGridView.Columns[0].Visible = false;
                    dataReinforcedsGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataReinforcedsGridView.Columns[3].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }


        private void addReinforcedsButton_Click(object sender, EventArgs e)
        {
            FormReinforced form = Container.Resolve<FormReinforced>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void updateReinforcedsButton_Click(object sender, EventArgs e)
        {
            if (dataReinforcedsGridView.SelectedRows.Count == 1)
            {
                FormReinforced form = Container.Resolve<FormReinforced>();
                form.Id = Convert.ToInt32(dataReinforcedsGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void deleteReinforcedsButton_Click(object sender, EventArgs e)
        {
            if (dataReinforcedsGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataReinforcedsGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new ReinforcedBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void refreshReinforcedsButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
