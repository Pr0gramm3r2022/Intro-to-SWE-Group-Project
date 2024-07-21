namespace SWE_Final_Project;

public partial class LoginScreen : Form
{
    public string username { get; set; }
    public LoginScreen()
    {
        InitializeComponent();
    }
    private Dictionary<string, string> authorizedUsers = new Dictionary<string, string>
    {
        {"Smithers, John" , "pass"},
        {"Jefferies, Thomas" , "pass2"},
        {"James, Larry" , "pass3"},
        {"Maddun, Greg" , "pass4"}
    };

    private void button1_Click(object sender, EventArgs e)
    {
        username = Username.Text;
        string inputPassword = Password.Text;

        if (authorizedUsers.ContainsKey(username) && authorizedUsers[username] == inputPassword)
        {
            HomeScreen homeScreen = new HomeScreen(authorizedUsers);
            homeScreen.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
