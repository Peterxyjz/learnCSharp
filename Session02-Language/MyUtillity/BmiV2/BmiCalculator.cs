namespace BmiV2
{
    /// <summary>
    /// 1 thư viện là 1 dependence: phụ thuộc
    /// Class này chứa các method liên quan đến chỉ số BMI - chí số sức khỏe của một cá nhân thông qua chiều cao và cân nặng
    /// </summary>
    public class BmiCalculator
    {
        //các hàm liên quan bmi

        /// <summary>
        /// Hàm này tính ra chỉ số Bmi dựa trên chiều cao và cân nặng
        /// </summary>
        /// <param name="weight">Cân nặng đo bằng kg</param>
        /// <param name="height">Chiều cao đo bằng m</param>
        /// <returns></returns>

        public static double GetBmi(double weight, double height)=> weight / (height * height);
        //nếu hàm chỉ có 1 lệnh duy nhất cho phép viết tắt để hàm chỉ còn tối thiểu
        //kĩ thuật này gọi là EXPRESSION BODY - THÂN HÀM NHÌN NHƯ BIỂU THỨC
        //CẤM TUYỆT ĐỐI NHẦM LẪN CÚ PHÁP => VỚI 1 LOẠI HÀM CŨNG XÀI 
        //NHƯNG GỌI LÀ BIỂU THỨC LAMBDA - LAMBDA EXPRESSION

        //public static double GetBmi(double weight, double height)
        //{
        //    return weight / (height * height);
        //}

        static void PrintBMIString() => Console.WriteLine("BMI stands for Body Mass Index");

    }
}
