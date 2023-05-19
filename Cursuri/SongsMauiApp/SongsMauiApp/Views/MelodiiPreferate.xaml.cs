using SongsMauiApp.Models;

namespace SongsMauiApp.Views;

public partial class MelodiiPreferate : ContentPage
{
    private List<Song> songs = new List<Song>();
	private SongDAO songDAO;

    public MelodiiPreferate()
	{
		InitializeComponent();
		songDAO = new SongDAO();	

		getSongs();
	}

	public async void getSongs()
	{
		songs = await songDAO.GetAll();

		listViewFavoriteSongs.ItemsSource = songs;
	}
}