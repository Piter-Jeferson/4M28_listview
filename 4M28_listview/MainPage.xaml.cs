namespace _4M28_listview
{
    public class Uczen{
        public int nr {  get; set; }
        public string imie {  get; set; }
        public string klasa { get; set; }
        public Uczen(int nr, string imie, string klasa){
            this.nr = nr;
            this.imie = imie;
            this.klasa = klasa;
        }
        public override string ToString(){
            return $"{nr} {imie} {klasa}";
        }
    }
    public class Uczniowie{
        public static List<Uczen> uczniowie = new List<Uczen>(){
            new(1, "Ala", "Kot")
        };
    }
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

    }

}
