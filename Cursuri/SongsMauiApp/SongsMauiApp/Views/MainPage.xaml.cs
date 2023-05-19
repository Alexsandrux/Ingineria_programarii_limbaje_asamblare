using SongsMauiApp.Models;
using SongsMauiApp.Views;
using System.Net.Http.Json;

namespace SongsMauiApp;

public partial class MainPage : ContentPage
{
	private List<Song> songs = new List<Song>();

    private const string URL = "https://raw.githubusercontent.com/Alexsandrux/Json-File-Examples/main/songs-json.json";

    public MainPage()
	{
		InitializeComponent();

        getSongs();

	}

    public async void getSongs()
    {
        using (HttpClient client = new HttpClient())
        {
            songs = await client.GetFromJsonAsync<List<Song>>(URL);

            songs.ForEach(song => { song.IsFavorite = false; });

            listViewSongs.ItemsSource = songs;

        }
    }


    public void openFavoriteSongs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MelodiiPreferate());
    }

    public async void addSongToFavorites(object sender, EventArgs e)
    {
        Song selectedSong = listViewSongs.SelectedItem as Song;

        if (selectedSong == null) { return; }

        bool isFavorite = await DisplayAlert("Adaugare melodie favorita",
            $"Vrei sa adaugi aceasta melodie, {selectedSong.Nume}, la favorite?", "Da!", "Nu!");

        if (!isFavorite) return;

        SongDAO dao = new SongDAO();

        var result = await dao.Insert(selectedSong);

        if(result > 0)
        {
            await DisplayAlert("Succes!", "Melodia a fost adaugată la favorite.", "OK");
        }
        else
        {
            await DisplayAlert("Eroare!", "Melodia nu a putut fi adaugată la favorite.", "OK");

        }

    }
}


