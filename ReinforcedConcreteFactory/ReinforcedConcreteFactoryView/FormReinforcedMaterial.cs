using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace ReinforcedConcreteFactoryView
{
    public partial class FormReinforcedMaterial : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id
        {
            get => Convert.ToInt32(materialNameComboBox.SelectedValue);
            set => materialNameComboBox.SelectedValue = value;
        }
        public string MaterialName => materialNameComboBox.Text;
        public int Count
        {
            get => Convert.ToInt32(countMaterialTextBox.Text);
            set => countMaterialTextBox.Text = value.ToString();
        }

        public FormReinforcedMaterial(MaterialLogic logic)
        {
            InitializeComponent();
            List<MaterialViewModel> list = logic.Read(null);
            if (list != null)
            {
                materialNameComboBox.DisplayMember = "MaterialName";
                materialNameComboBox.ValueMember = "Id";
                materialNameComboBox.DataSource = list;
                materialNameComboBox.SelectedItem = null;
            }
        }

        private void saveReinforcedMaterialButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countMaterialTextBox.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (materialNameComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void cancelReinforcedMaterialButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
