using System.Collections.ObjectModel;
using WpfHrManager.ViewModel;

namespace WpfHrManager
{
  internal class MainViewModel : BindableBase
  {
    private Person? selectedPerson;

    public Person? SelectedPerson
    {
      get { return selectedPerson; }
      set
      {
        SetProperty(ref selectedPerson, value);
      }
    }

    private ObservableCollection<Person> people = new ObservableCollection<Person>();

    public ObservableCollection<Person> People
    {
      get { return people; }
      set
      {
        SetProperty(ref people, value);
      }
    }

  }
}
