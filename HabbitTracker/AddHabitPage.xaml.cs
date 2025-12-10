using Microsoft.Maui.Controls;

namespace HabbitTracker
{
    public partial class AddHabitPage : ContentPage
    {
        public AddHabitPage()
        {
            InitializeComponent();
        }

        private async void SaveHabit(object sender, EventArgs e)
        {
            var habitName = HabitNameEntry.Text;

            if (!string.IsNullOrWhiteSpace(habitName))
            {
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "Please enter a habit name.", "OK");
            }
        }
    }
}
