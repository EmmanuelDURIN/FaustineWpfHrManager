using WpfHrManager.ViewModel;

namespace WpfHrManager
{
  public class Person : BindableBase
  {
    private int age;
    public int Age
    {
      get { return age; }
      set
      {
        SetProperty(ref age, value);
      }
    }
    private string firstName = "";
    public string FirstName
    {
      get { return firstName; }
      set
      {
        SetProperty(ref firstName, value);
      }
    }
    private string lastName = "";

    public string LastName
    {
      get { return lastName; }
      set
      {
        SetProperty(ref lastName, value);
      }
    }

  }
}
