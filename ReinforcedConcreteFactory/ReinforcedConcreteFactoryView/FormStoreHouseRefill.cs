using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace ReinforcedConcreteFactoryView
{
    public partial class FormStoreHouseRefill : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int StoreHouserId
        {
            get => Convert.ToInt32(storehouseComboBox.SelectedValue);
            set => storehouseComboBox.SelectedValue = value;
        }

        public int MaterialId
        {
            get => Convert.ToInt32(materialComboBox.SelectedValue);
            set => materialComboBox.SelectedValue = value;
        }

        public int Count
        {
            get => Convert.ToInt32(countTextBox.Text);
            set => countTextBox.Text = value.ToString();
        }

        private readonly StoreHouseLogic storehouseLogic;
        public FormStoreHouseRefill(StoreHouseLogic storehouseLogic, MaterialLogic materialLogic)
        {
            InitializeComponent();
            this.storehouseLogic = storehouseLogic;
            List<MaterialViewModel> materialViews = materialLogic.Read(null);
            if (materialViews != null)
            {
                materialComboBox.DisplayMember = "MaterialName";
                materialComboBox.ValueMember = "Id";
                materialComboBox.DataSource = materialViews;
                materialComboBox.SelectedItem = null;
            }

            List<StoreHouseViewModel> storehouseViews = storehouseLogic.Read(null);
            if (storehouseViews != null)
            {
                storehouseComboBox.DisplayMember = "StoreHouseName";
                storehouseComboBox.ValueMember = "Id";
                storehouseComboBox.DataSource = storehouseViews;
                storehouseComboBox.SelectedItem = null;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(countTextBox.Text))
            {
                MessageBox.Show("Введите количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (materialComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите материал", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (storehouseComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите склад", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            storehouseLogic.AddMaterial(new AddMaterialBindingModel
            {
                MaterialId = Convert.ToInt32(materialComboBox.SelectedValue),
                StoreHouseId = Convert.ToInt32(storehouseComboBox.SelectedValue),
                Count = Convert.ToInt32(countTextBox.Text)
            });

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
