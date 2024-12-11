using Messengerv2.ViewModel;
using Messengerv2.Model;
using Microsoft.Maui.Controls;
namespace Messengerv2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void OnChatSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var selectedChat = e.CurrentSelection[0] as Person;
                if (selectedChat != null)
                {
                    // Ustaw nowy kontekst danych dla widoku rozmowy
                    ChatView.SetBinding(ItemsView.ItemsSourceProperty, nameof(selectedChat.Messages));
                }
            }
        }

        private void OnImageTapped(object sender, EventArgs e)
        {
            var image = sender as Image;
            var selectedChat = image?.BindingContext as Person;
            if (selectedChat != null)
            {
                // Ustaw nowy kontekst danych dla widoku rozmowy
                ChatView.BindingContext = selectedChat;
            }
        }
    }

}
