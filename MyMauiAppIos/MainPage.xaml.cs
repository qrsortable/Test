namespace MyMauiAppIos;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void TakePhoto(object sender, EventArgs e)
	{
	  FileResult photo = await MediaPicker.Default.PickPhotoAsync(new MediaPickerOptions
	  {
	    Title = "Select your photo"
	  });
	                  
	  if (photo != null)
		{
		  var stream = await photo.OpenReadAsync();
		  myImage.Source = ImageSource.FromStream(() => stream);
		}
			                   
	}
}

