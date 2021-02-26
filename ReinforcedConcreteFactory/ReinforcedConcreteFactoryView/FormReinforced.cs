using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace ReinforcedConcreteFactoryView
{
    public partial class FormReinforced : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set => id = value; }
        private readonly ReinforcedLogic logic;
        private int? id;
        private Dictionary<int, (string, int)> reinforcedMaterials;
        public FormReinforced(ReinforcedLogic service)
        {
            InitializeComponent();
            logic = service;
        }
        private void FormReinforced_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ReinforcedViewModel view = logic.Read(new ReinforcedBindingModel { Id = id.Value })?[0];
                    if (view != null)
                    {
                        reinforcedNameTextBox.Text = view.ReinforcedName;
                        reinforcedPriceTextBox.Text = view.Price.ToString();
                        reinforcedMaterials = view.ReinforcedMaterial;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                reinforcedMaterials = new Dictionary<int, (string, int)>();
            }
        }
        private void LoadData()
        {
            try
            {
                if (reinforcedMaterials != null)
                {
                    dataMaterialGridView.Rows.Clear();
                    foreach (KeyValuePair<int, (string, int)> pc in reinforcedMaterials)
                    {
                        dataMaterialGridView.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2 });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void addMaterialsForReinforcedButton_Click(object sender, EventArgs e)
        {
            FormReinforcedMaterial form = Container.Resolve<FormReinforcedMaterial>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (reinforcedMaterials.ContainsKey(form.Id))
                {
                    reinforcedMaterials[form.Id] = (form.MaterialName, form.Count);
                }
                else
                {
                    reinforcedMaterials.Add(form.Id, (form.MaterialName, form.Count));
                }
                LoadData();
            }
        }

        private void changeMaterialsForReinforcedButton_Click(object sender, EventArgs e)
        {
            if (dataMaterialGridView.SelectedRows.Count == 1)
            {
                FormReinforcedMaterial form = Container.Resolve<FormReinforcedMaterial>();
                int id = Convert.ToInt32(dataMaterialGridView.SelectedRows[0].Cells[0].Value);
                form.Id = id;
                form.Count = reinforcedMaterials[id].Item2;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    reinforcedMaterials[form.Id] = (form.MaterialName, form.Count);
                    LoadData();
                }
            }
        }

        private void deleteMaterialsForReinforcedButton_Click(object sender, EventArgs e)
        {
            if (dataMaterialGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        reinforcedMaterials.Remove(Convert.ToInt32(dataMaterialGridView.SelectedRows[0].Cells[0].Value));
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

        private void updateMaterialsForReinforcedButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void saveReinforcedButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(reinforcedNameTextBox.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(reinforcedPriceTextBox.Text))
            {
                MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (reinforcedMaterials == null || reinforcedMaterials.Count == 0)
            {
                MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new ReinforcedBindingModel
                {
                    Id = id,
                    ReinforcedName = reinforcedNameTextBox.Text,
                    Price = Convert.ToDecimal(reinforcedPriceTextBox.Text),
                    ReinforcedMaterials = reinforcedMaterials
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void cancelReinforcedButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
