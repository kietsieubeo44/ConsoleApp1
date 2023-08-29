using System;
using System.Text;
class SinhVien
{
	private int maSV;
	private string hoTen;
	private double diemLT;
	private double diemTH;

	public SinhVien()
	{
		maSV = 0;
		hoTen = "Chưa cập nhật";
		diemLT = 0.0;
		diemTH = 0.0;
	}

	public SinhVien(int maSV, string hoTen, double diemLT, double diemTH)
	{
		this.maSV = maSV;
		this.hoTen = hoTen;
		this.diemLT = diemLT;
		this.diemTH = diemTH;
	}

	public int MaSV
	{
		get { return maSV; }
		set { maSV = value; }
	}

	public string HoTen
	{
		get { return hoTen; }
		set { if (!string.IsNullOrEmpty(value)) hoTen = value; }
	}

	public double DiemLT
	{
		get { return diemLT; }
		set { if (value >= 0.0 && value <= 10.0) diemLT = value; }
	}

	public double DiemTH
	{
		get { return diemTH; }
		set { if (value >= 0.0 && value <= 10.0) diemTH = value; }
	}

	public double TinhDiemTB()
	{
		return (diemLT + diemTH) / 2;
	}

	public override string ToString()
	{
		return string.Format("{0,-10} {1,-20} {2,10:0.00} {3,10:0.00} {4,10:0.00}", maSV, hoTen, diemLT, diemTH, TinhDiemTB());
	}
}

class bai2
{
	static void Main(string[] args)
	{
		SinhVien sv1 = new SinhVien(11111, "Nguyễn Thanh An", 8.50, 8.00);
		SinhVien sv2 = new SinhVien(22222, "Lê Thị Bông", 7.75, 6.50);
		SinhVien sv3 = new SinhVien();
		Console.OutputEncoding = Encoding.UTF8;
		Console.BackgroundColor = ConsoleColor.Cyan;
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("Nhập mã số của sinh viên sv3: ");
		sv3.MaSV = int.Parse(Console.ReadLine());

		Console.Write("Nhập họ và tên của sinh viên sv3: ");
		sv3.HoTen = Console.ReadLine();

		Console.Write("Nhập điểm lý thuyết của sinh viên sv3: ");
		sv3.DiemLT = double.Parse(Console.ReadLine());

		Console.Write("Nhập điểm thực hành của sinh viên sv3: ");
		sv3.DiemTH = double.Parse(Console.ReadLine());

		Console.WriteLine();
		Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10} {4,10}", "MSSV", "Họ Tên", "Điểm LT", "Điểm TH", "Điểm TB");
		Console.WriteLine(sv1);
		Console.WriteLine(sv2);
		Console.WriteLine(sv3);
		Console.ReadLine();
	}
}
