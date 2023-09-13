using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop;

public partial class frmEditTraining : Form
{
    private readonly APIService _service = new APIService("Training");
    private readonly TrainingDTO training;
    private readonly string name;

    public frmEditTraining(TrainingDTO training, string clientName)
    {
        InitializeComponent();
        this.training = training;
        name = clientName;
        this.cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private void frmEditTraining_Load(object sender, EventArgs e)
    {
        txtName.Text = name;
        cmbDay.SelectedIndex = (int)training.Day;
        rtxtDescription.Text = training.Description;
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (ValidateChildren())
        {
            try
            {
                var request = new UpdateTrainingRequest()
                {
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                var response = await _service.Put(training.TrainingId, request);

                if (response != null && response.StatusCode == 202)
                {
                    MessageBox.Show("Uspjesno updatovan");
                }
                else
                {
                    labelError.Text = "Desila se greska prilikom updatetovanja";
                }
            }
            catch (Exception ex)
            {
                labelError.Text = "Desila se greska";
            }
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            var response = await _service.Delete(training.TrainingId);

            if (response != null && response.StatusCode == 204)
            {
                cmbDay.SelectedIndex = 0;
                cmbDay.SelectedIndex = 0;
                rtxtDescription.Text = "";

                MessageBox.Show("Uspjesno obrisan unos");
                this.Close();
            }
            else
            {
                labelError.Text = "Desila se greska prilikom brisanja";
            }
        }
        catch (Exception ex)
        {
            labelError.Text = "Desila se greska";
        }
    }

    private void SetError(Control control, string message)
    {
        err.SetError(control, message);
        control.Focus();
    }

    private void rtxtDescription_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(rtxtDescription.Text))
        {
            e.Cancel = true;
            SetError(rtxtDescription, "Morate unijeti trening");
        }
        else
        {
            e.Cancel = false;
            SetError(rtxtDescription, "");
        }
    }
}
