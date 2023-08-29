using System;
using System.Text;

class HinhTamGiac
{
	private double ma;
	private double mb;
	private double mc;
	private string kieuTamGiac;

	public HinhTamGiac()
	{
		ma = 0;
		mb = 0;
		mc = 0;
		kieuTamGiac = "Không phải";
	}

	public HinhTamGiac(double ma, double mb, double mc)
	{
		if (ma <= 0 || mb <= 0 || mc <= 0 || ma + mb <= mc || ma + mc <= mb || mb + mc <= ma)
		{
			this.ma = 0;
			this.mb = 0;
			this.mc = 0;
			kieuTamGiac = "Không phải ";
		}
		else
		{
			this.ma = ma;
			this.mb = mb;
			this.mc = mc;
			KiemTraKieuTamGiac();
		}
	}

	public double Ma
	{
		get { return ma; }
		set
		{
			if (value > 0)
			{
				ma = value;
				KiemTraKieuTamGiac();
			}
		}
	}

	public double Mb
	{
		get { return mb; }
		set
		{
			if (value > 0)
			{
				mb = value;
				KiemTraKieuTamGiac();
			}
		}
	}

	public double Mc
	{
		get { return mc; }
		set
		{
			if (value > 0)
			{
				mc = value;
				KiemTraKieuTamGiac();
			}
		}
	}

	private void KiemTraKieuTamGiac()
	{
		if (ma == mb && mb == mc)
			kieuTamGiac = "Đều";
		else if (ma == mb || mb == mc || ma == mc)
			kieuTamGiac = "Cân";
		else
			kieuTamGiac = "Thường";
	}

	public double TinhChuVi()
	{
		return ma + mb + mc;
	}

	public double TinhDienTich()
	{
		double p = TinhChuVi() / 2;
		return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
	}

	public override string ToString()
	{
		return $"{ma,-10:0.00} {mb,-10:0.00} {mc,-10:0.00} {kieuTamGiac,10} {TinhChuVi(),17:0.00} {TinhDienTich(),19:0.00}";
	}
}

class Program
{
	static void Main(string[] args)
	{
		Console.OutputEncoding = Encoding.UTF8;
		Console.BackgroundColor = ConsoleColor.Cyan;
		Console.ForegroundColor = ConsoleColor.Red;
		HinhTamGiac tg1 = new HinhTamGiac(2, 3, 4);
		HinhTamGiac tg2 = new HinhTamGiac(1, 2, 5);
		HinhTamGiac tg3 = new HinhTamGiac(4, 4, 4);
		HinhTamGiac tg4 = new HinhTamGiac(3, 4, 5);
		HinhTamGiac tg5 = new HinhTamGiac(6, 6, 8);

		Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,10} {4,17} {5,19}","Cạnh ma", "Cạnh mb", "Cạnh mc", "Kiểu TG", "Chu vi", "Diện tích");
		Console.WriteLine(tg1);
		Console.WriteLine(tg2);
		Console.WriteLine(tg3);
		Console.WriteLine(tg4);
		Console.WriteLine(tg5);
	}
}
