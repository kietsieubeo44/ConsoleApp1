using System;

class ToaDo
{
	private double x;
	private double y;
	private string tenToaDo;

	public ToaDo()
	{
		x = 0.0;
		y = 0.0;
		tenToaDo = "Origin";
	}

	public ToaDo(double x, double y, string tenToaDo)
	{
		this.x = x;
		this.y = y;
		this.tenToaDo = tenToaDo;
	}

	public double X
	{
		get { return x; }
		set { x = value; }
	}

	public double Y
	{
		get { return y; }
		set { y = value; }
	}

	public string TenToaDo
	{
		get { return tenToaDo; }
		set { tenToaDo = value; }
	}

	public override string ToString()
	{
		return $"{tenToaDo} ({x}, {y})";
	}
}

class Program
{
	static void Main(string[] args)
	{
		ToaDo toaDo1 = new ToaDo(3.5, 2.0, "A");
		ToaDo toaDo2 = new ToaDo(-1.0, 4.2, "B");
		ToaDo toaDo3 = new ToaDo();

		Console.WriteLine("Thông tin các tọa độ:");
		Console.WriteLine(toaDo1);
		Console.WriteLine(toaDo2);
		Console.WriteLine(toaDo3);
		Console.ReadKey();
	}
}
