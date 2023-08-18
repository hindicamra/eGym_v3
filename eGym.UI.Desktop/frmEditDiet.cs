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

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Morate unijete opis obroka");
                return;
            }

            if (cmbDay.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati dan");
                return;
            }

            if (cmbMeal.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati obrok");
                return;
            }

            var request = new UpdateDietRequest()
            {
                Day = (DayOfWeek)cmbDay.SelectedIndex,
                Meal = (BLL.Models.Enums.Meal)cmbMeal.SelectedIndex,
                Description = rtxtDescription.Text
            };

            await _service.Put<DietDTO>(diet.DietId, request);
            MessageBox.Show("Uspjesno updatovan");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Desila se greska");
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            await _service.Delete(diet.DietId);

            cmbDay.SelectedIndex = 0;
            cmbDay.SelectedIndex = 0;
            rtxtDescription.Text = "";

            MessageBox.Show("Uspjesno obrisan unos");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Desila se greska");
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
