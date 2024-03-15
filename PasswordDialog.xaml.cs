using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1;

public partial class PasswordDialog : Window
{
    public string Password => PasswordBox.Password;

    public PasswordDialog()
    {
        InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        PasswordBox.Focus();
    }

    private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            OkButton_Click(this, new RoutedEventArgs());
        }
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        this.DialogResult = true;
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        this.DialogResult = false;
    }
}
