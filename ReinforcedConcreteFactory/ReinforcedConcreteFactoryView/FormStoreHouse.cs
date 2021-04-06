using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace ReinforcedConcreteFactoryView
{
    public partial class FormStoreHouse : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int? iD;

        public int Id
        {
            set => iD = value;
        }

        private readonly StoreHouseLogic logic;

        private Dictionary<int, (string, int)> storehouseMaterials;
        public FormStoreHouse(StoreHouseLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormStoreHouse_Load(object sender, EventArgs e)
        {
            if (iD.HasValue)
            {
                try
                {
                    StoreHouseViewModel view = logic.Read(
                        new StoreHouseBindingModel
                        {
                            Id = iD.Value
                        })?[0];

                    if (view != null)
                    {
                        nameOfStoreHouseTextBox.Text = view.StoreHouseName;
                        nameOfResponsibleTextBox.Text = view.NameOfResponsiblePerson;
                        storehouseMaterials = view.StoreHouseMaterials;
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
                storehouseMaterials = new Dictionary<int, (string, int)>();
            }
        }

        private void LoadData()
        {
            try
            {
                if (storehouseMaterials != null)
                {
                    materialsDataGridView.Rows.Clear();
                    foreach (KeyValuePair<int, (string, int)> storehouseMaterial in storehouseMaterials)
                    {
                        materialsDataGridView.Rows.Add(new object[] { storehouseMaterial.Key, storehouseMaterial.Value.Item1,
                        storehouseMaterial.Value.Item2 });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameOfStoreHouseTextBox.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(nameOfStoreHouseTextBox.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                logic.CreateOrUpdate(new StoreHouseBindingModel
                {
                    Id = iD,
                    StoreHouseName = nameOfStoreHouseTextBox.Text,
                    NameOfResponsiblePerson = nameOfResponsibleTextBox.Text,
                    StoreHouseMaterials = storehouseMaterials
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
