using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using System.ComponentModel;

namespace eGym.UI.Desktop;

public partial class frmEditDiet : Form
{
    private readonly APIService _service = new APIService("Diet");
    private readonly DietDTO diet;
    private readonly string clientName;

    public frmEditDiet(DietDTO diet, string name)
    {
        this.diet = diet;
        clientName = name;
        InitializeComponent();

    }

    private void frmEditDiet_Load(object sender, EventArgs e)
    {
        txtName.Text = clientName;
        cmbDay.SelectedIndex = (int)diet.Day;
        cmbMeal.SelectedIndex = (int)diet.Meal;
        rtxtDescription.Text = diet.Description;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        e.Cancel = false;
        errorProviderApp.SetError(rtxtDescription, "");
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                labelError.Text = "Morate unijete opis obroka";
                return;
            }

            if (cmbDay.SelectedIndex == -1)
            {
                labelError.Text = "Morate odabrati dan";
                return;
            }

            if (cmbMeal.SelectedIndex == -1)
            {
                labelError.Text = "Morate odabrati obrok";
                return;
            }

            var request = new UpdateDietRequest()
            {
                Day = (DayOfWeek)cmbDay.SelectedIndex,
                Meal = (BLL.Models.Enums.Meal)cmbMeal.SelectedIndex,
                Description = rtxtDescription.Text
            };

            var response = await _service.Put(diet.DietId, request);

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

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            var response = await _service.Delete(diet.DietId);

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
                labelError.Text = $"Desila se greska prilikom brisanja";
            }
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
            errorProviderApp.SetError(rtxtDescription, "Morate unijeti opis");
        }
        else
        {
            e.Cancel = false;
            errorProviderApp.SetError(rtxtDescription, "");
        }
    }
}
