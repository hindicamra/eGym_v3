﻿using eGym.BLL.Models;
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
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                labelError.Text = "Morate unijete opis treninga";
                return;
            }

            if (cmbDay.SelectedIndex == -1)
            {
                labelError.Text = "Morate odabrati dan";
                return;
            }

            var request = new UpdateTrainingRequest()
            {
                Day = (DayOfWeek)cmbDay.SelectedIndex,
                Description = rtxtDescription.Text
            };

            await _service.Put<TrainingDTO>(training.TrainingId, request);
            labelError.Text = "Uspjesno updatovan";
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

    private void textBoxDescription_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
        {
            e.Cancel = true;
            rtxtDescription.Focus();
            errorProviderApp.SetError(rtxtDescription, "Morate unijeti username");
        }
        else
        {
            e.Cancel = false;
            errorProviderApp.SetError(rtxtDescription, "");
        }
    }
}
