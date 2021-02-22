using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using ReinforcedConcreteFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;


namespace ReinforcedConcreteFactoryView
{
    public partial class FormCreateOrder : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReinforcedLogic _logicR;
        private readonly OrderLogic _logicO;
        public FormCreateOrder(ReinforcedLogic logicR, OrderLogic logicO)
        {
            InitializeComponent();
            _logicR = logicR;
            _logicO = logicO;
        }
        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<ReinforcedViewModel> listR = _logicR.Read(null);

                if (listR != null)
                {
                    orderReinforcedComboBox.DisplayMember = "ReinforcedName";
                    orderReinforcedComboBox.ValueMember = "Id";
                    orderReinforcedComboBox.DataSource = listR;
                    orderReinforcedComboBox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void CalcSum()
        {
            if (orderReinforcedComboBox.SelectedValue != null && !string.IsNullOrEmpty(orderReinforcedCountTextBox.Text))
            {
                try
                {
                    int id = Convert.ToInt32(orderReinforcedComboBox.SelectedValue);
                    ReinforcedViewModel product = _logicR.Read(new ReinforcedBindingModel
                    {
                        Id = id
                    })?[0];
                    int count = Convert.ToInt32(orderReinforcedCountTextBox.Text);
                    orderSumTextBox.Text = (count * product?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void orderReinforcedCountTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void orderReinforcedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderReinforcedCountTextBox.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (orderReinforcedComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    ReinforcedId = Convert.ToInt32(orderReinforcedComboBox.SelectedValue),
                    Count = Convert.ToInt32(orderReinforcedCountTextBox.Text),
                    Sum = Convert.ToDecimal(orderSumTextBox.Text)
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

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
