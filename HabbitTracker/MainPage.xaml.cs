namespace HabbitTracker
{
    public partial class MainPage : ContentPage
    {

        private List<string> habits;

        public MainPage()
        {
            InitializeComponent();
            habits = new List<string>(); 
        }

        private async void NewHabbit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddHabitPage());
        }

        private void DisplayNewHabit(string habitName)
        {
            habits.Add(habitName);

            Task_made_.Text = habits.Count + "%"; 
        }
        private int currentDay = 24; 

        private void Date_back(object sender, EventArgs e)
        {
            // Go to the previous day
            currentDay--;
            if (currentDay < 1) currentDay = 31; 
            Data_habbit.Text = currentDay.ToString("D2") + ".12"; 
        }

        private void Date_next(object sender, EventArgs e)
        {
            // Go to the next day
            currentDay++;
            if (currentDay > 31) currentDay = 1; // Loop to the first day of the month
            Data_habbit.Text = currentDay.ToString("D2") + ".12"; // Update the date label
        }
    }
}
