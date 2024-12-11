using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messengerv2.Model;
namespace Messengerv2.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _chatItems;
        public ObservableCollection<Person> ChatI
        {
            get => _chatItems;
            set
            {
                _chatItems = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChatI)));
            }
        }

        private Person _selectedChat;
        public Person SelectedChat
        {
            get => _selectedChat;
            set
            {
                _selectedChat = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedChat)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainPageViewModel()
        {
            ChatI = new ObservableCollection<Person>();

            ChatI.Add(new Person
            {
                Id = 1,
                Name = "Karolina Wiśniewska",
                Description = "Uwielbiam górskie wędrówki",
                ImageSrc = "osoba1.jpg",
                Messages = new ObservableCollection<Message>
                {
                    new Message { Sender = "Karolina Wiśniewska", Text = "Hej, widziałaś nowe szlaki?", setByUser = false },
                    new Message { Sender = "Ty", Text = "Jeszcze nie, ale chętnie zobaczę!", setByUser = true },
                    new Message { Sender = "Karolina Wiśniewska", Text = "Mogę wysłać link, jeśli chcesz.", setByUser = false },
                    new Message { Sender = "Ty", Text = "Super, dzięki!", setByUser = true }
                }
            });

            ChatI.Add(new Person
            {
                Id = 2,
                Name = "Marek Nowak",
                Description = "Fanatyk motoryzacji",
                ImageSrc = "osoba2.jpg",
                Messages = new ObservableCollection<Message>
                {
                    new Message { Sender = "Marek Nowak", Text = "Kiedy jedziemy na tor?", setByUser = false },
                    new Message { Sender = "Ty", Text = "Może w sobotę?", setByUser = true },
                    new Message { Sender = "Marek Nowak", Text = "Pasuje, zarezerwuję miejsce.", setByUser = false },
                    new Message { Sender = "Ty", Text = "Dzięki, do zobaczenia!", setByUser = true }
                }
            });

            ChatI.Add(new Person
            {
                Id = 3,
                Name = "Paulina Zawadzka",
                Description = "Książki to moja pasja",
                ImageSrc = "osoba3.jpg",
                Messages = new ObservableCollection<Message>
                {
                    new Message { Sender = "Paulina Zawadzka", Text = "Czy czytałeś już nową powieść Kinga?", setByUser = false },
                    new Message { Sender = "Ty", Text = "Nie, ale mam ją na liście do przeczytania.", setByUser = true },
                    new Message { Sender = "Paulina Zawadzka", Text = "Koniecznie, jest świetna!", setByUser = false },
                    new Message { Sender = "Ty", Text = "Dzięki za polecenie!", setByUser = true }
                }
            });

            ChatI.Add(new Person
            {
                Id = 4,
                Name = "Tomasz Malinowski",
                Description = "Sport to zdrowie",
                ImageSrc = "osoba4.jpg",
                Messages = new ObservableCollection<Message>
                {
                    new Message { Sender = "Tomasz Malinowski", Text = "Idziesz na mecz w sobotę?", setByUser = false },
                    new Message { Sender = "Ty", Text = "Tak, już nie mogę się doczekać!", setByUser = true },
                    new Message { Sender = "Tomasz Malinowski", Text = "Będzie świetna atmosfera.", setByUser = false },
                    new Message { Sender = "Ty", Text = "To na pewno!", setByUser = true }
                }
            });

            ChatI.Add(new Person
            {
                Id = 5,
                Name = "Anna Kowalska",
                Description = "Mistrzyni w kuchni",
                ImageSrc = "osoba5.jpg",
                Messages = new ObservableCollection<Message>
                {
                    new Message { Sender = "Anna Kowalska", Text = "Mam nowy przepis na ciasto.", setByUser = false },
                    new Message { Sender = "Ty", Text = "Podzielisz się?", setByUser = true },
                    new Message { Sender = "Anna Kowalska", Text = "Oczywiście, już wysyłam!", setByUser = false },
                    new Message { Sender = "Ty", Text = "Dzięki, wypróbuję w weekend!", setByUser = true }
                }
            });


            SelectedChat = ChatI.FirstOrDefault(c => c.Id == 1);
        }
    }
}
