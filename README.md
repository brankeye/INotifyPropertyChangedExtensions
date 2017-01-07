# INotifyPropertyChangedExtensions (INPCE)
Provides extension methods for INotifyPropertyChanged to raise the PropertyChanged event and reduce boilerplate code.

## API

```csharp
// Raises PropertyChanged only if the backingStore has changed and sets the property value.
public static bool SetProperty<T>(ref T backingStore, T value, PropertyChangedEventHandler handler, [CallerMemberName]string propertyName = "", Action onChanged = null);

// Always raises PropertyChanged, even if the backingStore has not changed, and sets the property value.
public static bool SetPropertyAlways<T>(ref T backingStore, T value, PropertyChangedEventHandler handler, [CallerMemberName]string propertyName = "", Action onChanged = null);

// Raises PropertyChanged, but does not set the property value.
public static void OnPropertyChanged(PropertyChangedEventHandler propertyChanged, [CallerMemberName] string propertyName = @"");
```

## Usage

```csharp
public class Person : INotifyPropertyChanged
{
	public string Name
	{
		get { return _name; }
		set { this.SetProperty(ref _name, value, PropertyChanged); }
	}
	private string _name;
	
	public string Email
	{
		get { return _email; }
		set 
		{
			_email = value;
			this.OnPropertyChanged(PropertyChanged); 
		}
	}
	private string _email;

	public event PropertyChangedEventHandler PropertyChanged;
}

## Install

INPCE is available on [Nuget](https://www.nuget.org/packages/INotifyPropertyChangedExtensions/).
It can be installed through the Package Manager Console with the following command

		Install-Package INotifyPropertyChangedExtensions