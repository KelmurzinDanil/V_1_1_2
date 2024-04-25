using DB_993;

namespace design
{
    public partial class OpenWindow : Form
    {
        public OpenWindow()
        {
            using (var applicationContex = new ApplicationContex())
            {
                applicationContex.ApplicationContext();
            }
            InitializeComponent();
            MaximizeBox = false;
            Design();
            LoginTextAutho.PlaceholderText = "Электронная почта";
            PasswordTextAutho.PlaceholderText = "Пароль";
            LoginTextAutho.KeyPress += LoginTextAutho_KeyPress;
            PasswordTextAutho.Enter += PasswordTextAutho_Enter;
            PasswordTextAutho.KeyPress += PasswordTextAutho_KeyPress;
        }
        public void Design()
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }
        private void PasswordTextAutho_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void PasswordTextAutho_Enter(object? sender, EventArgs e)
        {
            if (PasswordTextAutho.Text == "Пароль")
            {
                PasswordTextAutho.Text = String.Empty;
                PasswordTextAutho.PasswordChar = '*';
            }
        }

        private void LoginTextAutho_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.GetUnicodeCategory(e.KeyChar).Equals(System.Globalization.UnicodeCategory.LowercaseLetter) && !char.GetUnicodeCategory(e.KeyChar).Equals(System.Globalization.UnicodeCategory.UppercaseLetter))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar >= 'А' && e.KeyChar <= 'я')
                {
                    e.Handled = true;
                }
            }

            LoginTextAutho.GotFocus += (sender, e) =>
            {
                if (LoginTextAutho.Text == "Электронная почта")
                {
                    LoginTextAutho.Text = String.Empty;
                    LoginTextAutho.ForeColor = Color.Black;
                }
            };
        }

        private void LoginText_Click(object sender, EventArgs e)
        {
            LoginTextAutho.Clear();
        }

        private void PasswordText_Click(object sender, EventArgs e)
        {
            PasswordTextAutho.Clear();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var reg_win = new RegistrationWindow();
            reg_win.ShowDialog();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextAutho.Text) || string.IsNullOrWhiteSpace(PasswordTextAutho.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            HeshPassword heshPassword = new HeshPassword();
            using (var context = new ApplicationContex())
            {
                var user = context.Users.FirstOrDefault(user => user.Email == LoginTextAutho.Text
                && user.Password == heshPassword.GetPassword(PasswordTextAutho.Text));
                if (user == null)
                {
                    MessageBox.Show("Неверный адрес электронной почты или пароль.");
                    return;
                }

                MessageBox.Show("Вы успешно вошли в аккаунт!");
                var mainWindow = new MainWindow(LoginTextAutho.Text);
                mainWindow.ShowDialog();
                this.Hide();
            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageComboBox.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            Controls.Clear();
            InitializeComponent();
        }
    }
}
