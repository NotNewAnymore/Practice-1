namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car carEx = new Car("Ford","Pinto",1978,"Beige",2);
			Console.WriteLine(carEx);
			Bike bike = new Bike();
			Console.WriteLine(bike);
			Cd cd1 = new Cd(Cd.CdSize.Standard,"Ali Project","Noblerot",58,13);
			Console.WriteLine(cd1);
		}
	}
	
	public class Car
	{
		string _make;
		string _model;
		int _year;
		string _color;
		int _mileage;

		public Car(string make = "Mercury", string model = "Villager", int year = 1997, string color = "Red", int mileage = 8)
		{
			_make = make;
			_model = model;
			_year = year;
			_color = color;
			_mileage = mileage;
		}

		public string Make { get => _make; set => _make = value; }
		public string Model { get => _model; set => _model = value; }
		public int Year { get => _year; set => _year = value; }
		public string Color { get => _color; set => _color = value; }
		public int Mileage { get => _mileage; set => _mileage = value; }

		public override string ToString()
		{
			return $"Make is {_make}, model is {_model}, year is {_year}, color is {_color}, mileage is {_mileage}MPG";
		}
	}
	public class Bike
	{
		public enum Type
		{
			Farthing,
			Safety,
			Shaft_Drive
		}
		string _brand;
		Type _type;
		string _color;
		int _wheels;

		public string Brand { get => _brand; set => _brand = value; }
		public Type Type1 { get => _type; set => _type = value; }
		public string Color { get => _color; set => _color = value; }
		public int Wheels { get => _wheels; set => _wheels = value; }

		public Bike(string brand = "JeffBikes", Type type = Type.Safety, string color = "Blue", int wheels = 2)
		{
			_brand = brand;
			_type = type;
			_color = color;
			_wheels = wheels;
		}

		public override string ToString()
		{
			return $"Brand is {_brand}, Type is {_type}, Color is {_color}, and it has {_wheels} wheels.";
		}
	}
	public class Cd
	{
		public enum CdSize
		{
			Mini,
			Standard
		}
		CdSize _size;
		string _artist;
		string _album;
		float _length;
		int _songs;

		public CdSize Size { get => _size; }	//As thse are music CDs, and not rewriteable CDs, they have no setters.
		public string Artist { get => _artist; }
		public string Album { get => _album; }
		public float Length { get => _length; }
		public int Songs { get => _songs; }

		public Cd(CdSize size, string artist, string album, float length, int songs)
		{
			_size = size;
			_artist = artist;
			_album = album;
			_length = length;
			_songs = songs;
		}
		//I could have a list of songs here, but I don't feel like it. Same with genre, but genres are annoyingly hard to define.
		public override string ToString()
		{
			return $"{_album} by {_artist} is {_length} minutes long, and has {_songs} songs.";
		}
	}
}