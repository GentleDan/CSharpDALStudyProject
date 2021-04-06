using ReinforcedConcreteFactoryBusinessLogic.BindingModels;
using ReinforcedConcreteFactoryBusinessLogic.BusinessLogics;
using System;
using System.Windows.Forms;
using Unity;

namespace ReinforcedConcreteFactoryView
{
    public partial class FormReportReinforcedMaterials : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic logic;
        public FormReportReinforcedMaterials(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormReportProductComponents_Load(object sender, EventArgs e)
        {
            try
            {
                var dict = logic.GetReinforcedMaterials();
                if (dict != null)
                {
                    reportReinforcedMaterialsDataGridView.Rows.Clear();
                    foreach (var elem in dict)
                    {
                        reportReinforcedMaterialsDataGridView.Rows.Add(new object[] { elem.ReinforcedName, "", ""});
                        foreach (var listElem in elem.ReinforcedMaterials)
                        {
                            reportReinforcedMaterialsDataGridView.Rows.Add(new object[] { "", listElem.Item1, listElem.Item2 });
                        }
                        reportReinforcedMaterialsDataGridView.Rows.Add(new object[] { "Итого", "", elem.TotalCount});
                        reportReinforcedMaterialsDataGridView.Rows.Add(new object[] { });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void saveToExcelButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveReinforcedMaterialToExcelFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName
                        });
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
