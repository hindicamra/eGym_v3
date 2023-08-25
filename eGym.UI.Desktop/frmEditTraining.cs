using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop;

public partial class frmEditTraining : Form
{
    private readonly APIService _service = new APIService("Training");
    private readonly TrainingDTO training;
    private readonly string name;
    bool ValidationInput1 = false, ValidationInput2 = false;

    public frmEditTraining(TrainingDTO training, string clientName)
    {
        this.training = training;
        name = clientName;
        InitializeComponent();
    }

    private void frmEditTraining_Load(object sender, EventArgs e)
    {
        txtName.Text = name;
        cmbDay.SelectedIndex = (int)training.Day;
        rtxtDescription.Text = training.Description;
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbDay.SelectedIndex != -1)
            {
                cmbDay.BackColor = SystemColors.Window;
                cmbDay.ForeColor = SystemColors.WindowText;
                ValidationInput1 = false;
            }
            else
            {
                cmbDay.BackColor = Color.LightPink;
                cmbDay.ForeColor = Color.Red;
                ValidationInput1 = true;
            }

            if (rtxtDescription.Text != "")
            {
                rtxtDescription.BackColor = SystemColors.Window;
                rtxtDescription.ForeColor = SystemColors.WindowText;
                rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
                ValidationInput2 = false;
            }
            else
            {
                rtxtDescription.BackColor = Color.LightPink;
                rtxtDescription.ForeColor = Color.Red;
                rtxtDescription.BorderStyle = BorderStyle.Fixed3D;
                ValidationInput2 = true;
            }

            if (!ValidationInput1 && !ValidationInput2)
            {
                var request = new UpdateTrainingRequest()
                {
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                await _service.Put<TrainingDTO>(training.TrainingId, request);
                labelError.Text = "Uspjesno updatovan";
            }     
        }
        catch (Exception ex)
        {
            labelError.Text = "Desila se greska";
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            await _service.Delete(training.TrainingId);

            cmbDay.SelectedIndex = 0;
            cmbDay.SelectedIndex = 0;
            rtxtDescription.Text = "";

            labelError.Text = "Uspjesno obrisan unos";
        }
        catch (Exception ex)
        {
            labelError.Text = "Desila se greska";
        }
    }
}
