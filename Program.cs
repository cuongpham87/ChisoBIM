// Chỉ số khối cơ thể (Body mass index-BMI) là một thước đo sức khoẻ dựa trên cân nặng và chiều cao. 
// Nó được tính bằng cách lấy cân nặng đơn vị tính kilogam chia cho bình phương của chiều cao đơn vị tính mét. Công thức:
//bmi = weight / height
//Viết chương trình nhập vào cân nặng và chiều cao của 1 người
public class Program
{
    public static void Main(string[] args)
    {
        double weight;
        double height;
        double bmi;
        Console.Write("NHập cân nặng (kg)");
        weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhập chiều cao (m)");
        height = Convert.ToDouble(Console.ReadLine());
        bmi = weight / (height * height);
        Console.WriteLine($"chỉ số cơ thể của con người là {bmi})");
        if (bmi < 16)
            Console.WriteLine("Gầy độ III");
        else if (bmi >= 16 && bmi < 17)
            Console.WriteLine("Gầy độ II");
        else if (bmi >= 17 && bmi < 18.5)
            Console.WriteLine("Gầy độ I");
        else if (bmi >= 18.5 && bmi < 25)
            Console.WriteLine("Bình thường");
        else if (bmi >= 25 && bmi < 30)
            Console.WriteLine("Thừa cân");
        else if (bmi >= 30 && bmi < 35)
            Console.WriteLine("Béo phì độ I");
        else if (bmi >= 35 && bmi < 40)
            Console.WriteLine("Béo phì độ II");
        else
            Console.WriteLine("Béo phì độ III");

    }
}
