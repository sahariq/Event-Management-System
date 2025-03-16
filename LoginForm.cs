using System;
using System.Windows.Forms;

namespace projectiteration2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Simulated database for demonstration
        private string GetUserRole(string email, string password)
        {
            // Simulated credentials (replace with database validation)
            if (email == "admin@example.com" && password == "admin123")
                return "Admin";
            if (email == "organizer@example.com" && password == "organizer123")
                return "Organizer";
            if (email == "attendee@example.com" && password == "attendee123")
                return "Attendee";
            if (email == "vendor@example.com" && password == "vendor123")
                return "Vendor";
            if (email == "sponsor@example.com" && password == "sponsor123")
                return "Sponsor";

            return null; // Invalid credentials
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // Get the email and password entered by the user
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            // Validate the credentials using GetUserRole
            string role = GetUserRole(email, password);

            if (role != null)
            {
                // Show success message
                MessageBox.Show($"Login successful! Redirecting to {role} dashboard.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the respective dashboard based on the role
                Form dashboardForm;
                switch (role)
                {
                    case "Admin":
                        dashboardForm = new AdminForm();
                        break;
                    case "Organizer":
                        dashboardForm = new OrganizerForm();
                        break;
                    case "Attendee":
                        dashboardForm = new AttendeeForm();
                        break;
                    case "Vendor":
                    case "Sponsor":
                        dashboardForm = new VendorSponsorDashboard();
                        break;
                    default:
                        MessageBox.Show("Invalid role. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                dashboardForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // Show error message for invalid credentials
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Registration logic (ensure all fields are valid and role-specific details are handled)
            string name = NameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string role = RoleTypeComboBox.SelectedItem.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the required fields.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulated registration success message
            MessageBox.Show($"Registration successful! You are registered as a {role}.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear registration fields after success
            ClearRegistrationFields();
        }

        private void ClearRegistrationFields()
        {
            NameTextBox.Clear();
            EmailTextBox.Clear();
            PasswordTextBox1.Clear();
            RoleTypeComboBox.SelectedIndex = 0; // Reset to default role
        }
    }
}
